import React, { Component } from 'react'
import HotelActions from '../../actions/HotelActions'
import HotelStore from '../../stores/HotelStore'
import HotelReviews from './reviews/HotelReviews'

class HotelDetailsPage extends Component {
  constructor (props) {
    super(props)
    const id = this.props.match.params.id
    this.state = {
      id,
      hotel: {}
    }

    this.handleHotelRetrieved = this.handleHotelRetrieved.bind(this)
    HotelStore.on(
      HotelStore.eventTypes.HOTEL_DETAILS_RETRIEVED,
      this.handleHotelRetrieved)
  }

  componentDidMount () {
    HotelActions.byId(this.state.id)
  }

  componentWillUnmount () {
    HotelStore.removeListener(
      HotelStore.eventTypes.HOTEL_DETAILS_RETRIEVED,
      this.handleHotelRetrieved)
  }

  handleHotelRetrieved (hotel) {
    this.setState({
      hotel
    })
  }

  render () {
    const hotel = this.state.hotel
    return (
      <div>
        <h1>{hotel.name} - {hotel.location}</h1>
        <h3>{hotel.numberOfRooms} rooms ({hotel.parkingSlots} parking slots)</h3>
        <div className='image-details'>
          <img src={hotel.image} alt={hotel.description} />
        </div>
        <div>
          <HotelReviews hotelId={this.state.id} />
        </div>
      </div>
    )
  }
}

export default HotelDetailsPage
