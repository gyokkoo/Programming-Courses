import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import TitleBar from './2.TitleBar/TitleBar';

ReactDOM.render(<App />, document.getElementById('root'));
let links = [
  ['/', 'Home'],
  ['about', 'About'],
  ['results', 'Results'],
  ['faq', 'FAQ']];

ReactDOM.render(
  <TitleBar title="Title Bar Problem" links={links} />,
  document.getElementById('head')
);
