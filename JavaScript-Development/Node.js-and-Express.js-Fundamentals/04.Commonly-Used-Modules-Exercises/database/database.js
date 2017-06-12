const fs = require('fs')
const path = require('path')
const dbPath = path.join(__dirname, '/database.json')

function getAll () {
  if (!fs.existsSync(dbPath)) {
    fs.writeFileSync(dbPath, '[]')
    return []
  }
  let json = fs.readFileSync(dbPath).toString() || '[]'
  let data = JSON.parse(json)
  return data
}

function save (images) {
  let json = JSON.stringify(images)
  fs.writeFileSync(dbPath, json)
}

function getSingle (id) {
  return getAll().filter(i => i.id === id)[0]
}

module.exports.data = {}

module.exports.data.getAll = getAll

module.exports.data.getById = getSingle

module.exports.data.add = (image) => {
  let images = getAll()
  images.id = images.length + 1
  images.push(image)
  save(images)
}
