import dispatcher from '../dispatcher'

let todoActions = {
  createTodo: (title) => {
    dispatcher.dispatch({
      type: 'CREATE_TODO',
      title
    })
  },

  completeTodo: (id) => {
    dispatcher.dispatch({
      type: 'COMPLETE_TODO',
      id
    })
  }
}

export default todoActions
