import React, { Component } from 'react'
import Input from './common/Input'

class AuthorForm extends Component {
  render () {
    return (
      <form>
        <Input
          name='firstName'
          placeholder='First Name'
          value={this.props.author.firstName}
          error={this.props.errors.firstName}
          onChange={this.props.onChange} />
        <br />
        <Input
          name='lastName'
          placeholder='Last Name'
          value={this.props.author.lastName}
          error={this.props.errors.lastName}
          onChange={this.props.onChange} />
        <br />
        <input type='submit' value='Add Author' onClick={this.props.onSave} />
      </form>
    )
  }
}

export default AuthorForm
