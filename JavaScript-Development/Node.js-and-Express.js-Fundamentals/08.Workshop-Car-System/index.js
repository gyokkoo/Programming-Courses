const mongoose = require('mongoose')
mongoose.Promice = global.Promise

let env = process.env.NODE_ENV || 'development'

let app = require('express')()
let settings = require('./server/config/settings')[env]
require('./server/config/database')(settings)
require('./server/config/express')(app)
require('./server/config/routes')(app)
require('./server/config/passport')()
app.listen(settings.port)
console.log('Server is listening on port port ' + settings.port)
