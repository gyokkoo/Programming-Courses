const mongoose = require('mongoose')

let productSchema = mongoose.Schema({
  name: { type: mongoose.Schema.Types.String, required: true },
  description: { type: mongoose.Schema.Types.String },
  price: {
    type: mongoose.Schema.Types.Number,
    min: 0,
    max: Number.MAX_VALUE,
    default: 0
  },
  image: { type: mongoose.Schema.Types.String },
  isBought: { type: mongoose.Schema.Types.Boolean, default: false },
  category: { type: mongoose.Schema.Types.ObjectId, ref: 'Category' }
})

let Product = mongoose.model('Product', productSchema)

module.exports = Product
