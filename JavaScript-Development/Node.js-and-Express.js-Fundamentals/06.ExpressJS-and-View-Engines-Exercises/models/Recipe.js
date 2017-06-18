const mongoose = require('mongoose')

let recipeSchema = mongoose.Schema({
  name: {type: mongoose.Schema.Types.String, required: true},
  description: {type: mongoose.Schema.Types.String, required: true},
  image: mongoose.Schema.Types.String
})

let Recipe = mongoose.model('Recipe', recipeSchema)

module.exports = Recipe
