import React from 'react'
import Input from '../common/forms/Input'

const CreatePetFrom = (props) => (
  <form>
    <div>{props.error}</div>
    <Input
      name='name'
      placeholder='Name'
      value={props.pet.name}
      onChange={props.onChange} />
    <br />
    <Input
      name='image'
      type='url'
      placeholder='Image'
      value={props.pet.image}
      onChange={props.onChange} />
    <br />
    <Input
      name='age'
      type='number'
      placeholder='Age'
      value={props.pet.age}
      onChange={props.onChange} />
    <br />
    <div>
      <label htmlFor='type'>Type</label>
      <select name='type' value={props.pet.type} onChange={props.onChange}>
        <option value='Cat'>Cat</option>
        <option value='Dog'>Dog</option>
        <option value='Other'>Other</option>
      </select>
    </div>
    <Input
      name='breed'
      placeholder='Breed'
      value={props.pet.breed}
      onChange={props.onChange} />
    <br />
    <input type='submit' onClick={props.onSave} />
  </form>
)

export default CreatePetFrom
