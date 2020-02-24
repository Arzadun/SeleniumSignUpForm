using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSingUpForm.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSingUpForm.TestCase
{
	[TestFixture]
    public class Test
    {
		protected IWebDriver Driver;

		[SetUp]
		//Method that opens the browser and navigate to the url
		public void BeforeTest()
		{
			Driver = new ChromeDriver();
			Driver.Navigate().GoToUrl("https://www.kimschiller.com/page-object-pattern-tutorial/");
			Driver.Manage().Window.Maximize();
		}

		[Test]
		public void SuccessfulSignUp()
		{
			SignupPage signupPage = new SignupPage(Driver);

			ReceiptPage receiptPage = signupPage.SingupAs("primer", "nombre", "calle 123", "789");
			//Assert where the expected result is that the user can singup successfuly
			Assert.IsTrue(receiptPage.SignupHeaderIsPresent());
		}

		[TearDown]
		public void AfterTest()
		{
			Driver.Quit();
		}
	}
}
