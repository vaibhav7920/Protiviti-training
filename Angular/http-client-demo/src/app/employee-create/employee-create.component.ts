import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RestApiService } from '../rest-api.service';

@Component({
  selector: 'app-employee-create',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.css']
})
export class EmployeeCreateComponent implements OnInit 
{
@Input() employeeDetails ={name:'',email:''};

constructor(public restapi:RestApiService, public router:Router){}
  
ngOnInit(): void { }

addEmployee(dataEmployee:any)
{
  this.restapi.createEmployee(this.employeeDetails).subscribe((data:{})=>{
    this.router.navigate(['/employee-list']);
  })
}

}
