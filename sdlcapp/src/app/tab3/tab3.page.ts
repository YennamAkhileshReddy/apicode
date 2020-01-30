import { Component } from '@angular/core';
import * as HighCharts from 'highcharts';

@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page {

  constructor() {
    //const self= this;
    }

    ionViewDidEnter(){
      this.plotSimpleBarChart();
    }

    plotSimpleBarChart(){
  let myChart=HighCharts.chart('highcharts',{
  // updateFromInput=false;
  // Highcharts=HighCharts;
  // chartConstructor='chart';
  // chartCallback;
  // chartOptions={


      chart: {
        type: 'bar'
      },
      title: {
        text: ''
      },
      xAxis: {
        categories: ['Mobile App', 'DotNet App']
      },
      yAxis: {
       
        title: {
          text: 'Deploy Status'
          
        },
        labels: {
            overflow: 'justify'
        }
        
      },
      series: [
        {
          name: 'Pass',
          type: undefined,
          data: [30,  40]
        },
        {
          name: 'Failed',
          type: undefined,
          data: [7,  10]
        }]
    });
  }

  HealthCheckDotNet(){ alert("dotNet App is running Green");}
  HealthCheckApp(){alert("Mobile App is running Green");}

}
  //constructor() {
  //const self= this;
  //}
  // this.chartCallback= (chart) =>{ 
  //   setTimeout(()=> {
  //     chart.reflow();
  //     self.chart=chart;
  //   },0);
    
  // }





