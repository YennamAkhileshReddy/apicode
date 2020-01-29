import { Component } from '@angular/core';
import * as HighCharts from 'highcharts';

@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page {
  chart='';
  updateFromInput=false;
  Highcharts=HighCharts;
  chartConstructor='chart';
  chartCallback;
  chartOptions={


      chart: {
        type: 'bar'
      },
      title: {
        text: ''
      },
      xAxis: {
        categories: ['DotNet', 'MobileApp']
      },
      yAxis: {
        min: 0;
        title: {
          text: 'App Type'
          
        },
        labels: {
            overflow: 'justify'
        }
        
      },
      series: [
        {
          name: 'DotNet',
          type: undefined,
          data: [1,  2]
        },
        {
          name: 'Mobile',
          type: undefined,
          data: [2,  1]
        }]
    };
  constructor() {
  const self= this;
  
  this.chartCallback=chart =>{  self.chart=chart;}

  }

  HealthCheckDotNet(){}
  HealthCheckApp(){}

}
