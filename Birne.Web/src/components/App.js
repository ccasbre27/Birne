import React, { Component } from 'react';
import faker from 'faker';
import Login from './Login';
import ProductList from './ProductsList';

class App extends Component {

    state = { isLogged: false };

    onLogin = () => {
       this.setState({ isLogged: true });
    }

    createProduct = () => {
        return {
            id: faker.random.uuid(), 
            description: faker.commerce.productAdjective(),
            name: faker.commerce.productName(),
            image: faker.image.food()
        }
    }
      
    createProducts = (numProducts = 5) => {
        return new Array(numProducts)
            .fill(undefined)
            .map(this.createProduct);
    }
      
    renderContent() {

        if(!this.state.isLogged) {
            return <Login onLogin={ this.onLogin } />
        } else {
            return <ProductList products={ this.createProducts(10) }/>;
        }
    
    }

    render() {
        return (
            <div className="border-red">
                { this.renderContent() }
            </div>
        );
    }
}

export default App;