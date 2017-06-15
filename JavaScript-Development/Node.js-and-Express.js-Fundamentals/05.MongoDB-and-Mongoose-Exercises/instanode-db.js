let Image = require('./models/Image')
let Tag = require('./models/Tag')

function updateTag (tagData) {
  return new Promise((resolve, reject) => {
    Tag.findOne({ name: tagData.name }).then((tag) => {
      tag.images.push(tagData.imageId)
      tag.save()
        .then(() => resolve(`Updated tag ${tag.name} with image: ${tagData.imageId}`))
    })
  })
}

function createTag (tagName) {
  return new Promise((resolve, reject) => {
    Tag.findOne({ name: tagName }).then((existingTag) => {
      if (existingTag) {
        resolve(existingTag._id)
        return
      }

      Tag.create({ name: tagName }).then((tag) => {
        resolve(tag._id)
      })
    })
  })
}

module.exports = {
  saveImage: (imageData) => {
    let tags = imageData.tags

    let imageObj = {
      url: imageData.url,
      description: imageData.description,
      tags: []
    }

    let createTagPromises = []
    for (let tagName of tags) {
      createTagPromises.push(
        createTag(tagName).then((tagId) => {
          imageObj.tags.push(tagId)

          console.log(`Populated image with tag: ${tagName}`)
        }))
    }

    Promise.all(createTagPromises).then(() => {
      Image.create(imageObj).then((image) => {
        console.log(`Created  image: ${image._id}`)
        for (let tagName of tags) {
          updateTag({
            name: tagName,
            imageId: image._id
          }).then((msg) => {
            console.log(msg)
          })
        }
      })
    })
  },

  findByTag: (tagName) => {
    return new Promise((resolve, reject) => {
      Tag.findOne({ name: tagName }).then((tag) => {
        Image.find({ tags: tag._id }).then((images) => {
          let sortedImages = images.sort((a, b) => b.creationDate > a.creationDate)
          resolve(sortedImages)
        })
      })
    })
  },

  filter: (minDate, maxDate, results) => {
    if (!results) {
      results = 10
    }
    if (!minDate) {
      minDate = new Date(-8640000000000000).toISOString()
    }
    if (!maxDate) {
      maxDate = Date.now().toISOString()
    }

    return new Promise((resolve, reject) => {
      Image.find({
        creationData: {
          $gte: minDate.toISOString,
          $lt: maxDate.toISOString
        }
      })
        .limit(results)
        .then((images) => {
          resolve(images)
        })
    })
  }
}
