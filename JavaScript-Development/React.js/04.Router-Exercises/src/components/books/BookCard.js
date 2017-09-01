import React, { Component } from 'react'
import { Link } from 'react-router-dom'
import Data from '../../data/Data'

class BookCard extends Component {
  constructor (props) {
    super(props)
    this.state = {
      author: {
      }
    }
  }

  componentDidMount () {
    if (this.props.book.authorId) {
      Data.getAuthorById(this.props.book.authorId).then(author => this.setState({
        author: author
      }))
    }
  }

  render () {
    return (
      <div className='animated fadeIn'>
        <div className='media book'>
          <span className='position pull-left'>
            {Number(this.props.index) + 1 + '.'}
          </span>
          <div className='media-body'>
            <h4 className='media-heading'>
              <Link to={`/books/${this.props.book.id}`}>{this.props.book.title}</Link>
            </h4>
            <img src={this.props.book.image} alt='book' height='150' width='100' />
            <br />
            <p>
              <small>
                Author: &nbsp;
                <Link to={`/authors/${this.props.book.authorId}`}>
                  {this.state.author.name}
                </Link>
              </small>
            </p>
            <p>Description: &nbsp;
              {this.props.book.description}
            </p>
            <hr />
          </div>
        </div>
      </div>
    )
  }
}

export default BookCard
