import React from 'react';
import ReactDOM from 'react-dom/client';
// function Car(props){
//   return<h2>I am a {props.brand.model}</h2>;
// }
// function Garage()
// {
//   const carInfo={name:"Ford",model:"Mustag"}
//   return(
//     <>
//     <h1>Who lives in my garage?</h1>
//     <Car brand={carInfo}/>
//     </>
//   );
// }

function Garage(props){
  const cars =props.cars;
  return(
    <>
    <h1>Garage</h1>
    {cars.length > 0 && <h2>You have {cars.length} cars in yor garage </h2>}
    </>
  )

}

const cars =['BMW', 'Audi', 'porche']

function Football(){
  const shoot = () =>{
    alert("great shot")
  }

  return <button onClick={shoot}> take the shoot</button>
}

function MissedGoal(){
  return <h1>Missed</h1>
}


function MadeGoal(){
  return <h1>MadeGoal</h1>
}

function Goal(props){
  const isGoal = props.isGoal;

  return(
    <>
    {isGoal ? <MadeGoal/> : <MissedGoal/>}
    </>
  )
  // if(isGoal){
  //   return <MadeGoal/>
  // }

  // else{
  //   return <MissedGoal/>
  // }
}

function Car(props){
return <h2>I am a {props.brand}</h2>
}

function ListDemo(){
  // const cars =['BMW', 'Audi', 'porche','honda']

  const cars =[
    {id:1, brand: "BMW"},
    {id:2, brand: "Audi"},
    {id:3, brand: "Honda"},
  ]

  return (
    <>
    <h1>List Component</h1>
    <ul>
      {/* {cars.map((car)=> <Car brand={car}/>)} */}

      {cars.map((car)=> <Car key ={car.id} brand={car.brand}/>)}
    </ul>
    </>
  )
}

const root =ReactDOM.createRoot(document.getElementById('root'))
root.render([<Garage  cars={cars}/>, <Goal isGoal={true}/>, <ListDemo/>]);