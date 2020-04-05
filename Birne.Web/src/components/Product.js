import './Product.css';
import React from 'react';
import { Card, Col } from 'react-bootstrap';

const Product = ({ name, description, image }) => {

    return(
        <Col md={3} className="product-card">
            <Card >
            <Card.Img variant="top" src={ image } />
            <Card.Body>
                <Card.Title>{ name }</Card.Title>
                <Card.Text>
                    { description }
                </Card.Text>
            </Card.Body>
            </Card>
        </Col>
    );
}

export default Product;