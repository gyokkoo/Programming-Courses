import React from 'react';
import Form from './Form';
import List from './List'
import $ from 'jquery';

class ListTowns extends React.Component {

  state = {
    towns: ''
  }

  updateTowns () {
    let townsString = $('form').children()[0].value.split(', ');

    this.setState({
      towns: townsString
    })
  }

  render () {
    return (
      <div>
        <Form onsubmit={this.updateTowns.bind(this)} />
        <List towns={this.state.towns} />
      </div>
    )
  }
}

export default ListTowns;
