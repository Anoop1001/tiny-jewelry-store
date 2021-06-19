import { Component, OnInit } from '@angular/core';
import { JewelleryStoreApiService } from 'src/app/services/jewellery-store-api.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  public userName:string="";
  public password:string="";
  public error:string ="";
  constructor(private jewelleryService : JewelleryStoreApiService, private router: Router) { }

  ngOnInit(): void {
  }

  public onClickButton()
  {
      var userCredentials:UserCredential = new UserCredential(this.userName, this.password);
      this.jewelleryService.login(userCredentials).subscribe(x=>
        {
          if(x)
          {
            this.router.navigate(['estimation', x.id ]);
          }
        }, error =>{

        })
  }

}

export class UserCredential
{
  name:string="";
  password:string="";

   constructor(_name:string, _password:string)
   {
      this.name = _name;
      this.password = _password;
   }
}
