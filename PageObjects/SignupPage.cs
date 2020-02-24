using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSingUpForm.PageObjects
{
    public class SignupPage
    {
        static void Main(string[] args)
        {

        }

        protected IWebDriver Driver;



        //Locators
        protected By FirstNameField = By.Id("firstname");
        protected By LastNameField = By.Id("lastname");
        protected By AddressField = By.Id("address");
        protected By ZipcodeField = By.Id("zipcode");
        protected By SignupButton = By.Id("signup");

        //Contructor. If the title of the page isn't right throws an exception
        public SignupPage(IWebDriver driver)

        {
            Driver = driver;
            if (!Driver.Title.Equals("Sign up"))
                throw new Exception("This isn't the sign up page");
        }
        //the following methods write the information for the form
        public void EnterFirstName(string firstname)
        {
            Driver.FindElement(FirstNameField).SendKeys(firstname);

        }
        

        public void EnterLastName(string lastname)
        {
            

            Driver.FindElement(LastNameField).SendKeys(lastname);

        }


        public void TypeAddress(string address)
        {
            Driver.FindElement(AddressField).SendKeys(address);

        }

        public void TypeZipcode(string zipcode)
        {
            Driver.FindElement(ZipcodeField).SendKeys(zipcode);
        }

        public void ClickSingupButton()
        {
            Driver.FindElement(SignupButton).Click();
        }
        
        //Fill the empty fields and return the new page
        public ReceiptPage SingupAs(string firstname, string lastname, string address, string zipcode)
        {
            EnterFirstName(firstname);
            EnterLastName(lastname);
            TypeAddress(address);
            TypeZipcode(zipcode);
            ClickSingupButton();
            return new ReceiptPage(Driver);
        }
    }
}
