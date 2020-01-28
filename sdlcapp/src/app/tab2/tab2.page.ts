import { Component } from '@angular/core';
import {CallAzureService} from '../api/call-azure.service';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  checkSameValue1= "sdlcnetcoreapp";   //initialised before constructor
  checkSameValue2="SDLC_Mobile_Build";   //initialised before constructor
  buildResponse:any =[]; 
  constructor (public azurecall:CallAzureService){}
  
  displayCondition(checkValue, elementValue) {
          if(this.checkSameValue1 && this.checkSameValue1 == checkValue) {
            return false;
          }
          if(checkValue == elementValue) {
            this.checkSameValue1 = checkValue;
            return true;
          }
        }

  getBuildDetails()
  {
    
    this.azurecall.GetAzureDetails().subscribe((data)=>{
       let anyData=<any>data;
        this.buildResponse=anyData;
        console.log(this.buildResponse, "\n" ,data,"\n" ,anyData);
    })
  }

}
