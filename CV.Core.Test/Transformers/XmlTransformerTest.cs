using CV.Core.Interfaces;
using CV.Core.Transformers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CV.Core.Test.Transformers
{
    [TestClass]
    public class XmlTransformerTest
    {
         string basePath = AppDomain.CurrentDomain.BaseDirectory;
         string templatePath, dataPath;
         IXmlTransformer testSubject;

        [TestInitialize]
        public  void Setup()
        {
            testSubject = new XmlTransformer();
            templatePath = Path.Combine(basePath, "../../../PeterStankowski/Templates/xslt/Default.xslt");
            dataPath = Path.Combine(basePath, "../../../PeterStankowski/Templates/Empty.xml");  
        }

        [TestMethod]
        public void LoadTemplateTest()
        {
            try
            {
                testSubject.LoadTemplate(templatePath); // test
            } catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoadDataTest()
        {
            try
            {
                testSubject.LoadData(dataPath); // test
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void TransformDataTest()
        {
            StringWriter writer;
            testSubject.LoadTemplate(templatePath);
            testSubject.LoadData(dataPath);
            testSubject.TransformTemplate(out writer);

            Assert.IsNotNull(writer); // test
        }

        [TestMethod]
        public void DecodeToStringTest()
        {
            StringWriter writer;
            testSubject.LoadTemplate(templatePath);
            testSubject.LoadData(dataPath);
            testSubject.TransformTemplate(out writer);

            var tocheck = testSubject.DecodeToString(writer);

            Assert.AreEqual(tocheck, HttpUtility.HtmlDecode(writer.ToString())); // test
        }
    }
}
