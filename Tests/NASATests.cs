using Newtonsoft.Json;
using RestSharp;
using SDETAPI_CSharp.Core;
using SDETAPI_CSharp.Features;
using SDETAPI_CSharp.Features.HealthCareGov;
using SDETAPI_CSharp.Features.NasaOpenAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETAPI_CSharp.Tests
{
    public class NASATests
    {
        private string ValueResultSuccess = "200";
        private string pathFilesNasaOpenAPI = @"..\..\..\Requests\NasaOpenAPI\Gets";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("SanityTest")]
        public void TestApod()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Apod");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestAsteroidsNeoWS()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "AsteroidsNeoWS");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestDonki()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Donki");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestEarth()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Earth");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestEpic()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Epic");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestGoneLab()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "GoneLab");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestTechTransfer()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            FeatureResponse result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "TechTransfer");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }
    }
}
