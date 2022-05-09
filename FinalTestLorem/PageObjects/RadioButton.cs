using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestLorem.PageObjects
{
    internal class RadioButton
    {
        private IWebDriver driver;
        public void SetValue(string value)
        {
            IList<IWebElement> radioButtons = driver.FindElements(By.XPath("//table[@style='text-align:left']//tbody"));
            foreach (IWebElement radioButton in radioButtons)
            {
                if (radioButton.GetDomAttribute("value")==value)
                {
                    radioButton.Click();
                }
            }
        }

    }
}
