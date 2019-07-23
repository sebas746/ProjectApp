using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.DataContext.WebApp;
using WebApp.Entities;
using WebApp.Entities.DTO;
using WebApp.Entities.Utilities;
using WebApp.Interfaces.DAC;
using WebApp.Interfaces.Service;

namespace WebApp.Services
{
    public class PoliciesService : IPoliciesService
    {
        public IPoliciesDAC _PoliciesDAC { get; set; }

        public PoliciesService(IPoliciesDAC PoliciesDAC)
        {
            this._PoliciesDAC = PoliciesDAC;
        }

        public List<PolicyDTO> GetAllPolicies()
        {
            try
            {
                var policies = _PoliciesDAC.GetAllPolicies();
                //var response = ConvertDTO.ConvertToPolicyDTO(policies);
                return policies;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Policy GetPolicyById(int PolicyId)
        {
            try
            {
                var response = _PoliciesDAC.GetPolicyById(PolicyId);
                return response;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public TransactionResponse CreatePolicy(Policy policy)
        {
            try
            {
                var transacResponse = new TransactionResponse();
                var response = _PoliciesDAC.CreatePolicy(policy);

                if (response)
                {

                    transacResponse.Message = "La póliza ha sido creada exitosamente.";
                    transacResponse.Status = "Success";
                }
                else
                {
                    transacResponse.Message = "Error. La póliza no pudo ser creada.";
                    transacResponse.Status = "Error";
                }

                return transacResponse;

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public TransactionResponse DeletePolicy(int policyId)
        {
            try
            {
                var transacResponse = new TransactionResponse();
                var response = _PoliciesDAC.DeletePolicy(policyId);

                if (response)
                {

                    transacResponse.Message = "La póliza ha sido eliminada exitosamente.";
                    transacResponse.Status = "Success";
                }
                else
                {
                    transacResponse.Message = "Error. La póliza no pudo ser eliminada.";
                    transacResponse.Status = "Error";
                }

                return transacResponse;

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public List<ClientDTO> GetAllClients()
        {
            try
            {
                var policies = _PoliciesDAC.GetAllClients();                
                return policies;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
