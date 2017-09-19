import React from 'react'
import { Switch, Route } from 'react-router-dom'
import PrivateRoute from './PrivateRoute'
import LoginPage from '../../users/LoginPage'
import RegisterPage from '../../users/RegisterPage'
import LogoutPage from '../../users/LogoutPage'
import CreateHotelPage from '../../hotels/CreateHotelPage'
import ListHotelsPage from '../../hotels/ListHotelsPage'
import HotelDetailsPage from '../../hotels/HotelDetailsPage'

const Routes = () => (
  <Switch>
    <Route path='/' exact component={ListHotelsPage} />
    <Route path='/users/login' component={LoginPage} />
    <Route path='/users/register' component={RegisterPage} />
    <PrivateRoute path='/users/logout' component={LogoutPage} />
    <PrivateRoute path='/hotels/create' component={CreateHotelPage} />
    <PrivateRoute path='/hotels/details/:id' component={HotelDetailsPage} />
  </Switch>
)

export default Routes
