import { Component } from '@angular/core';
import { from,of } from 'rxjs';
import { filter, map,  catchError } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'rxjs-demo';

  numbers: number[]=[];
  val1:number =0;
  filteredNumbers :number[]=[];
  val2:number=0;
  processedNumber:number[]=[];
  val3:number=0;

  ngOnInit(){
    const number$=from([1,2,3,4,5,6,7,8,9,10]);
    const observer={
      next:(num :number)=>{this.numbers.push(num); this.val1+= num},
      error:(err:any)=>{console.log(err)},
      complete:()=>{console.log("observation completed")}
      
    };
    number$.subscribe(observer);

    const FilterFn= filter((num:number)=>num>5);
    const filteredNumbers$ =FilterFn(number$);
    filteredNumbers$.subscribe((num :number)=>{this.filteredNumbers.push(num); this.val2+= num});


    const mapFn = map((num:number)=>num+num);
    const processedNumber$=number$.pipe(FilterFn,mapFn);
    processedNumber$.subscribe((num :number)=>{this.processedNumber.push(num);this,this.val3+= num});
  }
}
