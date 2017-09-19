import dispatcher from '../dispatcher'

const hotelActions = {
  types: {
    CREATE_HOTEL: 'CREATE_HOTEL',
    ALL_HOTELS: 'ALL_HOTELS',
    HOTEL_DETAILS: 'HOTEL_DETAILS',
    ADD_REVIEW: 'ADD_REVIEW',
    ALL_REVIEWS: 'ALL_REVIEWS'
  },
  createHotel (hotel) {
    dispatcher.dispatch({
      type: this.types.CREATE_HOTEL,
      hotel
    })
  },
  all (page) {
    page = page || 1
    dispatcher.dispatch({
      type: this.types.ALL_HOTELS,
      page
    })
  },
  byId (id) {
    dispatcher.dispatch({
      type: this.types.HOTEL_DETAILS,
      id
    })
  },
  addReview (id, review) {
    dispatcher.dispatch({
      type: this.types.ADD_REVIEW,
      id,
      review
    })
  },
  allReviews (id) {
    dispatcher.dispatch({
      type: this.types.ALL_REVIEWS,
      id
    })
  }
}

export default hotelActions
