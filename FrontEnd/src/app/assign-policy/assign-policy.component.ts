import { Component, OnInit } from '@angular/core';
import { PoliciesService } from '../_services/policies.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-assign-policy',
  templateUrl: './assign-policy.component.html',
  styleUrls: ['./assign-policy.component.css']
})
export class AssignPolicyComponent implements OnInit {
  asssingPolicyForm: FormGroup;
  public clients: any;
  public policies: any;
  public tittle = 'Asignación de Pólizas';
  keyword = 'ClientFullName';
  submitted = false;

  dropdownList = [];
  selectedItems = [];
  dropdownSettings = {};

  constructor(private formBuilder: FormBuilder,
    private _policiesService: PoliciesService) { }

  ngOnInit() {

    this.asssingPolicyForm = this.formBuilder.group({
      Client: ['', Validators.required],
      Policies: ['', Validators.required]
    });

    this._policiesService.GetAllClients().subscribe((data: {}) => {
      this.clients = data;
    });

    this._policiesService.GetAllPolicies().subscribe((data: {}) => {
      this.policies = data;
    });
   
    this.dropdownSettings = {
      singleSelection: false,
      idField: 'PolicyId',
      textField: 'PolicyName',
      selectAllText: 'Seleccionar Todas',
      unSelectAllText: 'Deseleccionar Todas',
      itemsShowLimit: 3,
      allowSearchFilter: true
    };
  }

  get f() { return this.asssingPolicyForm.controls; }

  //For Autocomplete
  selectEvent(item) {
    console.log(item);
  }
  onChangeSearch(search: string) {
    // fetch remote data from here
    // And reassign the 'data' which is binded to 'data' property.
  }
  onFocused(e) {
    // do something
  }

  onItemSelect(item: any) {
    console.log(item);
  }
  onSelectAll(items: any) {
    console.log(items);
  }

  onSubmit() {
    this.submitted = true;

    if (this.asssingPolicyForm.invalid) {
      console.log('invalid');
      return;
    }

    console.log(this.asssingPolicyForm.value);
  }
}
