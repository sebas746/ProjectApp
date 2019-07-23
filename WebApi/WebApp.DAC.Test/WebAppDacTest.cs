using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApp.DataAccess;
using WebApp.Entities.DTO;
using WebApp.Interfaces.DAC;

namespace WebApp.DAC.Test
{
    [TestClass]
    public class WebAppDacTest : IDisposable
    {
        //Arrange                        
        private Mock<IPoliciesDAC> policiesDACMock;
        private PoliciesDAC policiesDAC;

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(Boolean disposing)
        {

        }

        [TestInitialize]
        public void Init()
        {
            //Arrange                        
            policiesDACMock = new Mock<IPoliciesDAC>();
            policiesDAC = new PoliciesDAC();

        }

        [TestMethod]
        public void GetAllPoliciesTest()
        {
            //Act
            var response = policiesDAC.GetAllPolicies();

            //Assert
            Assert.IsTrue(response.Count > 0);
            Assert.IsNotNull(response);
            Assert.IsInstanceOfType(response, typeof(List<PolicyDTO>));
        }

        [TestMethod]
        public void GetAllClients()
        {
            //Act
            var response = policiesDAC.GetAllClients();

            //Assert
            Assert.IsTrue(response.Count > 0);
            Assert.IsNotNull(response);
            Assert.IsInstanceOfType(response, typeof(List<ClientDTO>));
        }
    }
}
