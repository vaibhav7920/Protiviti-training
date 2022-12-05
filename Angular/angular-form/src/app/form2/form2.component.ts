import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { groupBy } from 'rxjs/internal/operators/groupBy';
// import { country } from '../app.component';

@Component({
  selector: 'app-form2',
  templateUrl: './form2.component.html',
  styleUrls: ['./form2.component.css']
})
export class Form2Component implements OnInit {

  title = 'Angular Reactive Forms';

  contactForm: any;

  constructor(private formBuilder: FormBuilder) {
    this.contactForm = this.formBuilder.group({
      firstname: ['', [Validators.required, Validators.minLength(10)]],
      lastname: ['', [Validators.required, Validators.maxLength(15), Validators.pattern("^[a-zA-Z]+$")]],
      email: ['', [Validators.required, Validators.email]],
      gender: ['', [Validators.required]],
      isMarried: ['', [Validators.required]],
      country: ['', [Validators.required]],
      address: this.formBuilder.group({
        city: ['', [Validators.required]],
        street: ['', [Validators.required]],

        pincode: ['', [Validators.required]],

      })
    });
  }

  get firstname() {
    return this.contactForm.get('firstname');
  }

  get lastname() {
    return this.contactForm.get('lastname');
  }

  get email() {
    return this.contactForm.get('email');
  }
  get gender() {
    return this.contactForm.get('gender');

  }

  get isMarried() {
    return this.contactForm.get('isMarried');
  }

  get country() {
    return this.contactForm.get('country');
  }

  get city() {
    return this.contactForm.get('address').get('city');
  }

  get street() {
    return this.contactForm.get('address').get('street');
  }
  get pincode() {
    return this.contactForm.get('address').get('pincode');
  }

  countryList: country[] = [
    new country("1", "India"),
    new country("2", "USA"),
    new country("3", "UK"),
  ];


  onSubmit() {
    console.log(this.contactForm.value);
  }

  ngOnInit(): void {
  }

}


export class country {
  id!:String;
  name!: string

  constructor(id:string,name:string){
    this.id=id;
    this.name=name;
  }
}