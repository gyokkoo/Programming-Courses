import $ from 'jquery'

let KinveyRequester = (function () {
  const baseUrl = 'https://baas.kinvey.com/'
  const appId = 'kid_r1IUXbP2'
  const appSecret = 'd65a1a31c04d49f7aaadcfaf12754ac4'
  const appAuthHeaders = {
    Authorization: 'Basic ' + btoa(appId + ':' + appSecret)
  }

  function loginUser (username, password) {
    return $.ajax({
      method: 'POST',
      url: baseUrl + 'user/' + appId + '/login',
      data: JSON.stringify({username, password}),
      contentType: 'application/json',
      headers: appAuthHeaders
    })
  }

  function registerUser (username, password) {
    return $.ajax({
      method: 'POST',
      url: baseUrl + 'user/' + appId + '/',
      data: JSON.stringify({username, password}),
      contentType: 'application/json',
      headers: appAuthHeaders
    })
  }

  function findAllBooks () {
    return $.ajax({
      method: 'GET',
      url: baseUrl + 'appdata/' + appId + '/books',
      headers: getUserAuthHeaders()
    })
  }

  function findBookById (bookId) {
    return $.ajax({
      method: 'GET',
      url: baseUrl + 'appdata/' + appId + '/books/' + bookId,
      headers: getUserAuthHeaders()
    })
  }

  function createBook (title, author, description) {
    return $.ajax({
      method: 'POST',
      url: baseUrl + 'appdata/' + appId + '/books',
      headers: getUserAuthHeaders(),
      data: JSON.stringify({title, author, description}),
      contentType: 'application/json'
    })
  }

  function editBook (bookId, title, author, description) {
    return $.ajax({
      method: 'PUT',
      url: baseUrl + 'appdata/' + appId + '/books/' + bookId,
      headers: getUserAuthHeaders(),
      data: { title, author, description }
    })
  }

  function deleteBook (bookId) {
    return $.ajax({
      method: 'DELETE',
      url: baseUrl + 'appdata/' + appId + '/books/' + bookId,
      headers: getUserAuthHeaders()
    })
  }

  function logoutUser () {
    return $.ajax({
      method: 'GET',
      url: baseUrl + 'user/' + appId + '/_logout',
      headers: getUserAuthHeaders()
    })
  }

  function getUserAuthHeaders () {
    return {
      Authorization: 'Kinvey ' + window.sessionStorage.getItem('authToken')
    }
  }

  return {
    loginUser,
    registerUser,
    findAllBooks,
    findBookById,
    createBook,
    editBook,
    deleteBook,
    logoutUser
  }
})()

export default KinveyRequester
