using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestLorem.PageObjectsBBC
{
    internal class HomePageBBC
    {
        private IWebDriver driver;

        public HomePageBBC(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       [FindsBy(How = How.XPath, Using = "//nav[@class='orbit-header-links international']//li[@class='orb-nav-newsdotcom']/a[@href='https://www.bbc.com/news']")]
        private IWebElement newsButton;


        public void openHomePageBBC(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnNewsButton()
        {
            newsButton.Click();
        }

       
    }
}
