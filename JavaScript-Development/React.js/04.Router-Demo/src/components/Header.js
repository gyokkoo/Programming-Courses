import React from 'react'
import { Link } from 'react-router-dom'

let id = 2
const Header = () => (
  <div>
    <Link to='/'>Home</Link>
    <Link to='/about'>About</Link>
    <Link to='/contact'>Contact</Link>
    <Link to={'/page/with/' + id}>Params</Link>
  </div>
)

export default Header
