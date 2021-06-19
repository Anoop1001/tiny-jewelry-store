import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
const httpOptions = {
  headers: new HttpHeaders({ 
    'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE,PATCH,OPTIONS'
  })
};
@Injectable({
  providedIn: 'root'
})

export class JewelleryStorePrinterApiService {
  baseUrl :string = "https://localhost:44328/api/printer";
  constructor(private http: HttpClient) { }

  print(type:number, data:any) : Observable<any>
  {
      return this.http.post(this.baseUrl+"/printer/"+type, data, httpOptions)
  }
}
