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
        private string ValueResultSuccess = "OK";
        private string pathFilesHealthCareGov = @"..\..\..\Requests\HealthCareGov\Gets";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestArticles()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Articles");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestBlog()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Blog");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestBlogPageName()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "BlogPageName");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }


        [Test]
        public void TestEsBlogPageName()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "EsBlogPageName");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestGlossary()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Glossary");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestQuestions()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Questions");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestStates()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "States");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestTopics()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "Topics");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }

        [Test]
        public void TestFileNotExists()
        {
            //Instance object
            HealthCareGov healthCareGov = new HealthCareGov();
            //Execute validation
            string result = healthCareGov.ValidateAPI(pathFilesHealthCareGov, "FileName");
            //Validation result
            Assert.AreEqual(ValueResultSuccess, result);
        }
    }
}
