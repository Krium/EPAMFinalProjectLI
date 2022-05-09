using FinalTestLorem.PageObjects;
using FinalTestLorem.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTestLorem
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        BusinessLL bll;
       
        
        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lipsum.com/");
            bll = new BusinessLL(driver);
        }

        [TestMethod]
        public void CheckThatParagraphContainKeyWord()
        {        
            bll.ChangeLanguageToRu();
            Assert.IsTrue(bll.GetTextFromHomePageParagraph().Contains("рыба"));           
        }

        [TestMethod]
        public void CheckGenerate()
        {
           bll.ClickOnGenereateButtonOnHomePage();
           Assert.IsTrue(bll.GetTextFromParagraphOnGenerateResultPage().StartsWith("Lorem ipsum dolor sit amet, consectetur adipiscing elit"));          
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(5)]
        [DataRow(20)]
        public void CheckThatLIGenerateCorrectSize(int value)
        {            
            bll.ClickOnRadioButtonWord(); 
            bll.SetValue(value.ToString());
            bll.ClickOnGenereateButtonOnHomePage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var arrayWithWords = bll.GetTextFromParagraphOnGenerateResultPage().Split(' ');
            Assert.AreEqual(value, arrayWithWords.Length);           
        }

        [TestMethod]
        [DataRow(41)]
        [DataRow(10)]
        [DataRow(100)]
        public void CheckThatLIGenerateCorrectSizeInBytes(int value)
        {
            bll.ClickOnRadioButtonBytes();   
            bll.SetValue(value.ToString());
            bll.ClickOnGenereateButtonOnHomePage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Assert.AreEqual(value,System.Text.ASCIIEncoding.ASCII.GetByteCount(bll.GetTextFromParagraphOnGenerateResultPage()));           
        }

        [TestMethod]
        public void CheckCheckBox()
        {            
            bll.ClickOnCheckBoxOnHomePage();
            bll.ClickOnGenereateButtonOnHomePage(); 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);                  
            Assert.IsFalse(bll.GetTextFromParagraphOnGenerateResultPage().StartsWith("Lorem ipsum"));           
        }

        [TestMethod]
        public void CheckThatRandomlyGeneratedTextParagraphsContainKeyWord()
        {           
            int sumAllCounts = 0;
            for (int i = 0; i < 10; i++)
            {
                driver.Navigate().GoToUrl("https://lipsum.com/");
                bll.ClickOnGenereateButtonOnHomePage();
                int count = 0;
                foreach (string paragraph in bll.GetTextFromAllParagraphsOnGenerateResultPage())
                {
                    if (paragraph.Contains("lorem"))
                    { count++; }
                }
                sumAllCounts += count;
            }

            Assert.AreEqual(3, sumAllCounts/10);           
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
