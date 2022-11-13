using SDETAPI_CSharp.Core;
using SDETAPI_CSharp.Features.AzureWebSites;
using SDETAPI_CSharp.Features.HealthCareGov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETAPI_CSharp.Tests
{
    internal class AzureWebSitesTest
    {
        private string ValueResultSuccess = "200";
        private string pathFilesHealthCareGov = @"..\..\..\Requests\AzureWebSites\Posts";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("SanityTest")]
        public void TestApiOrdersPaged()
        {
            //Instance object
            AzureWebSites azureWebSites = new AzureWebSites();
            //Execute validation
            FeatureResponse result = azureWebSites.ValidateAPI(pathFilesHealthCareGov, "ApiOrdersPaged");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));

        }

        [Test]
        [Category("SanityTest")]
        public void TestApiOrdersPaged2()
        {
            //Instance object
            AzureWebSites azureWebSites = new AzureWebSites();
            //Execute validation
            FeatureResponse result = azureWebSites.ValidateAPI(pathFilesHealthCareGov, "ApiOrdersPaged2");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));

        }
    }
}
