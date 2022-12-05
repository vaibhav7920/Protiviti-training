import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ErrorComponent } from './error/error.component';
import { ProductComponent } from './product/product.component';
import { EmpComponent } from './emp/emp.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';

const routes: Routes = [
  {path:'home', component:HomeComponent },
  {path:'emp', component:EmpComponent },
  {path:'emp/:id', component:EmployeeDetailsComponent},
  {path:'product', component:ProductComponent,
children:[
  { path:':id' ,  component:ProductDetailsComponent
},],},
  //{path:'product/:id', component:ProductDetailsComponent},
  {path:'', redirectTo:'home', pathMatch:'full' },
  {path:'**', component:ErrorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
