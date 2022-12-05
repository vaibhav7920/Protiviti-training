import { Component, OnInit } from '@angular/core';
import { RestApiService } from '../rest-api.service';
import { ActivatedRoute,Router } from '@angular/router';

@Component({
  selector: 'app-employee-edit',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.css']
})
export class EmployeeEditComponent implements OnInit {
  id=this.actRoute.snapshot.params['id'];
  employeeData:any={};
  constructor(
    public restapi:RestApiService,
    public actRoute:ActivatedRoute,
    public router:Router
  ) { }

  ngOnInit()
   {
    this.restapi.getEmployee(this.id).subscribe((data:{})=>{
      this.employeeData=data;
    })
  }
updateEmployee()
{
  if(window.confirm('Are you sure, you want to update?')){
    this.restapi.updateEmployee(this.id,this.employeeData).subscribe(data=>{
      this.router.navigate(['/employee-list'])
    })
  }
}
}
