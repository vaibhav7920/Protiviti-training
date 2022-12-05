import React, {Component} from "react";
import Form from "./Form";

class App extends React.Component {

  constructor(props){
    super(props);

    this.updateSubmit =  this.updateSubmit.bind(this);
    this.input = React.createRef();

    this.state ={
      personsGoing: true,
      numberOfPersons:5
    };

    this.handleInputChange =this.handleInputChange.bind(this);
  }

  handleInputChange(event){
    const target=event.target;
    const value=target.type==='checkbox'?target.checked:target.value;
    const name =target.name;
    this.setState({
      [name]:value
    })
  }

  updateSubmit(event){

    alert("You have entered the username and password successfully");
    event.preventDefault();
  }

  render(){
    return(
      <div>
        <form onSubmit={this.updateSubmit}>
          <label>Username:<input type="text" ref={this.input} /></label><br/>
          <label>Password:<input type="password" ref={this.input} /></label><br/>
          <input type="submit" value="submit"/>
          </form>
          <br/><br/><br/>
          <form>
          <h1>Multiple input</h1>
          <label>Is the Person going <input name="person going" type="checkbox" checked={this.personsGoing} 
          onChange={this.handleInputChange} /></label>
          <label>Is the Person going <input name="number of persons" type="number" checked={this.numberOfPersons} 
          onChange={this.handleInputChange} /></label>

</form>
<br/><br/><br/><br/>
        <Form/>

       

      </div>

      
    )
  }

}

export default App;
