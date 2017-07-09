import React from 'react'

export default function HomeView (props) {
  return <div className='home-view'>
    <h1>Welcome to Home</h1>
    <p> Welcome to my book library</p>
    {
      props.username ? <p>Welcome, {props.username}.</p> : <p>No user logged in.</p>
    }
  </div>
}
