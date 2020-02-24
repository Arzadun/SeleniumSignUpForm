using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSingUpForm.Handler
{
    public class WaitHandler
    {
        //Method to wait for an present element on the page
        //return true if the element is finded in three seconds
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

                wait.Until(drv => drv.FindElement(locator));

                return true;
            }

            catch { }

            return false;
        }
    }
}
