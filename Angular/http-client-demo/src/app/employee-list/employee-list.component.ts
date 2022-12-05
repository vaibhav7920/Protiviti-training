import { Component, OnInit } from '@angular/core';
import { RestApiService } from '../rest-api.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit 
{
Employee:any=[];

  constructor(public restapi:RestApiService) { }

  ngOnInit()
  {
    this.loadEmployees();
  }

  loadEmployees()
  {
    return this.restapi.getEmployees().subscribe((data:{})=>{this.Employee=data});
  }

  deleteEmployee(id:any)
  {
    if(window.confirm('Are you sure, you want to delete?'))
    {this.restapi.deleteEmployee(id).subscribe((data)=>{this.loadEmployees();})}
  }
}
