import React, { Component } from 'react';
import './Login.css';
import {Container, Row, Col, Image, Form, Button } from 'react-bootstrap';

class Login extends Component {

    onFormSubmit(event) {
        event.preventDefault();
        this.props.onLogin();
    }

    render() {
        return (
            <Container fluid className="Login text-center">
                <Form onSubmit={ (event) => this.onFormSubmit(event) }>
                    <Row className="justify-content-md-center">
                        <Col >
                            <Image src="/images/sin_intermediarios.PNG" />
                        </Col>
                    </Row>
                    <Row className="justify-content-md-center">
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
                    </Row>
                    <Row className="justify-content-md-center">
                        <Col lg={5}>
                            <Button className="LoginButton form-control" type="submit">
                                    Submit
                            </Button>
                        </Col>
                    </Row>
                    <Row className="justify-content-md-center">
                        <Col lg={5}>
                            <h4>Necesita una cuenta? <a href="#"> Registrarse </a></h4>
                        </Col>
                    </Row>
                    <Row className="mt-5 justify-content-md-center">
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
                    </Row>
                </Form>
            </Container>
        );
    }

}

export default Login;
