import React, { useRef } from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import reportWebVitals from './reportWebVitals';
import {useState, useEffect} from 'react';
import userEvent from '@testing-library/user-event';

function Favoritecolor()
{
    const [color,setcolor]=useState("red");
    return(
        <>
        <h1>My faourite color is {color}!</h1>
        <button type="button" onClick={()=>setcolor("blue")}>Blue</button>
        <button type="button" onClick={()=>setcolor("red")}>Red</button>
        <button type="button" onClick={()=>setcolor("Pink")}>Pink</button>
        <button type="button" onClick={()=>setcolor("Green")}>Blue</button>
        </>
    )
}

function Timer(){
  const [count,setCount]=useState(0);

  useEffect(()=>{
    setTimeout(()=>{
      setCount((count)=>count+1);
    }, 1000)
  })

  return <h1>I have rendered {count} times</h1>
}

function Car(){
  const [brand,setbrand]=useState("Ford");
  const [model,setmodel]=useState("Mustang");
  const [year,setyear]=useState("2022");
  const [color,setcolor]=useState("red");

  return(
    <>
    <h1>my {brand}</h1>
    <p>It is a {color} {model} from {year} </p>
    </>
)
}

function Emp()
{
    const [emp,setEmp]=useState({
        name:"Mugil",
        age:"25",
        department:"evelopment",
        salary:"50000",
        city:"Chennai"
    });
    const updateSalary=()=>{
        setEmp(previousState=>{
            return {...previousState,salary:"65000"}  })
    }
    return(
        <>
        <h1>my {emp.name}</h1>
        <p>my age is {emp.age} belongs to {emp.department} and i am getting the salary of  
        {emp.salary}  and i am from {emp.city}</p>
        <button type="button" onClick={updateSalary}>New Salary</button>
        </>
    )
}


function Counter(){
  const[count,setCount]=useState(0);
  const[calculation,setcalculation]=useState(0);

  useEffect(()=>{
    setcalculation(()=>count*2)
  },[count]);

  return(
    <>
    <p>Count: {count} </p>
    <button onClick={()=>setCount((c)=>c+1)}>+</button>
    <p>calculation{calculation}</p>
    </>
  )
}


function Component1(){
  const [user,setuser]=useState("Jesse Hall");
  return(
    <>
    <h1>{`hello ${user}`}</h1>

    <Component2 user={user}/>
    </>
  );
}

function Component2({user}){
  return(
    <>
    <h1>Component2</h1>
    <Component3 user={user}/>
    </>
  );
}
function Component3({user}){
  return(
    <>
    <h1>Component3</h1>
    <Component4 user={user}/>
    </>
  );
}
function Component4({user}){
  return(
    <>
    <h1>Component4</h1>
    <Component5 user={user}/>
    </>
  );
}
function Component5({user}){
  return(
    <>
    <h1>Component5</h1>
    <h1>{`hello again ${user}`}</h1>
    </>
  );
}

function App(){
  const [inputvalue, setinputvalue]=useState("");
  const count = useRef(0);
  useEffect(()=>{
    count.current=count.current+1;
  })

  return (
    <>
    <input type="text" value={inputvalue} onChange={(e)=>setinputvalue(e.target.value)}/>
    <h1>Render count: {count.current} </h1>
    </>
  )
}
const root=ReactDOM.createRoot(document.getElementById('root'));
root.render([<Favoritecolor />, <Car/>, <Emp/>,<Timer/>,<Counter/>, <Component1/>, <App/>])

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
