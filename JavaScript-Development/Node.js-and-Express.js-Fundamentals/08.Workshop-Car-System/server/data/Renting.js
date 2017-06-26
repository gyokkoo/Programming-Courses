const mongoose = require('mongoose')
const ObjectId = mongoose.Schema.Types.ObjectId

let rentingSchema = mongoose.Schema({
  user: { type: ObjectId, required: true, ref: 'User' },
  car: { type: ObjectId, required: true, ref: 'Car' },
  days: { type: Number, required: true },
  totalPrice: { type: Number, required: true },
  rentedOn: { type: Date, default: Date.now() }
})

let Renting = mongoose.model('Renting', rentingSchema)

module.exports = Renting
