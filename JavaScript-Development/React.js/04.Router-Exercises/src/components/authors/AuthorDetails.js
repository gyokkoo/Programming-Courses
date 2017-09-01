import React, { Component } from 'react'
import AuthorCard from './AuthorCard'
import BookCard from '../books/BookCard'
import Data from '../../data/Data'

class AuthorDetails extends Component {
  constructor (props) {
    super(props)
    this.state = {
      author: {},
      books: []
    }
  }

  componentWillMount () {
    let id = this.props.match.params.id
    this.getAuthor(id)
  }

  getAuthor (id) {
    Data.getAuthorById(id).then(author => {
      this.setState({
        author
      })
      Data.getAllBooks().then(books => {
        this.setState({
          books: books.filter(book => book.authorId === this.state.author.id)
        })
      })
    })
  }

  render () {
    let books = this.state.books.map((book, index) => {
      return <BookCard
        key={book.id}
        book={book}
        index={index} />
    })

    return (
      <div className='container'>
        <h3 className='text-center'>Author Details</h3>
        <AuthorCard
          key={this.state.author.id}
          author={this.state.author}
          index={0} />
        <br />
        <p>
          Description: &nbsp;
          {this.state.author.description}
        </p>
        <h4>Books:</h4>
        <div className='smallerFont'>
          {books}
        </div>
      </div>
    )
  }
}

export default AuthorDetails
