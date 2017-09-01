import React, { Component } from 'react'
import './App.css'
import Navbar from './components/Navbar'
import Routes from './routes'
class App extends Component {
  render () {
    return (
      <div>
        <Navbar />
        <div className='container'>
          <Routes />
        </div>
      </div>
    )
  }
}

export default App
