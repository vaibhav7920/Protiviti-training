import React, {Component} from "react";

class Cartoon extends React.Component{
    render(){
        var imag ="https://www.bing.com/th?id=OIP.boU0VLtfyLfKIbp_1YIWJgHaFj&w=128&h=100&c=8&rs=1&qlt=90&o=6&dpr=1.25&pid=3.1&rm=2"
        return(
            <div>
                <img src={imag}></img>
            </div>
        )
    }
}
export default Cartoon