const controllers = require('../controllers')
const auth = require('./auth')

module.exports = (app) => {
  app.get('/', controllers.home.index)
  app.get('/about', controllers.home.about)

  app.get('/users/register', controllers.user.registerGet)
  app.post('/users/register', controllers.user.registerPost)

  app.get('/users/login', controllers.user.loginGet)
  app.post('/users/login', controllers.user.loginPost)

  app.post('/users/logout', controllers.user.logout)

  app.get('/users/profile', controllers.user.profileGet)

  app.get('/article/add', auth.isInRole('Admin'), controllers.article.articleGet)
  app.post('/article/add', auth.isInRole('Admin'), controllers.article.articlePost)

  app.get('/article/details/:id', controllers.article.detailsGet)

  app.all('*', (req, res) => {
    res.status(404)
    res.send('404 Not Found')
    res.end()
  })
}
