import { EventEmitter } from 'events'
import dispatcher from '../dispatcher'
import HotelActions from '../actions/HotelActions'
import HotelData from '../data/HotelData'

class HotelStore extends EventEmitter {
  createHotel (hotel) {
    HotelData
      .create(hotel)
      .then(data => this.emit(this.eventTypes.HOTEL_CREATED, data))
  }

  allHotels (page) {
    page = page || 1
    HotelData.all(page)
      .then(data => this.emit(this.eventTypes.HOTELS_RETRIEVED, data))
  }

  byId (id) {
    HotelData
      .byId(id)
      .then(data => this.emit(this.eventTypes.HOTEL_DETAILS_RETRIEVED, data))
  }

  addReview (id, review) {
    HotelData
      .addReview(id, review)
      .then(data => this.emit(this.eventTypes.REVIEW_ADDED, data))
  }

  allReviews (id) {
    HotelData
      .allReviews(id)
      .then(data => this.emit(this.eventTypes.REVIEWS_RETRIEVED, data))
  }

  handleAction (action) {
    switch (action.type) {
      case HotelActions.types.CREATE_HOTEL: {
        this.createHotel(action.hotel)
        break
      }
      case HotelActions.types.ALL_HOTELS: {
        this.allHotels(action.page)
        break
      }
      case HotelActions.types.HOTEL_DETAILS: {
        this.byId(action.id)
        break
      }
      case HotelActions.types.ADD_REVIEW: {
        this.addReview(action.id, action.review)
        break
      }
      case HotelActions.types.ALL_REVIEWS: {
        this.allReviews(action.id)
        break
      }
      default:
        break
    }
  }
}

let hotelStore = new HotelStore()

hotelStore.eventTypes = {
  HOTEL_CREATED: 'hotel_created',
  HOTELS_RETRIEVED: 'hotels_retrieved',
  HOTEL_DETAILS_RETRIEVED: 'hotel_details_retrieved',
  REVIEW_ADDED: 'review_added',
  REVIEWS_RETRIEVED: 'reviews_retrieved'
}

dispatcher.register(hotelStore.handleAction.bind(hotelStore))
export default hotelStore
