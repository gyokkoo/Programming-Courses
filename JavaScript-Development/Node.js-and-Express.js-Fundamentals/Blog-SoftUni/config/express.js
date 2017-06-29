const express = require('express')
const path = require('path')
const cookieParser = require('cookie-parser')
const bodyParser = require('body-parser')
const session = require('express-session')
const passport = require('passport')

module.exports = (app, config) => {
  app.set('views', path.join(config.rootFolder, '/views'))
  app.set('view engine', 'hbs')

  app.use(bodyParser.json())
  app.use(bodyParser.urlencoded({extended: true}))

  app.use(cookieParser())

  app.use(session({secret: 's3cr3t5tr1ng', resave: false, saveUninitialized: false}))

  app.use(passport.initialize())
  app.use(passport.session())

  app.use((req, res, next) => {
    if (req.user) {
      res.locals.user = req.user

      res.locals.user.isInRole('Admin').then(isAdmin => {
        res.locals.isAdmin = isAdmin
      })
    }
    next()
  })

  app.use(express.static(path.join(config.rootFolder, 'public')))
}