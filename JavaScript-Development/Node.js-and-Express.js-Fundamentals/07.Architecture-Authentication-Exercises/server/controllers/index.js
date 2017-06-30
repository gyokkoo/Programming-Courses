const homeController = require('./home-controller')
const userController = require('./user-controller')
const articleController = require('./article-controller')

module.exports = {
  home: homeController,
  user: userController,
  article: articleController
}
