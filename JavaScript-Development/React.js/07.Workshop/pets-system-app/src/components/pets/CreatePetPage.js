import React, { Component } from 'react'
import CreatePetForm from './CreatePetForm'
import FormHelpers from '../common/forms/FormHelpers'
import petActions from '../../actions/PetActions'
import petStore from '../../stores/PetStore'
import toastr from 'toastr'

class CreatePetPage extends Component {
  constructor (props) {
    super(props)

    this.state = {
      pet: {
        name: 'Tom',
        age: 2,
        type: 'Cat',
        image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDDr75_4VX7ask0l7__gU1_BicLRHASGb1H8D9zBGXpafD1NhrNg',
        breed: 'Street'
      },
      error: ''
    }

    this.handlePetCreation = this.handlePetCreation.bind(this)

    petStore.on(
      petStore.eventTypes.PET_CREATED,
      this.handlePetCreation
    )
  }

  componenWillUnmount () {
    petStore.removeListener(
      petStore.eventTypes.PET_CREATED,
      this.handlePetCreation
    )
  }

  handlePetChange (event) {
    FormHelpers.handleFormChange.bind(this)(event, 'pet')
  }

  handlePetForm (event) {
    event.preventDefault()

    // TODO: validate

    petActions.createPet(this.state.pet)
  }

  handlePetCreation (data) {
    if (!data.success) {
      let firstError = FormHelpers.getFirstError(data)
      this.setState({
        error: firstError
      })
    } else {
      toastr.success(data.message)
      this.props.history.push(`/pets/details/${data.pet.id}`)
    }
  }

  render () {
    return (
      <div>
        <h1>Add your pet</h1>
        <CreatePetForm
          pet={this.state.pet}
          error={this.state.error}
          onChange={this.handlePetChange.bind(this)}
          onSave={this.handlePetForm.bind(this)} />
      </div>
    )
  }
}

export default CreatePetPage
