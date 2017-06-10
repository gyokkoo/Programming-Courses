let data = []

module.exports = {
  save: (image) => {
    data.push(image)
  },
  getAll: () => {
    return data.slice(0)
  }
}
