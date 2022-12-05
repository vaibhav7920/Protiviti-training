import React, {Component} from "react";

class Form extends React.Component{
constructor (props){
    super(props);
    this.regeisterd =  this.regeisterd.bind(this);
    this.input = React.createRef();
};

regeisterd(event){
    alert("Candidate registerd succesfully");
    event.preventDefault();
}
render(){
    return(
        <div>
        <form onSubmit={this.regeisterd}>
          <label>Name:<input type="text" ref={this.input} /></label><br/>
          <label>Email:<input type="email" ref={this.input} /></label><br/>
          <label>Phone Number:<input type="number" ref={this.input} /></label><br/>
          <label>Password:<input type="password" ref={this.input} /></label><br/>
          <input type="submit" value="submit"/>

        </form>
        </div>
    )
}
}

export default Form