import React, { Component } from 'react';
import faker from 'faker';

import Product from './Product';

import { Row } from 'react-bootstrap';

const ProductList = ({ products }) => {

    const allProducts = products.map(({ id, name, description, image }) => {
        return <Product key={ id } 
                    name={ name } 
                    description={ description } 
                    image={ image } />
    });

    return(
        
            <Row>
                { allProducts }
            </Row>
    );

}

export default ProductList;