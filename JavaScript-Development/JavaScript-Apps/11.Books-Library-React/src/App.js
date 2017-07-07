import React, { Component } from 'react'
import './App.css'
import NavigationBar from './components/NavigationBar'
import Footer from './components/Footer'
import $ from 'jquery'

export default class App extends Component {
  constructor (props) {
    super(props)
    this.state = {
      username: sessionStorage.getItem('username'),
      userId: sessionStorage.getItem('userId')
    }
  }

  render () {
    return (
      <div className='App'>
        <header>
          <NavigationBar username={this.state.username} />
          <div id='loadingBox'>Loading msg</div>
          <div id='infoBox'>Info msg</div>
          <div id='errorBox'>Error msg</div>
        </header>
        <div id='main'>
          Welcome to my App
        </div>
        <Footer />
      </div>
    )
  }
}
