import React, { Component } from 'react'
import Data from '../data/Data'
import BookCard from './books/BookCard'

const MAX_BOOKS = 2

class Home extends Component {
  constructor (props) {
    super(props)
    this.state = {
      books: []
    }

    this.getBooks = this.getBooks.bind(this)
  }

  componentDidMount () {
    this.getBooks(0, MAX_BOOKS)
  }

  getBooks (start, end) {
    Data.getAllBooks().then(books => this.setState({
      books: books.sort((a, b) => new Date(b.addedDate).getTime() - new Date(a.addedDate).getTime()).slice(start, end)
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
        <h3 className='text-center'>Welcome to Book Database</h3>
        <div className='list-group'>
          {books}
        </div>
      </div>
    )
  }
}

export default Home
