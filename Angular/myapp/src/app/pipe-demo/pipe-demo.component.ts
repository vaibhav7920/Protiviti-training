import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipe-demo',
  templateUrl: './pipe-demo.component.html',
  styleUrls: ['./pipe-demo.component.css']
})
export class PipeDemoComponent implements OnInit {

  presentDate = new Date();

  price = 5000;

  fruits =["Apple", "orange", "mango", "kiwi","watermelon","grapes"];

  decimalNum1: number =8.127329;
  decimalNum2: number = 5.43;

  product ={
    pid:101,
    name: "TV",
    price: 10000
  }
  constructor() { }

  ngOnInit(): void {
  }

}
