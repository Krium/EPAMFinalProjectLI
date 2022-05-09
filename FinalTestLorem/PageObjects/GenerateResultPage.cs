using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestLorem.PageObjects
{
    internal class GenerateResultPage
    {
        private IWebDriver driver;

        public GenerateResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']//p[1]")]
        private IWebElement firstParagraphOnGenerateResultPage;

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']//p")]
        private IList <IWebElement> allParagraphsOnGenereateResultPage;

        public String GetTextFromFirstParagraphOnGenerateResultPage()
        {
            return firstParagraphOnGenerateResultPage.Text;
        }
        
        public List<string> GetTextFromAllParagraphsOnGenerateResultPage()
        {
            return new List<string>(allParagraphsOnGenereateResultPage.Select(x => x.Text));
        }
    }
}
