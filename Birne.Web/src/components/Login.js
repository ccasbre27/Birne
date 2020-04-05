import React from 'react';
import { Link } from 'react-router';
import './Login.css';
import {Container, Row, Col, Image, Form, Button } from 'react-bootstrap';

const Login = () => {

    return (
        <Container fluid className="Login text-center">
            <Form>
                <Row>
                    <Col >
                        <Image src="/images/sin_intermediarios.PNG" />
                    </Col>
                </Row>
                <Row >
                <Col />
                <Col lg={5}>
                        <Form.Group controlId="formBasicEmail">
                            <Form.Label>Email address</Form.Label>
                            <Form.Control type="email" placeholder="Enter email" />
                        </Form.Group>
                        <Form.Group controlId="formBasicPassword">
                            <Form.Label>Password</Form.Label>
                            <Form.Control type="password" placeholder="Password" />
                        </Form.Group>
                </Col>
                <Col />
                </Row>
                <Row>
                    <Col />
                    <Col lg={5}>
                        <button className="LoginButton form-control" type="submit">
                                Submit
                        </button>
                    </Col>
                    <Col />
                </Row>
                <Row>
                    <Col />
                    <Col lg={5}>
                        <h4>Necesita una cuenta? <a href="#"> Registrarse </a></h4>
                    </Col>
                    <Col />
                </Row>
                <Row className="mt-5">
                    <Col />
                    <Col lg={2}>
                        <div className="FacebookButton form-control">
                            <Image src="/images/facebook.png" className="mt-1"/>
                        </div>
                    </Col>
                    <Col lg={1} />
                    <Col lg={2}>
                        <div className="GoogleButton form-control">
                            <Image src="/images/google.png" className="mt-1" />
                        </div>
                    </Col>
                    <Col />
                </Row>
            </Form>
        </Container>
    );

}

export default Login;
