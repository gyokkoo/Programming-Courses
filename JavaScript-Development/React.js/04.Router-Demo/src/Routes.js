import { Route, Switch, Redirect } from 'react-router-dom'
import React from 'react'
import PrivateRoute from './PrivateRoute'
import HomePage from './components/HomePage'
import AboutPage from './components/AboutPage'
import NotFoundPage from './components/NotFoundPage'
import ParamPage from './components/ParamPage'

const Routes = () => (
  <Switch>
    <Route exact path='/' component={HomePage} />
    <Route path='/home' component={HomePage} />
    <Route path='/about' component={AboutPage} />
    <Route path='/page/with/:id' component={ParamPage} />
    <PrivateRoute path='/private' component={AboutPage} />
    <Route path='/contact' render={props => (
      <h2>Contact me, please.</h2>
    )} />
    <Route component={NotFoundPage} />
    <Redirect from='/about-us' to='/about' />
  </Switch>
)

export default Routes
