import React from 'react'

class Form extends React.Component {

  handleSubmit (event) {
    event.preventDefault()
    this.props.onsubmit();
  }

  render () {
    return (
      <form onSubmit={this.handleSubmit.bind(this)}>
        <input type="text"/>
        <input type="submit" value="Submit"/>
      </form>
    )
  }
}

export default Form;