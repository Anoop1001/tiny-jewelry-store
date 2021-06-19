import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { JewelleryStoreApiService } from 'src/app/services/jewellery-store-api.service';
import { JewelleryStorePrinterApiService } from 'src/app/services/jewellery-store-printer-api.service';

@Component({
  selector: 'app-estimation',
  templateUrl: './estimation.component.html',
  styleUrls: ['./estimation.component.scss']
})
export class EstimationComponent implements OnInit {
  public id:string="";
  public price:number=0;
  public weight:number=0;
  public totalPrice:number=0;

  public userDetails:any=null;
  constructor(private route: ActivatedRoute, private jewelleryService : JewelleryStoreApiService
    , private jewelleryStorePrinterApiService : JewelleryStorePrinterApiService) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
       this.id = params['id'];
       this.jewelleryService.getCustomer(this.id).subscribe(x=>
        {
          this.userDetails = x;
        }, error =>{

        })
    });
  }

  public onClickButton()
  {
      var jewellery:Jewellery = new Jewellery(this.price, this.weight);
      this.jewelleryService.getTotalPrice(this.id, jewellery).subscribe(x=>
        {
          this.totalPrice = x;
        }, error =>{

        })
  }

  public onPrint(type:number)
  {
      
      this.jewelleryStorePrinterApiService.print(type, this.totalPrice).subscribe(x=>
        {
          this.totalPrice = x;
        }, error =>{

        })
  }
}

export class Jewellery
{
  price:number = 0;
  weight:number = 0;
  constructor(price:number, weight:number)
  {
     this.price = price;
     this.weight = weight;
  }
}
