const storage = require('./storage')

storage.put('keyOne', 'Value123')
storage.put('Key2', false)
storage.put('third', 3)

let someValue = storage.get('third')
console.log(someValue)

storage.update('third', 'three')
let anotherValue = storage.get('third')
console.log(anotherValue)

storage.delete('keyOne')

storage.clear()

storage.put('keyOne', 'Value123')
storage.put('Key2', 'value2')
storage.put('third', '33')

storage
  .save()
  .then(() => {
    storage.clear()

    storage.load().then(() => {
      let afterLoadValue = storage.get('Key2')
      console.log(afterLoadValue)
    }).catch(err => console.log(err))
  })
  .catch(err => console.log(err))
