import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  myCssClass = "red";
  applyCSSClass="blue";


  prodid=1001;
  prodname="laptop";
  company="apple";

  myColor="hotpink";

  display(){
    document.write('product id' + this.prodid);
  }

  pid=1002;
  pname="books";
  price=600;
  constructor() { }

  ngOnInit(): void {
  }

}
