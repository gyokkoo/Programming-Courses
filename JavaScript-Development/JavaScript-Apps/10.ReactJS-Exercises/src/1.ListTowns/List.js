import React from 'react';

class List extends React.Component {
  render () {
    if (!this.props.towns[0]) {
      return false;
    }

    console.log(this.props.towns);

    let towns = this.props.towns.map(function (town, i) {
      return <li key={i}>{town}</li>
    });

    return <ul>{towns}</ul>;
  }
}

export default List;