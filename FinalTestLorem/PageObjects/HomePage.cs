using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestLorem.PageObjects
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver) { 
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How =How.XPath, Using = "//a[@href='http://ru.lipsum.com/']")]
        private IWebElement switchToRuLink;


        [FindsBy(How = How.XPath, Using = "//div[@id='Panes']/div[1]/p")]
        private IWebElement firstParagrathOnHomePage;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement generateButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='words']")]
        private IWebElement wordsInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='amount']")]
        private IWebElement amountInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='bytes']")]
        private IWebElement bytesInput;

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement checkBoxInput;

        public void openHomePage(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickOnSwitchToRuLink()
        {
            switchToRuLink.Click();
        }

        public String GetTextFromFirstParagraphOnHomePage()
        {
            return firstParagrathOnHomePage.Text;
        }

        public void ClickOnGenerateButton()
        {
            generateButton.Click();
        }

        public void ClickOnWordInput()
        {
            wordsInput.Click();
        }

        public void SetValueToAmountInput(string value)
        {
            amountInput.Clear();
            amountInput.SendKeys(value);
        }

        public void ClickOnBytesInput()
        {
            bytesInput.Click();
        }

        public void ClickOnCheckBox()
        {
            checkBoxInput.Click();
        }

    }
}
