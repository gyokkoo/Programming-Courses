import React from 'react'
import { Link } from 'react-router-dom'

const HotelListing = (props) => (
  <li className='hotel-listing'>
    <img src={props.image} alt={props.name + ' hotel'} />
    <div>{props.name}</div>
    <br />
    <Link to={`/hotels/details/${props.id}`}>More Details</Link>
    <hr />
  </li>
)

export default HotelListing
