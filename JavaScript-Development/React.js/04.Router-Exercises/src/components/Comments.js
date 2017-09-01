import React, { Component } from 'react'

class Comments extends Component {
  render () {
    let comments = this.props.comments.map((comment, index) => {
      return <h4 key={index}><em>{comment.user + ' : ' + comment.comment} </em></h4>
    })

    return (
      <div className='container'>
        {comments}
      </div>
    )
  }
}

export default Comments
