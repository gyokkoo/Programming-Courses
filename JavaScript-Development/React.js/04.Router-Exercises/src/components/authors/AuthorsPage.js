import React, { Component } from 'react'
import Data from '../../data/Data'
import AuthorCard from './AuthorCard'

class AuthorsPage extends Component {
  constructor (props) {
    super(props)

    this.state = {
      authors: []
    }

    this.getAuthors = this.getAuthors.bind(this)
    this.ascending = this.ascending.bind(this)
    this.descending = this.descending.bind(this)
  }

  componentWillMount () {
    this.getAuthors()
  }

  getAuthors (isReversed) {
    Data.getAllAuthors().then(authors => this.setState({
      authors: authors.sort(this.comparator(isReversed)),
    }))
  }

  comparator (isReversed) {
    if (isReversed) {
      return (a, b) => a['name'].toString().localeCompare(b['name'].toString())
    }

    return (a, b) => b['name'].toString().localeCompare(a['name'].toString())
  }

  ascending () {
    this.getAuthors(false)
  }

  descending () {
    this.getAuthors(true)
  }

  render () {
    let author = this.state.authors.map((author, index) => {
      return <AuthorCard
        key={author.id}
        author={author}
        index={index} />
    })

    return (
      <div className='container'>
        <button className='btn btn-default' onClick={this.ascending}>In Ascending</button>
        <button className='btn btn-default' onClick={this.descending}>In Descending</button>
        <br /> <br />
        <div className='list-group'>
          {author}
        </div>
      </div>
    )
  }
}

export default AuthorsPage
