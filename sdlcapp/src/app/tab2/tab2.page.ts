import { Component } from '@angular/core';
import {CallAzureService} from '../api/call-azure.service';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  
  buildResponse:any =[]; 
  constructor (public azurecall:CallAzureService){}

  getBuildDetails()
  {
    
    this.azurecall.GetAzureDetails().subscribe((data)=>{
       let anyData=<any>data;
        this.buildResponse=anyData;
        console.log(this.buildResponse, "\n" ,data,"\n" ,anyData);
    })
  }

}
