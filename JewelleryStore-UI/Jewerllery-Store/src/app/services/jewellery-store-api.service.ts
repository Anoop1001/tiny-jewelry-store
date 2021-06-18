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

export class JewelleryStoreApiService {
  baseUrl :string = "https://localhost:44328/api/customer";
  constructor(private http: HttpClient) { }

  login(loginData:any) : Observable<any>
  {
      return this.http.post(this.baseUrl+"/login", loginData, httpOptions)
  }
}
