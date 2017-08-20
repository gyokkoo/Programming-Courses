import React from 'react';

class HeaderRow extends React.Component {

  handleClick (event) {
    event.preventDefault();
    this.props.onclick();
  }

  render () {
    return (
      <div className="header-row">
        <a className="button" onClick={this.handleClick.bind(this)}>&#9776;</a>
        <span className="title">{this.props.title}</span>
      </div>
    )
  }
}

export default HeaderRow;