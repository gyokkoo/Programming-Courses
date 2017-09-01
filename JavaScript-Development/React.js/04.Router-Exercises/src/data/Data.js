import delay from './delay'

const books = [
  {
    id: 'ilsrwj85s',
    title: 'The Book Thief',
    description: 'A story about, among other things: A girl, some words, an accordionist, some fanatical Germans, a Jewish fist-fighter, and quite a lot of thievery. . . .an unforgettable story about the ability of books to feed the soul. Winner of the 2007 BookBrowse Ruby Award.',
    price: 15.99,
    authorId: '0bz5xg358',
    image: 'https://upload.wikimedia.org/wikipedia/en/8/8f/The_Book_Thief_by_Markus_Zusak_book_cover.jpg',
    addedDate: new Date('2012, 5, 12'),
    comments: [
      {
        user: 'Ivan',
        comment: 'Good Book'
      },
      {
        user: 'Pesho',
        comment: 'The best one'
      }
    ]
  },
  {
    id: '5a2hbbvgo',
    title: 'The Alchemyst',
    description: 'The Alchemist is a novel by Brazilian author Paulo Coelho which was first published in 1988.',
    price: 25.34,
    authorId: 'ob75jdote',
    image: 'https://upload.wikimedia.org/wikipedia/en/c/c4/TheAlchemist.jpg',
    addedDate: new Date('1988, 3, 10'),
    comments: [
      {
        user: 'Dinko',
        comment: 'Zaduvashavam sa'
      }
    ]
  },
  {
    id: 'r1iqjef6l',
    title: 'The Zahir',
    description: 'The Zahir is a 2005 novel by the Brazilian writer Paulo Coelho. Just as in an earlier book, The Alchemist, The Zahir is about a pilgrimage. The book touches on themes of love, loss and obsession.',
    price: 34,
    authorId: '0bz5xg358',
    image: 'https://upload.wikimedia.org/wikipedia/en/a/ac/The_Zahir_%28novel%29.jpg',
    addedDate: new Date('2013, 3, 10'),
    comments: [{
      user: 'Chitatel_98',
      comment: 'Fascinating book!'
    }]
  },
  {
    id: '7fuzwzqe7',
    title: 'The Messenger',
    description: 'he Messenger was released in the United States under the name I Am the Messenger. The entire story is written through the eyes of the main character, Ed Kennedy, who describes and comments on the story throughout the book.',
    price: 25,
    authorId: 'ob75jdote',
    image: 'https://upload.wikimedia.org/wikipedia/en/5/54/The_Messenger_Au_Cover.jpg',
    addedDate: new Date('2002, 4, 4'),
    comments: [{
      user: 'random_user',
      comment: 'random comment 123 <br />'
    }]
  }
]

const authors = [
  {
    id: '0bz5xg358',
    name: 'Markus Zusak',
    description: 'Good Author',
    image: 'https://upload.wikimedia.org/wikipedia/commons/8/8c/Markus_Zusak_at_the_Book_Thief_Interview_%28cropped%29.jpg'
  },
  {
    id: 'ob75jdote',
    name: 'Paulo Coelho',
    description: 'Paulo Coelho is a Brazilian lyricist and novelist and the recipient of numerous international awards. ',
    image: 'https://upload.wikimedia.org/wikipedia/commons/0/0b/Paulo_Coelho_nrkbeta.jpg'
  }

]

// const generateId = () => {
//   // Math.random should be unique because of its seeding algorithm.
//   // Convert it to base 36 (numbers + letters), and grab the first 9 characters
//   // after the decimal.
//   return Math.random().toString(36).substr(2, 9)
// }

class Data {
  static getAllBooks () {
    return new Promise((resolve, reject) => {
      if (books) {
        setTimeout(() => {
          resolve(Object.assign([], books))
        }, delay)
      } else {
        reject(new Error('No books available!'))
      }
    })
  }

  static getBookById (id) {
    return new Promise((resolve, reject) => {
      let index = books.findIndex(book => book.id === id)
      if (index !== -1) {
        setTimeout(() => {
          resolve(Object.assign([], books[index]))
        }, delay)
      } else {
        reject(new Error('The book does not exists'))
      }
    })
  }

  static getAllAuthors () {
    return new Promise((resolve, reject) => {
      if (authors) {
        setTimeout(() => {
          resolve(authors)
        }, delay)
      } else {
        reject(new Error('No authors available!'))
      }
    })
  }

  static getAuthorById (id) {
    return new Promise((resolve, reject) => {
      let index = authors.findIndex(author => author.id === id)
      if (index !== -1) {
        setTimeout(() => {
          resolve(Object.assign([], authors[index]))
        }, delay)
      } else {
        reject(new Error('The author does not exists'))
      }
    })
  }

  static deleteAuthor (id) {
    let authorIndex = authors.findIndex(author => author.id === id)
    authors.splice(authorIndex, 1)
  }
}

export default Data
