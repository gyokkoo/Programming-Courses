import React from 'react'
import { Link } from 'react-router-dom'

class Navbar extends React.Component {
  render () {
    return (
      <nav className='navbar navbar-default'>
        <div className='navbar-header'>
          <button type='button' className='navbar-toggle collapsed'
            data-toggle='collapse'
            data-target='#navbar'>
            <span className='sr-only'>Toggle navigation</span>
            <span className='icon-bar' />
            <span className='icon-bar' />
          </button>
          <Link to='/' className='navbar-brand'>
            Home
          </Link>
        </div>
        <div id='navbar' className='navbar-collapse collapse'>
          <ul className='nav navbar-nav'>
            <li>
              <Link to='/books/all'>All Books</Link>
            </li>
            <li>
              <Link to='/authors/all'>All authors</Link>
            </li>
          </ul>
        </div>
      </nav>
    )
  }
}

export default Navbar
