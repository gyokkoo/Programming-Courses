import React from 'react';
import HeaderRow from './HeaderRow';
import Drawer from './Drawer';
import $ from 'jquery';

class TitleBar extends React.Component {

  onclick () {
    $('.drawer').toggle();
  }

  render () {
    return (
      <header className="header-row">
        <HeaderRow onclick={this.onclick.bind(this)} title={this.props.title}/>
        <Drawer links={this.props.links}/>
      </header>
    );
  }
}

export default TitleBar;