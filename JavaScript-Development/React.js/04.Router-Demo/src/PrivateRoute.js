import React from 'react'
import { Route, Redirect } from 'react-router-dom'

let auth = false

const PrivateRoute = ({component: Component, ...rest}) => (
  <Route {...rest} render={props => (
      auth ? (
        <Component {...props} />
      ) : (
        <Redirect to={{
          pathname: '/login',
          state: { from: props.location }
        }} />
      )
    )
  } />
)

export default PrivateRoute
