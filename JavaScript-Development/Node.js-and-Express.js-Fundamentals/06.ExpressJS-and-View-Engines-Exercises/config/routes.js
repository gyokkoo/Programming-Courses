const handlers = require('../handlers')
const multer = require('multer')

let upload = multer({ dest: './public/images' })

module.exports = (app) => {
  app.get('/', handlers.home.index)

  app.get('/about', handlers.home.about)

  app.get('/contact-us', handlers.home.contactUs)

  app.get('/recipe/add', handlers.recipe.addGet)

  app.post('/recipe/add', upload.single('recipeImage'), handlers.recipe.addPost)
}
