import dispatcher from '../dispatcher'

let todoActions = {
  createTodo: (title) => {
    dispatcher.dispatch({
      type: 'CREATE_TODO',
      title
    })
  }
}

export default todoActions
