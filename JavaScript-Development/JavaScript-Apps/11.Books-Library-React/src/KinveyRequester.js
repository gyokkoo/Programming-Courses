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

  }

  return {
    loginUser,
    registerUser
  }
})()

export default KinveyRequester
