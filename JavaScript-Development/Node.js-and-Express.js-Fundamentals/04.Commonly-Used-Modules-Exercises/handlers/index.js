const homePageHandler = require('./home-page')
const faviconHandler = require('./favicon')
const staticFilesHandler = require('./static-files')
const imageUploadHandler = require('./image-upload')
const imageDetailHandler = require('./image-detail')
const statusHeaderHandler = require('./status-header')

module.exports = [
  statusHeaderHandler,
  homePageHandler,
  faviconHandler,
  imageUploadHandler,
  imageDetailHandler,
  staticFilesHandler
]
