const http = require('http')
const handlers = require('./handlers')

const port = 3500

http.createServer((req, res) => {
  for (let handler of handlers) {
    if (!handler(req, res)) {
      break
    }
  }
}).listen(port)

console.log(`Node.js server running on port ${port}`)
