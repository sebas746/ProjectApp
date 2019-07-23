import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { RestService } from './rest.service';
import { Policy } from '../_models/Policy';

@Injectable({
  providedIn: 'root'
})
export class PoliciesService {

  constructor(private restService: RestService) { }

  public GetAllPolicies() {
    const url = environment.GetAllPolicies;    
    return this.restService.ResolveGetRequestObservable(url);
  }

  public CreatePolicy(policy: Policy) {
    const url = environment.CreatePolicy;    
    return this.restService.ResolvePostRequest(url, policy);      
  }

  public DeletePolicy(policyId: string) {
    let url = environment.DeletePolicy;   
    url = url.replace('[policyId]', policyId);

    return this.restService.ResolveGetRequestObservable(url);
  }

  public GetAllClients() {
    const url = environment.GetAllClients;    
    return this.restService.ResolveGetRequestObservable(url);
  }
}
