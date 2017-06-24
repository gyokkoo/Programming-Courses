const homeController = require('./home')
const productController = require('./product')
const userController = require('./user')
const categoryController = require('./category')

module.exports = {
  home: homeController,
  product: productController,
  user: userController,
  category: categoryController
}
