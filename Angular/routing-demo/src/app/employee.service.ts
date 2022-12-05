import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { Employee } from './employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  public getEmployees(){
    let employees:any;

    employees=[
      new Employee(101, "Vaibhav", 50000),
      new Employee(102, "Mahesh", 52000),
      new Employee(103, "vishnu", 80000),
      new Employee(104, "Ravi", 100000),
      new Employee(105, "manoj", 60000),
    ]
    return employees;
  }

  public getEmployee(id:any){
    let employees:Employee[]=this.getEmployees();
    return employees.find(e=>e.eid==id);
  }

  constructor() { }
}
