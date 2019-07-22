declare var data: any;
export const environment = {
  production: true,

  GetAllPolicies: data.basePath + 'api/Policies/GetAllPolicies/',
  CreatePolicy: data.basePath + 'api/Policies/CreatePolicy/'
};
