import React, { Component } from 'react'
import TodoList from './components/TodoList'
import './App.css'

class App extends Component {
  render () {
    return (
      <div className='App'>
        <h1>My To Do List</h1>
        <TodoList />
      </div>
    )
  }
}

export default App
