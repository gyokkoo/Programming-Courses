import React, { Component } from 'react'
import Data from '../../data/Data'
import BookCard from './BookCard'
import Comments from '../Comments'

class BookDetails extends Component {
  constructor (props) {
    super(props)
    this.state = {
      book: {
        comments: []
      }
    }
  }

  componentWillMount () {
    let id = this.props.match.params.id
    this.getBook(id)
  }

  getBook (id) {
    Data.getBookById(id).then(book => this.setState({ book }))
  }

  render () {
    let commentsComponent = this.state.book.comments
      ? <Comments comments={this.state.book.comments} />
      : <div>No comments</div>

    return (
      <div className='container'>
        <h3 className='text-center'>Book Details</h3>
        <BookCard
          key={this.state.book.id}
          book={this.state.book}
          index={0} />
        <p>
          Price: &nbsp;
          {this.state.book.price}
        </p>
        <div className='list-group'>
          Comments:
          {commentsComponent}
        </div>
      </div>
    )
  }
}

export default BookDetails
