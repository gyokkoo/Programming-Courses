import React from 'react'

const Todo = (props) => (
  <li>
    {props.title} - {props.completed ? 'DONE' : 'PENDING'}
  </li>
)

export default Todo
