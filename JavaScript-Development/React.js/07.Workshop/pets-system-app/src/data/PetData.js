import Data from './Data'

const baseUrl = 'pets'

class PetData {
  static create (pet) {
    return Data.post(`${baseUrl}/create`, pet, true)
  }

  static all (page) {
    page = page || 1
    return Data.get(`${baseUrl}/all?page=${page}`)
  }
}

export default PetData
