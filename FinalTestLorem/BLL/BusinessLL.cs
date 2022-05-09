using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTestLorem.PageObjects;
using OpenQA.Selenium;

namespace FinalTestLorem.BLL
{
    internal class BusinessLL
    {
        private IWebDriver driver;
        public BusinessLL(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenUrlPage(string url)
        {
            var homePage = new HomePage(driver);
            homePage.openHomePage(url);
        }
        
        public void ChangeLanguageToRu()
        {
            var homePage = new HomePage(driver);
            homePage.ClickOnSwitchToRuLink();
        }

        public String GetTextFromHomePageParagraph()
        {
            var homePage = new HomePage(driver);
            return homePage.GetTextFromFirstParagraphOnHomePage();
        }

        public void ClickOnGenereateButtonOnHomePage()
        {
            var homePage = new HomePage(driver);
            homePage.ClickOnGenerateButton();
        }

        public String GetTextFromParagraphOnGenerateResultPage()
        {
            var generateResultPage = new GenerateResultPage(driver);
            return generateResultPage.GetTextFromFirstParagraphOnGenerateResultPage();
        }

        public void ClickOnRadioButtonWord()
        {
            var homePage = new HomePage(driver);
            homePage.ClickOnWordInput();
        }
        public void ClickOnCheckBoxOnHomePage()
        {
            var homePage = new HomePage(driver);
            homePage.ClickOnCheckBox();
        }
        public void SetValue(string value)
        {
            var homePage = new HomePage(driver);
            homePage.SetValueToAmountInput(value);
        }
        public void ClickOnRadioButtonBytes()
        {
            var homePage = new HomePage(driver);
            homePage.ClickOnBytesInput();
        }

        public List<string> GetTextFromAllParagraphsOnGenerateResultPage()
        {
            var generateResultPage = new GenerateResultPage(driver);
            return generateResultPage.GetTextFromAllParagraphsOnGenerateResultPage();
        }
    }
}
