import React from 'react'
import Input from '../common/forms/Input'

const RegisterFrom = (props) => (
  <form>
    <div>{props.error}</div>
    <Input
      name='email'
      type='email'
      placeholder='E-mail'
      value={props.user.email}
      onChange={props.onChange} />
    <br />
    <label htmlFor='password'>Password</label>
    <input
      type='password'
      name='password'
      placeholder='Password'
      value={props.user.password}
      onChange={props.onChange} />
    <br />
    <label htmlFor='confirmPassword'>Confirm Password</label>
    <input
      type='password'
      name='confirmPassword'
      placeholder='Confirm Password'
      value={props.user.confirmPassword}
      onChange={props.onChange} />
    <br />
    <label htmlFor='name'>Name</label>
    <input
      type='name'
      name='name'
      placeholder='Name'
      value={props.user.name}
      onChange={props.onChange} />
    <br />
    <input type='submit' onClick={props.onSave} />
  </form>
)

export default RegisterFrom
