import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router'
import { ProductService } from '../product.service';
import { Product } from '../product';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {

  product:any;
  id:any;
  sub:any;



  constructor(private _ActivatedRoute:ActivatedRoute, private _router:Router, private _productService:ProductService) { }

  ngOnInit() {

    this.sub = this._ActivatedRoute.paramMap.subscribe(params=>{
      console.log(params);
      this.id = params.get('id');
      let products = this._productService.getProducts();
      this.product = products.find((p: { pid: any; })=>p.pid = this.id);
    })
  }

  onBack() : void {
    this._router.navigate(['product'])
  }
}
