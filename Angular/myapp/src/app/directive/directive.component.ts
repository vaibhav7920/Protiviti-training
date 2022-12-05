import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directive',
  templateUrl: './directive.component.html',
  styleUrls: ['./directive.component.css']
})
export class DirectiveComponent implements OnInit {

  //if
  result: boolean = true;

  //If else
  isLogin: boolean =true;
  isLogout: boolean =false;

//Switch case
  loginName ="user";


  product =[
    {id:111, name:"TV", price:20000},
    {id:112, name:"car", price:450000},
    {id:113, name:"fan", price:2000},
    {id:114, name:"light", price:200}
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
