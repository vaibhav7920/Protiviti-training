import logo from './logo.svg';
import './App.css';
class App extends Component {
  render() {
    return (
       <Router>
           <div className="App">
    <ul>
      <li>
        <Link to="/">Home</Link>
      </li>
      <li>
        <Link to="/about">About Us</Link>
      </li>
      <li>
        <Link to="/contact">Contact Us</Link>
      </li>
      <li>
        <Link to="/product">Product</Link>
      </li>
      <li>
        <Link to="/employee">Employee</Link>
      </li>

    </ul>
</div>
       </Router>
   );
  }
}
export default App;