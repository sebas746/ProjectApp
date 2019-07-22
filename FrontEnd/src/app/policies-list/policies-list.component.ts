import { Component, OnInit } from '@angular/core';
import { PoliciesService } from '../_services/policies.service';

declare var jQuery: any;
declare var $: any;

@Component({
  selector: 'app-policies-list',
  templateUrl: './policies-list.component.html',
  styleUrls: ['./policies-list.component.css']
})
export class PoliciesListComponent implements OnInit {

  private policiesList: any = [];

  constructor(private _policiesService: PoliciesService) { }

  ngOnInit() {
    this._policiesService.GetAllPolicies().subscribe((data: {}) => {
      this.policiesList = data;
      console.log(data);
    });
    //console.log(JSON.stringify( this.policiesList ));
  }

  public onNewClick() {
    alert('hola');
  }
}
