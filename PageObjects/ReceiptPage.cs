using OpenQA.Selenium;
using SeleniumSingUpForm.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSingUpForm.PageObjects
{
    public class ReceiptPage
    {
        protected IWebDriver Driver;

        //Constructor. If the title of the page isn't right throws an exception
        public ReceiptPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Thank you for signing up"))
                throw new Exception("This isn't the receipt page");
        }

        protected By Header = By.XPath("/html/body/h1");

        public bool SignupHeaderIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, Header);
        }
    }
}
