import React,  {Component} from "react";

class Employee extends React.Component{
    render(){
        var mystyle={
            fontsize:"30px",
            color:"red"
        };
        return(
            <div>
        <h1 style={mystyle}>Product Component</h1>

        <table border="2">
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Salary</th>
          </tr>

          <tr>
            <td>111</td>
            <td>Prtham</td>
            <td>500</td> 
          </tr>

          
          <tr>
            <td>112</td>
            <td>harsh</td>
            <td>2000</td> 
          </tr>
        </table>
      </div>
        )
    }

}

export default Employee