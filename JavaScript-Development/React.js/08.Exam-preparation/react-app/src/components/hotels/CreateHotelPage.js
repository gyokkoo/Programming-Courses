import React, { Component } from 'react'
import CreateHotelForm from './CreateHotelForm'
import FormHelpers from '../common/forms/FormHelpers'
import toastr from 'toastr'

import HotelActions from '../../actions/HotelActions'
import HotelStore from '../../stores/HotelStore'

class CreateHotelPage extends Component {
  constructor (props) {
    super(props)

    this.state = {
      hotel: {
        name: 'My hotel',
        location: 'Sofia',
        description: 'Good hotel',
        numberOfRooms: 5,
        image: 'http://www.granducaaustin.com/wp-content/uploads/revslider/hero-granduca-houston/Granduca_Frnt-1120x750.jpg',
        parkingSlots: 15
      },
      error: ''
    }

    this.handleHotelChange = this.handleHotelChange.bind(this)
    this.handleHotelCreated = this.handleHotelCreated.bind(this)
    this.handleHotelSave = this.handleHotelSave.bind(this)

    HotelStore.on(
      HotelStore.eventTypes.HOTEL_CREATED,
      this.handleHotelCreated
    )
  }

  componentWillUnmount () {
    HotelStore.removeListener(
      HotelStore.eventTypes.HOTEL_CREATED,
      this.handleHotelCreated
    )
  }

  handleHotelCreated (data) {
    if (!data.success) {
      let error = FormHelpers.getFirstError(data)
      this.setState({ error })
    } else {
      const id = data.hotel.id
      toastr.success(data.message)
      this.props.history.push(`/hotels/details/${id}`)
    }
  }

  handleHotelChange (event) {
    FormHelpers.handleFormChange.bind(this)(event, 'hotel')
  }

  handleHotelSave (event) {
    event.preventDefault()

    // validate form
    let formIsValid = true
    let error = ''
    if (!this.state.hotel.name) {
      error = 'Name is required'
      formIsValid = false
    }

    if (!formIsValid) {
      this.setState({ error })
      return
    }
    HotelActions.createHotel(this.state.hotel)
  }

  render () {
    return (
      <div>
        <h1>Create hotel</h1>
        <CreateHotelForm
          hotel={this.state.hotel}
          error={this.state.error}
          onChange={this.handleHotelChange}
          onSave={this.handleHotelSave} />
      </div>
    )
  }
}

export default CreateHotelPage
