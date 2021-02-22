import React, { Component } from 'react';
import { Options } from './Options';
import { Extras } from './Extras';

export default class App extends Component {
  queryString = undefined;

  constructor() {
    super();
    this.state = { };
  }

  componentDidMount() {
    this.getInventory();
  }

  // call to the web api to get the data set
  getInventory = () => {
    let uri = "http://localhost:3001/Car/SearchInventory";

    // if options have been selected then add the query string to the url
    if (this.queryString !== undefined) {
      uri += this.queryString;
    }

    // calls the api and assigns the returning json to the cars object stored in state
    fetch(uri)
      .then(response => response.json())
      .then((responseJson) => {
        this.setState({ cars: responseJson });
      });
  }

  // callback function for Options component to update the query when selections are made
  updateOptions = (query) => {
    this.queryString = query;
    this.getInventory();
  }

  render() {
    const { cars } = this.state;
    return <div className="container-fluid">
      <div className="row">
        <div className="col bg-dark text-white text-center">
          <div className="navbar-brand">iTrellis Car Dealership</div>
        </div>
      </div>
      <div className="row">
        <Options update={this.updateOptions} />

        <div className="col-8 p-2">
          <h2 className="text-center">Inventory</h2>
          <table className="table table-bordered table-striped">
            <thead>
              <tr>
                <th>Make</th>
                <th>Year</th>
                <th>Color</th>
                <th>Price</th>
                <th>Extras</th>
              </tr>
            </thead>
            <tbody>
              { cars && cars.map(car => {
                return ( 
                  <tr key={ car._id }>
                    <td>{ car.make }</td>
                    <td>{ car.year }</td>
                    <td>{ car.color }</td>
                    <td>{ car.price }</td>
                    <td><Extras car={ car } /></td>
                  </tr>   
                )} 
              )}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  }
}