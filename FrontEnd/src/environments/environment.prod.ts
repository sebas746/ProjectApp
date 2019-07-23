declare var data: any;
export const environment = {
  production: true,

  GetAllPolicies: data.basePath + 'api/Policies/GetAllPolicies/',
  CreatePolicy: data.basePath + 'api/Policies/CreatePolicy/',
  DeletePolicy: data.basePath + 'api/Policies/DeletePolicy?policyId=[policyId]',
  GetAllClients: data.basePath + 'api/Policies/GetAllClients/'
};
