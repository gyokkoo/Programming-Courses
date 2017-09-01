import React from 'react'
import { Route, Switch } from 'react-router-dom'

import HomePage from './components/Home'

import BooksPage from './components/books/BooksPage'
import BookDetails from './components/books/BookDetails'

import AuthorsPage from './components/authors/AuthorsPage'
import AuthorDetails from './components/authors/AuthorDetails'

const Routes = () => (
  <Switch>
    <Route exact path='/' component={HomePage} />
    <Route path='/home' component={HomePage} />
    <Route path='/books/all' component={BooksPage} />
    <Route path='/books/:id' component={BookDetails} />
    <Route path='/authors/all' component={AuthorsPage} />
    <Route path='/authors/:id' component={AuthorDetails} />
  </Switch>
)

export default Routes
