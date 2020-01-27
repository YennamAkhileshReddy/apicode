import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CallAzureService {

  constructor(public http:HttpClient) { }

  GetAzureDetails()
  {
    return this.http.get("https://dev.azure.com/GIRISHSHARMA0640/DevOpsSM/_apis/build/builds?api-version=5.1");
                          
//https://dev.azure.com/GIRISHSHARMA0640/DevOpsSM/_apis/build/builds?api-version=5.1
  }
}
