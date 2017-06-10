const fs = require('fs')
const database = require('../database/database')

module.exports = (req, res) => {
  if (!req.path.startsWith('/images/details/')) {
    return true
  }

  if (req.method === 'GET') {
    fs.readFile('./views/image-details.html', 'utf8', (err, data) => {
      if (err) {
        console.log(err)
        return
      }

      let imageNumber = req.path.split('/')[3]
      let image = database.getAll()[imageNumber - 1]
      let result = `<img  src ="${image.url}"/>`

      data = data.replace('{{content}}', result)

      res.writeHead(200, {
        'Content-Type': 'text/html'
      })
      res.write(data)
      res.end()
    })
  } else {
    return true
  }
}
