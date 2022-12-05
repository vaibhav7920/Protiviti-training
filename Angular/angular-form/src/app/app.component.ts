import { Component, OnInit , ContentChildDecorator, ViewChild, ElementRef} from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Template driven Forms';

  contact !:contact;

  countryList:country[] =[
    new country("1", "India"),
    new country("2", "USA"),
    new country("3", "UK"),
  ];


  setDefaults(){
    this.contact={
      firstName:"Sachin",
      lastName: "Tendulkar",
      email:"sachin@gmail.com",
      gender:"Male",
      isMarried: true,
      country:"1",
      address:{city:"Mumbai",street:"Perry Road",pincode:"40050"}

    };
  }

  onSubmit(contactForm:any){
console.log(contactForm.value);
  }

  reset(contactForm:NgForm){
contactForm.resetForm();
  }

  ngOnInit() {
    this.contact={
      firstName:"Sachin",
      lastName: "Tendulkar",
      email:"sachin@gmail.com",
      gender:"Male",
      isMarried: true,
      country:"1",
      address:{city:"Mumbai",street:"Perry Road",pincode:"40050"}

    };
  }
}

export class contact{
  firstName!: string;
      lastName!: string;
      email!: string;
      gender!: string;
      isMarried!: boolean;
      country!: string;
      address:{ 
        city: string ;
        street: string; 
        pincode: string;
      } | any
}


export class country{
  id:String;
  name: string

  constructor(id:string,name:string){
    this.id=id;
    this.name=name;
  }
}
