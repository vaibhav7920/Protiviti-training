import ReactDOM  from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "./Home";
import About from "./About"
import Contact from "./Contact";
import Product from "./Product";
import Employee from "./Employee";



export default function App() {
  return (
    <BrowserRouter>
      <Routes>
      <Route exact path='/' element={< Home />}></Route>
     <Route exact path='/about' element={< About />}></Route>
    <Route exact path='/contact' element={< Contact />}></Route>
    <Route exact path='/product' element={< Product />}></Route>
    <Route exact path='/employee' element={< Employee />}></Route>
      </Routes>
    </BrowserRouter>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);