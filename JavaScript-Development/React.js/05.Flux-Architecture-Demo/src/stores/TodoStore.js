import { EventEmitter } from 'events'
import distpatcher from '../dispatcher'

class TodoStore extends EventEmitter {
  constructor () {
    super()

    this.todos = [
      { id: 1, title: 'Buy foods', completed: false },
      { id: 2, title: 'Go workout', completed: false }
    ]
  }

  getAll () {
    return new Promise((resolve, reject) => {
      resolve(this.todos.slice(0))
    })
  }

  createTodo (title) {
    const id = this.todos.length + 1
    this.todos.push({
      id,
      title,
      completed: false
    })

    this.emit('change')
  }

  handleAction (action) {
    switch (action.type) {
      case 'CREATE_TODO': {
        this.createTodo(action.title)
        break
      }
      default: {
        throw new Error('Invalid action type')
      }
    }
  }
}

let todoStore = new TodoStore()

distpatcher.register(todoStore.handleAction.bind(todoStore))

export default todoStore
