import { NavLink } from 'react-router-dom'
import { useContext } from 'react'
import { ShoppingCartIcon } from '@heroicons/react/24/solid'
import { ShoppingCartContext } from '../../Context'

const Navbar = () => {
    const context = useContext(ShoppingCartContext)
    const activeStile = 'underline underline-offset-4'

    return (
        <nav className="flex justify-between items-center fixed z-10 top-0 w-full py-5 px-8 text-sm font-light">
            <ul className="flex items-center gap-3">
                <li className="font-semibold text-lg">
                    <NavLink to='/'>
                        The Shop
                    </NavLink>
                </li>
                <li>
                    <NavLink 
                        to='/'
                        className={({isActive})=>
                        isActive ? activeStile : undefined
                        }>
                        All
                    </NavLink>
                </li>
            </ul>
            <ul className="flex items-center gap-3">
                <li>
                    <NavLink to='/Orders'
                        className={({isActive})=>
                        isActive ? activeStile : undefined
                        }>
                        Orders
                    </NavLink>
                </li>
                <li>
                    <NavLink to='/Products'
                        className={({isActive})=>
                        isActive ? activeStile : undefined
                        }>
                        Products
                    </NavLink>
                </li>
                <li className='flex item-center'>
                <ShoppingCartIcon className='h-6 w-6 text-black'></ShoppingCartIcon>  
                <div>{context.count}</div>
                </li>
            </ul>
        </nav>
    )
}

export default Navbar