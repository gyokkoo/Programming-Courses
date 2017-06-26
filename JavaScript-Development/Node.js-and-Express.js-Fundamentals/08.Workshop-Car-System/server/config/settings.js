const path = require('path')

let rootPath = path.normalize(__dirname, '/../../')

module.exports = {
  development: {
    rootPath: rootPath,
    db: 'mongodb://localhost/27017/rentingsystem',
    port: 3503
  },
  stagging: {
  },
  production: {
    port: process.env.PORT
  }
}
