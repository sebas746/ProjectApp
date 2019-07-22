using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.Service;

namespace WebApi.Controllers
{
    public class PoliciesController : ApiController
    {
        public IPoliciesService _PoliciesService;

        public PoliciesController(IPoliciesService PoliciesService)
        {
            this._PoliciesService = PoliciesService;
        }

        [HttpGet]
        [Route("api/Policies/GetAllPolicies/")]
        public IHttpActionResult GetAllPolicies()
        {
            var response = _PoliciesService.GetAllPolicies();
            return Ok(response);
        }

        [HttpGet]
        [Route("api/Policies/GetPolicyById/")]
        public IHttpActionResult GetPolicyById(int PolicyId)
        {
            var response = _PoliciesService.GetPolicyById(PolicyId);
            return Ok(response);
        }

        [HttpPost]
        [Route("api/Policies/CreatePolicy/")]
        public IHttpActionResult CreatePolicy(Policy policy)
        {
            var response = _PoliciesService.CreatePolicy(policy);
            return Ok(response);
        }
    }
}
