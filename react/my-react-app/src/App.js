
import './App.css';
import React, {Component} from 'react';
import Employee from './employee';
import Cartoon from './cartoon';
import Car from './car';

class App extends React.Component{
  render(){
    return(
      <div>
        <h1>Parent Component</h1>
        <Product/>
        <Employee/>
        <Cartoon/>
        <Car/>
      </div>
    )
  }
}


class Product extends React.Component{
  render(){
    return(
      <div>
        <h1>Product Component</h1>

        <table border="2">
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Price</th>
          </tr>

          <tr>
            <td>111</td>
            <td>Pen</td>
            <td>500</td> 
          </tr>

          
          <tr>
            <td>112</td>
            <td>book</td>
            <td>2000</td> 
          </tr>
        </table>
      </div>
    )
  }
  
}


export default App;
