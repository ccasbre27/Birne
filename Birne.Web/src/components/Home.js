import React from 'react';
import {Container } from 'react-bootstrap';

import Menu from './Menu';
import ProductList from './ProductsList';

const Home = ({ products }) => {
    return (
        <Container>
            <Menu />
            
            <ProductList products={ products } className="mt-5" />
        
        </Container>
    );
}

export default Home;