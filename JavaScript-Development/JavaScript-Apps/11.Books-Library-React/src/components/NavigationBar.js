import React, { Component } from 'react'
import './NavigationBar.css'

export default class NavigationBar extends Component {
  render () {
    if (this.props.username == null) {
      return (
        <div className='navigation-bar'>
          <a href='#'>Home</a>
          <a href='#'>Login</a>
          <a href='#'>Register</a>
        </div>
      )
    } else {
      return (
        <div className='navigation-bar'>
          <a href='#'>Home</a>
          <a href='#'>Books</a>
          <a href='#'>Create Book</a>
          <a href='#'>Logout</a>
        </div>
      )
    }
  }
}
