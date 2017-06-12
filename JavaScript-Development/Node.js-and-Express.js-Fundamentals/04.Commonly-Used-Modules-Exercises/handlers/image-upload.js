const fs = require('fs')
const database = require('../database/database')
const multiparty = require('multiparty')
const shortid = require('shortid')

module.exports = (req, res) => {
  if (req.path !== '/images/upload') {
    return true
  }

  if (req.method === 'GET') {
    fs.readFile('./views/image-upload-form.html', (err, data) => {
      if (err) {
        console.log(err)
        return
      }

      res.writeHead(200, {
        'Content-Type': 'text/html'
      })
      res.write(data)
      res.end()
    })
  } else if (req.method === 'POST') {
    let form = new multiparty.Form()
    let product = {}
    form.on('part', (part) => {
      if (part.filename) {
        let dataString = ''
        part.setEncoding('binary')
        part.on('data', (data) => {
          dataString += data
        })

        part.on('end', () => {
          let fileExtension = part.filename.split('.').pop()
          let fileName = shortid.generate()
          let folderNumber = database.data.getAll().length % 1000 + 1
          let filePath = '/content/images/' + folderNumber + '/' + fileName + '.' + fileExtension

          product.image = filePath

          let folderPath = '/content/images/' + folderNumber + '/'
          if (!fs.existsSync('.' + folderPath)) {
            fs.mkdirSync('.' + folderPath)
          }

          fs.writeFile(`.${filePath}`, dataString, { encoding: 'ascii' }, (err) => {
            if (err) {
              console.log(err)
            }
          })
        })
      } else {
        part.setEncoding('utf-8')
        let field = ''
        part.on('data', (data) => {
          field += data
        })

        part.on('end', () => {
          product[part.name] = field
        })
      }
    })

    form.on('close', () => {
      database.data.add(product)
      res.writeHead(302, {
        Location: '/'
      })

      res.end()
    })

    form.parse(req)
  } else {
    return true
  }
}
