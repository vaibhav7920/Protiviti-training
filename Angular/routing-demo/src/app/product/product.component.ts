import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from '../product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  // product =[
  //   {pid:101, name:"TV", price: 20000},
  //   {pid:102, name:"Car", price: 2000000},
  //   {pid:103, name:"Washing Machine", price: 30000},
  //   {pid:104, name:"Bulb", price: 200},
  //   {pid:105, name:"Fridge", price: 50000},
  // ]

  products:any;

  constructor(private productService:ProductService) { }

  ngOnInit(): void {

   this.products= this.productService.getProducts();
  }

}
