import React, { Component } from 'react'
import { Link } from 'react-router-dom'

class AuthorCard extends Component {
  render () {
    return (
      <div className='animated fadeIn'>
        <div className='media book'>
          <span className='position pull-left'>
            {Number(this.props.index) + 1}
          </span>
          <div className='media-body'>
            <h4 className='media-heading'>
              <Link to={`/authors/${this.props.author.id}`}>{this.props.author.name}</Link>
            </h4>
            <img src={this.props.author.image} alt='author' height='125' width='100' />
            <br />
          </div>
        </div>
      </div>
    )
  }
}

export default AuthorCard
