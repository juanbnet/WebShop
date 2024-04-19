import { ApolloClient, InMemoryCache, ApolloProvider, gql } from '@apollo/client';
import ReactDOM from 'react-dom/client'
import React, { useEffect } from 'react'
import Layout from "../../Components/Layout"
import App from '../App';



function Products(){
  // useEffect(() => {
  //   fetch('https://localhost:7190/graphql', {
  //     method: 'POST',
  //     header: { 'Content-Type': 'application/json'},
  //     body: JSON.stringify({ query: `
  //       query ProductQuery {
  //         products {
  //           productCode
  //           productName
  //           productDescription
  //           price
  //           stock
  //         }
  //       }     
  //     `})
  //   })
  //   .then(res => res.json())
  //   .then(res => {
  //     console.log(res.data)
  //   })
  // })

  return(        
    <Layout>
        Hi from Products            
    </Layout>
  )
}


// export default function Products() {
//   return (
//     <div>
//         <h2>The Shop 🚀</h2>
//         <br />
//         <DisplayProducts />
//     </div>
//   );
// }

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

export default Products
