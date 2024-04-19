import { ApolloClient, InMemoryCache, ApolloProvider, gql } from '@apollo/client';
import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './Pages/App/index.jsx'
import Products from './Pages/Products/index.jsx';
import './index.css'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <App />   
  </React.StrictMode>,
)

// const client = new ApolloClient({
//   uri: 'https://localhost:7190/graphql',
//   cache: new InMemoryCache(),
// });

// ReactDOM.render(
//   <ApolloProvider client={client}>
//     <App />   
//   </ApolloProvider>,
//   document.getElementById('root')
// )


// // Supported in React 18+
// const root = ReactDOM.createRoot(document.getElementById('root'));

// root.render(
//   <ApolloProvider client={client}>
//     <App />   
//   </ApolloProvider>,
// );
