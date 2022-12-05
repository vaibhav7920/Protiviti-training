import { Directive,ElementRef } from '@angular/core';

@Directive({
  selector: '[appMyStyle]'
})
export class MyStyleDirective {

  constructor(el:ElementRef) { 
    el.nativeElement.style.color = "red";
    el.nativeElement.style.fontSize = "30px";
  }

}
