import { useEffect, useState } from "react"
import Layout from "../../Components/Layout"
import Card from "../../Components/Card"
import ProductDetail from '../../Components/ProductDetail'


function Home(){
    const [items, setItems] = useState(null)

    useEffect(()=>{
        fetch('https://api.escuelajs.co/api/v1/products')
            .then(response => response.json())
            .then(data => setItems(data))
    }, [])

    return(
        <Layout>
            Home
            <div className='grid gap-4 grid-cols-4 w-full max-w-screen-lg'>
                {
                items?.map(item=>(
                    <Card key={item.id} data={item}/>
                ))
                }
            </div>  
            <ProductDetail />                  
        </Layout>
    )

    // useEffect(() => {
    //     fetch('https://localhost:7190/graphql', {
    //     method: 'POST',
    //     header: { 'Content-Type': 'application/json'},
    //     body: JSON.stringify({ query: `
    //         query ProductQuery {
    //         products {
    //             productCode
    //             productName
    //             productDescription
    //             price
    //             stock
    //         }
    //         }     
    //     `})
    //     })
    //     .then(res => res.json())
    //     .then(res => setItems(data))
    // }, [])

    
}

export default Home