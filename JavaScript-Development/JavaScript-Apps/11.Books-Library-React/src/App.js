import React, { Component } from 'react'
import ReactDOM from 'react-dom'
import './App.css'

import NavigationBar from './components/NavigationBar'
import Footer from './components/Footer'

import HomeView from './views/HomeView'
import LoginView from './views/LoginView'
import RegisterView from './views/RegisterView'

import $ from 'jquery'
import KinveyRequester from './KinveyRequester'

export default class App extends Component {
  constructor (props) {
    super(props)
    this.state = {
      username: null,
      userId: null
    }
  }

  render () {
    return (
      <div className='App'>
        <header>
          <NavigationBar
            username={this.state.username}
            homeClicked={this.showHomeView.bind(this)}
            loginClicked={this.showLoginView.bind(this)}
            registerClicked={this.showRegisterView.bind(this)}
            booksClicked={this.showBooksView.bind(this)}
            createBookClicked={this.showCreateBookView.bind(this)}
            logoutClicked={this.logout.bind(this)}
          />
          <div id='loadingBox'>Loading msg</div>
          <div id='infoBox'>Info msg</div>
          <div id='errorBox'>Error msg</div>
        </header>
        <div id='main' />
        <Footer />
      </div>
    )
  }

  componentDidMount () {
    // Attach global AJAX "loading" event handlers
    $(document).on({
      ajaxStart: function () {
        $('#loadingBox').show()
      },
      ajaxStop: function () {
        $('#loadingBox').hide()
      }
    })

    // Attach a global AJAX error handler
    $(document).ajaxError(
      this.handleAjaxError.bind(this))

    // Load state
    this.setState({
      username: sessionStorage.getItem('username'),
      userId: sessionStorage.getItem('userId')
    })

    this.showHomeView()

    $('#errorBox, #infoBox').click(function () {
      $('#errorBox').hide()
    })
  }

  handleAjaxError (event, response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0) {
      errorMsg = 'Cannot connect due to network error.'
    }
    if (response.responseJSON && response.responseJSON.description) {
      errorMsg = response.responseJSON.description
    }

    this.showError(errorMsg)
  }

  showInfo (message) {
    $('#infoBox').text(message).show()
    setTimeout(function () {
      $('#infoBox').fadeOut()
    }, 3000)
  }

  showError (errorMsg) {
    $('#errorBox').text('Error: ' + errorMsg).show()
  }

  showView (reactComponent) {
    ReactDOM.render(reactComponent, document.getElementById('main'))
    $('#errorBox').hide()
  }

  showHomeView () {
    this.showView(<HomeView username={this.state.username} />)
  }

  showLoginView () {
    this.showView(<LoginView onsubmit={this.login} />)

    // TODO: Login in Kinvey with AJAX
  }

  login (username, password) {
    KinveyRequester.loginUser(username, password).then(loginSuccess).bind(this)

    function loginSuccess () {
      this.showInfo('Login successul')
    }
  }

  showRegisterView () {
    this.showView(<RegisterView />)
  }

  showBooksView () {

  }

  showCreateBookView () {

  }

  logout () {
    this.setState(
      {username: null}
    )
  }
}
