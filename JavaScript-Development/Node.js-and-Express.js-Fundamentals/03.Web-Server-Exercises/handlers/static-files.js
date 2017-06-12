const fs = require('fs')

let getContentType = (url) => {
  let contentType = 'text/plain'
  if (url.endsWith('.css')) {
    contentType = 'text/css'
  } else if (url.endsWith('.js')) {
    contentType = 'application/javascript'
  }

  return contentType
}

let validateFileExtension = (path) => {
  if (path.endsWith('.html') ||
    path.endsWith('.css') ||
    path.endsWith('.js') ||
    path.endsWith('jpg')) {
    return true
  }

  return false
}

module.exports = (req, res) => {
  fs.readFile('.' + req.path, (err, data) => {
    if (err || !req.path.startsWith('/content' || req.method !== 'GET') || !validateFileExtension(req.path)) {
      res.writeHead(404)
      res.write('404 Not Found! Please check your url')
      res.end()
      return
    }

    res.writeHead(200, {
      'Content-Type': getContentType(req.path)
    })
    res.write(data)
    res.end()
  })
}
