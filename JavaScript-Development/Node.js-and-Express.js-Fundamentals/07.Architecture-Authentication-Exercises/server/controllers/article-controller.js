const Article = require('mongoose').model('Article')

module.exports = {
  articleGet: (req, res) => {
    res.render('articles/add')
  },

  articlePost: (req, res) => {
    let articleArgs = req.body
    let errorMsg = ''
    if (!articleArgs.title) {
      errorMsg = 'Invalid title!'
    } else if (!articleArgs.content) {
      errorMsg = 'Invalid content!'
    }

    if (errorMsg) {
      res.render('articles/add', {error: errorMsg})
      return
    }

    articleArgs.author = req.user.id
    Article.create(articleArgs).then(article => {
      req.user.articles.push(article.id)
      req.user.save(err => {
        if (err) {
          res.redirect('/', {error: err.mesage})
        } else {
          res.redirect('/')
        }
      })
    })
  },

  detailsGet: (req, res) => {
    let id = req.params.id
    Article.findById(id).populate('author').sort('date').then(article => {
      res.render('articles/details', {
        article: article
      })
    }).catch(err => {
      res.redirect('/')
    })
  }
}
