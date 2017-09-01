import React, { Component } from 'react'
import Data from '../../data/Data'
import BookCard from '../books/BookCard'

class BooksPage extends Component {
  constructor (props) {
    super(props)

    this.state = {
      books: [],
      criteria: ['addedDate']
    }

    this.sortByTitle = this.sortByTitle.bind(this)
    this.sortByDate = this.sortByDate.bind(this)
    this.getBooks = this.getBooks.bind(this)
  }

  componentDidMount () {
    this.getBooks()
  }

  comparator (criteria) {
    let prop = criteria[0]
    return (a, b) => a[prop].toString().localeCompare(b[prop].toString())
  }

  sortByTitle () {
    this.setState({
      criteria: ['title']
    })

    this.getBooks()
  }
  
  sortByDate () {
    this.setState({
      criteria: ['addedDate']
    })

    this.getBooks()
  }

  getBooks () {
    Data.getAllBooks().then(books => this.setState({
      books: books.sort(this.comparator(this.state.criteria))
    }))
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
        <button className='btn btn-default' onClick={this.sortByTitle}>By Title</button>  
        <button className='btn btn-default' onClick={this.sortByDate}>By Date</button>
        <br />
        <br />
        <div className='list-group'>
          {books}
        </div>
      </div>
    )
  }
}

export default BooksPage
