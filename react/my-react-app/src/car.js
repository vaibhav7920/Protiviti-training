import React, {Component} from "react";

class Car extends React.Component{

    constructor(){
        super();
        this.state={color:"red"}
        this.state={cname:"Audi"}
        this.state={model:"2020"}
    }
    render(){
        return(<h2>I am a {this.state.color} car <br/> and model is {this.state.cname}<br/> model {this.state.model}</h2>)
    }
}

export default Car