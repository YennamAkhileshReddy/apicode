import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CallAzureService {

  constructor(public http:HttpClient) { }

  GetAzureDetails()
  {
    let headers: HttpHeaders = new HttpHeaders();
    headers.append('Content-Type', 'application/x-www-form-urlencoded; charset=UTF-8');
    headers.append('Authorization', "2xbpth7m4xi34hx6wawwpbyfvllscthvfgiowukmngbaat3lddwa");

    return this.http.get("https://dev.azure.com/GIRISHSHARMA0640/DevOpsSM/_apis/build/builds?api-version=5.1", {headers});
                          
//https://dev.azure.com/GIRISHSHARMA0640/DevOpsSM/_apis/build/builds?api-version=5.1
  }
}
