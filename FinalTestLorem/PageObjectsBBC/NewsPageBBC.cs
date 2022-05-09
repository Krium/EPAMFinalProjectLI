using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestLorem.PageObjectsBBC
{
    internal class NewsPageBBC
    {
        private IWebDriver driver;

        public NewsPageBBC(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//h3[@class='gs-c-promo-heading__title gel-paragon-bold nw-o-link-split__text']")]
        private IWebElement headTitleText;

        public String GetHeadTitleText()
        {
            return headTitleText.Text;
        }
    }
}
