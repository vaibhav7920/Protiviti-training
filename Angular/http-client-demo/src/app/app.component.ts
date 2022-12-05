import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export class Repos{
  id!:string;
  name!:string;
  url!:string;
  description!:string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit
{
  title = 'httpClient_demo';
  userName:string="user_angular";
  baseUrl:string="https://api.gitup.com";
  repos!:Repos[];

  ngOnInit() {
    this.getRepos();
  }

  constructor(private http:HttpClient){}

  public getRepos(){
    return this.http.get<Repos[]>(this.baseUrl+'users/'+this.userName+'/repos').
    subscribe(
(response)=>{console.log("Response Received");
console.log(response);
this.repos=response;},
(error) =>{
  console.log('request failed with error');
  alert(error);
},
()=>{console.log('Request completed');}
    )
  }
 
}
