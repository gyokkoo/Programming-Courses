const Recipe = require('../models/Recipe')

module.exports.index = (req, res) => {
  Recipe.find().then(recipes => {
    res.render('home/index', { recipes: recipes })
  })
}

module.exports.about = (req, res) => {
  res.render('home/about')
}

module.exports.contactUs = (req, res) => {
  res.render('home/contactUs')
}
