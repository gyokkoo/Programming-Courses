import React, { Component } from 'react'
import ReactDOM from 'react-dom'
import './App.css'

import NavigationBar from './components/NavigationBar'
import Footer from './components/Footer'

import HomeView from './views/HomeView'
import LoginView from './views/LoginView'
import RegisterView from './views/RegisterView'
import BooksView from './views/BooksView'
import CreateBookView from './views/CreateBookView'

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
    $(document).ajaxError(this.handleAjaxError.bind(this))

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
    this.showView(<LoginView onsubmit={this.login.bind(this)} />)
  }

  showRegisterView () {
    this.showView(<RegisterView onsubmit={this.register.bind(this)} />)
  }

  showBooksView () {
    KinveyRequester.loadBooks().then(loadBooksSuccess.bind(this))

    function loadBooksSuccess (books) {
      this.showView(<BooksView books={books} onedit={this.loadBookForEdit.bind(this)} ondelete={this.loadBookForDelete.bind(this)} />)
      this.showInfo('Books loaded')
    }
  }

  showCreateBookView () {
    this.showView(<CreateBookView onsubmit={this.createBook.bind(this)} />)
  }

  createBook (title, author, description) {
    KinveyRequester.createBook(title, author, description).then(createBookSuccess.bind(this))

    function createBookSuccess (userInfo) {
      this.saveAuthInSession(userInfo)
      this.showBooksView()
      this.showInfo('Book created')
    }
  }

  showEditBookView () {
    this.showView(<EditBookView onsubmit={this.editBook.bind(this)} />)
  }

  editBook (title, author, description) {

  }

  login (username, password) {
    KinveyRequester.loginUser(username, password).then(loginSuccess.bind(this))

    function loginSuccess (userInfo) {
      this.saveAuthInSession(userInfo)
      this.showBooksView()
      this.showInfo('You have successfully logged in')
    }
  }

  register (username, password) {
    KinveyRequester.loginUser(username, password).then(registerSuccess.bind(this))

    function registerSuccess (userInfo) {
      this.saveAuthInSession(userInfo)
      this.showBooksView()
      this.showInfo('You have successfully registered')
    }
  }

  saveAuthInSession (userInfo) {
    window.sessionStorage.setItem('authToken', userInfo._kmd.authtoken)
    window.sessionStorage.setItem('userId', userInfo._id)
    window.sessionStorage.setItem('username', userInfo.username)

    // This will update the entire app UI (e.g. the navigation bar)
    this.setState({
      username: userInfo.username,
      userId: userInfo._id
    })
  }

  logout () {
    window.sessionStorage.clear()

    this.setState({
      username: null,
      userId: null
    })

    this.showHomeView()
  }
}
