import React, { Component } from 'react'
import AuthorForm from './AuthorForm'
import toastr from 'toastr'

class CreateAuthorPage extends Component {
  constructor (props) {
    super(props)

    this.state = {
      author: {
        firstName: '',
        lastName: ''
      },
      errors: {
        firstName: '',
        lastName: ''
      }
    }
  }

  handleInputChange (event) {
    const target = event.target
    const name = target.name
    const value = target.value
    let author = this.state.author
    author[name] = value

    this.setState({
      author
    })
  }

  saveAuthor (event) {
    event.preventDefault()
    if (!this.validateAuthor()) {
      return
    }
    console.log(this.state.author)
    toastr.success('Author added!')
  }

  validateAuthor () {
    let author = this.state.author
    let errors = {}
    let formIsValid = true
    if (!author.firstName || author.firstName.length < 3) {
      errors.firstName = 'Minimum 3 symbols'
      formIsValid = false
    }

    if (!author.lastName || author.lastName.length < 3) {
      errors.lastName = 'Minimum 3 symbols'
      formIsValid = false
    }

    this.setState({errors})

    return formIsValid
  }

  render () {
    return (
      <div>
        <h1>Create Author</h1>
        <AuthorForm
          author={this.state.author}
          errors={this.state.errors}
          onChange={this.handleInputChange.bind(this)}
          onSave={this.saveAuthor.bind(this)} />
      </div>
    )
  }
}

export default CreateAuthorPage
