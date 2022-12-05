import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-emp',
  templateUrl: './emp.component.html',
  styleUrls: ['./emp.component.css']
})
export class EmpComponent implements OnInit {

  employee =[
    {eid:101, name:"Tanya", salary: 20000},
    {eid:102, name:"Vaibhav", salary: 49000},
    {eid:103, name:"Sourabh", salary: 30000},
    {eid:104, name:"Manish", salary: 20000},
    {eid:105, name:"Rajat", salary: 50000},
  ]


  constructor() { }

  ngOnInit(): void {
  }

}
