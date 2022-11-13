using SDETAPI_CSharp.Core;
using SDETAPI_CSharp.Features.HealthCareGov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETAPI_CSharp.Tests
{
    internal class HealthCareGovTests
    {
        private string ValueResultSuccess = "200";
        private string pathFilesHealthCareGov = @"..\..\..\Requests\HealthCareGov\Gets";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("SanityTest")]
        public void TestArticles()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Articles");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
           
        }

        [Test]
        [Category("SmokeTest")]
        public void TestBlog()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Blog");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestBlogPageName()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "BlogPageName");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }


        [Test]
        [Category("SmokeTest")]
        public void TestEsBlogPageName()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "EsBlogPageName");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestGlossary()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Glossary");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestQuestions()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Questions");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestStates()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "States");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestTopics()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            FeatureResponse result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Topics");
            //Validation result
            Assert.That(result.statusCode, Is.EqualTo(ValueResultSuccess));
        }

    }
}
