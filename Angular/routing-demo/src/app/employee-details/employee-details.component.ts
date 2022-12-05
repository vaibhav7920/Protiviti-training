import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router'
import { EmployeeService } from '../employee.service';
import { Employee } from '../employee';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  employee:any;
  id:any;
  sub:any;



  constructor(private _ActivatedRoute:ActivatedRoute, private _router:Router, private _employeeService:EmployeeService) { }

  ngOnInit() {

    this.sub = this._ActivatedRoute.paramMap.subscribe(params=>{
      console.log(params);
      this.id = params.get('id');
      let employees = this._employeeService.getEmployees();
      this.employee = employees.find((e: { eid: any; })=>e.eid = this.id);
    })
  }

  onBack() : void {
    this._router.navigate(['emp'])
  }

}
