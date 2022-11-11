using Newtonsoft.Json;
using RestSharp;
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
        private string ValueResultSuccess = "OK";
        private string pathFilesNasaOpenAPI = @"..\..\..\Requests\NasaOpenAPI\Gets";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestApod()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Apod");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestAsteroidsNeoWS()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "AsteroidsNeoWS");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestDonki()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Donki");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestEarth()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Earth");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestEpic()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "Epic");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestGoneLab()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "GoneLab");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestTechTransfer()
        {
            //Instance object
            NasaOpenAPI nasaOpenAPI = new NasaOpenAPI();
            //Execute validation
            string result = nasaOpenAPI.ValidateAPI(pathFilesNasaOpenAPI, "TechTransfer");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }
    }
}
