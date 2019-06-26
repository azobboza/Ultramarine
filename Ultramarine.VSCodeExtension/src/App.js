import React from 'react'
import { hot } from 'react-hot-loader'
import './App.css'
import Composer from './vivaldi'
import Tree from './vivaldi/components/graphs/Tree'

const App = () => (
  <div>
    <Tree />
  </div>
)

export default hot(module)(App)
