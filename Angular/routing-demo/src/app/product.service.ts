import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  public getProducts(){
    let products:any;

    products=[
      new Product(101, "TV", 50000),
      new Product(102, "Fridge", 52000),
      new Product(103, "washing machine", 80000),
      new Product(104, "sofa", 100000),
      new Product(105, "Dining table", 60000),
    ]
    return products;
  }

  public getProduct(id:any){
    let products:Product[]=this.getProducts();
    return products.find(p=>p.pid==id);
  }

  constructor() { }
}
