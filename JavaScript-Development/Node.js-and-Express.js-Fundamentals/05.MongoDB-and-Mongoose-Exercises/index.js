let database = require('./database')
let instanodeDb = require('./instanode-db')

database().then(() => {
  instanodeDb.saveImage({
    url: 'https://i.ytimg.com/vi/tntOCGkgt98/maxresdefault.jpg',
    description: 'such cat much wow',
    tags: ['cat', 'kitty', 'cute', 'catstagram']
  })
  instanodeDb.saveImage({
    url: 'https://www.what-dog.net/Images/faces2/scroll0014.jpg',
    description: 'nice dog',
    tags: ['dog']
  })
  instanodeDb.saveImage({
    url: 'http://elijahfan.com/wp-content/uploads/strong-dog-names-images.jpg',
    description: 'strong dog',
    tags: ['dog']
  })

  // instanodeDb.findByTag('dog').then((images) => {
  //   images.forEach(i => console.log(i))
  // })
})
