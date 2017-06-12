const fs = require('fs')

module.exports = (req, res) => {
  if (req.path === '/favicon.ico') {
    fs.readFile('./content/images/favicon.ico', (err, data) => {
      if (err) {
        console.log(err)
      }

      res.writeHead(200, {
        'Content-Type': 'image/x-icon'
      })
      res.write(data)
      res.end()
    })
  } else {
    return true
  }
}