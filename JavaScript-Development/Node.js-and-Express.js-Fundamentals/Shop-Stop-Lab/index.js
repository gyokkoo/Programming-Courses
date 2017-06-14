const http = require('http')
const handlers = require('./handlers')
const config = require('./config/config')
const database = require('./config/database.config')

let environment = process.env.NODE_ENV || 'development'
database(config[environment])
const port = 3500

http.createServer((req, res) => {
  for (let handler of handlers) {
    if (!handler(req, res)) {
      break
    }
  }
}).listen(port)

console.log(`Node.js server running on port ${port}`)
