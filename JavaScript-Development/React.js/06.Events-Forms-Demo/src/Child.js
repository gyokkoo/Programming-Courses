import React, { Component } from 'react'

class App extends Component {
  render () {
    return (
      <div className='App'>
        <h1 onClick={this.props.headerClicked}>Click Me!</h1>
        <input type='text' name='textInput' onChange={this.props.inputChange} />
      </div>
    )
  }
}

export default App
