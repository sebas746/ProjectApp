import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Policy } from '../_models/Policy';
import { PoliciesService } from '../_services/policies.service';

@Component({
  selector: 'app-create-policy',
  templateUrl: './create-policy.component.html',
  styleUrls: ['./create-policy.component.css']
})
export class CreatePolicyComponent implements OnInit {
  policyForm: FormGroup;
  submitted = false;
  tittle = 'Crear Nueva Póliza';
  
  constructor(private formBuilder: FormBuilder,
    private _policiesService: PoliciesService) {     
  }

  ngOnInit() {
    this.policyForm = this.formBuilder.group({
      PolicyName: ['', Validators.required],
      PolicyStartDate: ['', [Validators.required]],
      CoverageTypeId: ['', Validators.required],
      PolicyPrice: ['', Validators.required],
      PolicyPeriod: ['', Validators.required],
      RiskTypeId: ['', Validators.required],
      PolicyDescription: ['', [Validators.required, Validators.minLength(10)]]
    });
  }

  get f() { return this.policyForm.controls; }

  onSubmit() {
    this.submitted = true;

    if (this.policyForm.invalid) {
      return;
    }

    let policy = new Policy(this.policyForm.value);

    let resul = this._policiesService.CreatePolicy(policy);

    console.log(resul);
  }

}
