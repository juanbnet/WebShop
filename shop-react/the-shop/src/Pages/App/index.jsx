import { gql, useQuery } from '@apollo/client'
import { useRoutes, BrowserRouter } from 'react-router-dom'
import Home from '../Home'
import Orders from '../Orders'
import Products from '../Products'
import NotFound from '../NotFound'
import Navbar from '../../Components/Navbar'
import { ShoppingCartProvider } from '../../Context'
import CheckoutSideMenu from '../../Components/CheckoutSideMenu'
import './App.css'

// const GET_PRODUCTS = gql`
//   query ProductQuery {
//     products {
//       productCode
//       productName
//       productDescription
//       price
//       stock
//     }
//   }
//   `;

const AppRoutes = () => {
  let routes = useRoutes([
    { path: '/', element: <Home /> },
    { path: '/Orders', element: <Orders /> },
    { path: '/Products', element: <Products /> },
    { path: '/*', element: <NotFound /> }
  ])
  return routes
}

const App = () => { 
  return(
    <ShoppingCartProvider>
      <BrowserRouter>
        <AppRoutes/>
        <Navbar /> 
        <CheckoutSideMenu />
      </BrowserRouter> 
    </ShoppingCartProvider>   
  )
}

// function DisplayProducts() {
//   const { loading, error, data } = useQuery(GET_PRODUCTS);

//   if (loading) return <p>Loading...</p>;
//   if (error) return <p>Error : {error.message}</p>;

//   return data.products.map(({productCode, productName, productDescription, price, stock }) => (
//     <div key={productCode}>
//       <h3>{productName}</h3>
//       {<img width="400" height="250" alt="location-reference" src={`${photo}`} />}
//       <br />
//       <b>Details:</b>
//       <p>{productDescription}</p>
//       <p>{price}</p>
//       <p>{stock}</p>
//       <br />
//     </div>
//   ));
// }

export default App