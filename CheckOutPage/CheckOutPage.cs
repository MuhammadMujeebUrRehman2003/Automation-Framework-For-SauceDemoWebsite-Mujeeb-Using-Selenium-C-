using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using Project.Core;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project.CheckOutPage
{
    public class CheckOutPage : BasePage
    {
        private By productLBL = By.ClassName("title");
        private By cartIcon = By.CssSelector("[data-test='shopping-cart-link']");
        private By cartIcondescription = By.CssSelector("[data-test='title']");
        private By Checkoutproduct = By.Id("checkout");
        private By continueshoping = By.Id("continue-shopping");
        private By cancelproduct = By.Id("cancel");
        private By Checkoutproducttitle = By.CssSelector("[data-test='title']");
        private By Firstname = By.Id("first-name");
        private By Lastname = By.Id("last-name");
        private By postalcode = By.Id("postal-code");
        private By ContinueBTN = By.Id("continue");
        private By FinishBTN = By.Id("finish");
        private By BackToHomeBTN = By.Id("back-to-products");
        private By Nofirstname = By.CssSelector("[data-test='error']");
        private By Nolastname = By.CssSelector("[data-test='error']");
        private By Nopostalcode = By.CssSelector("[data-test='error']");


        public void VisitCartIconPage(string locator, string message1, string removelocator, string message2, string message3)
        {
            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");

            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(By.CssSelector(removelocator)).Text);
            TakeScreenShot(Status.Pass, "Remove Add To Cart Button Text");

            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

        }




        public void GetHOMEAddtoCartIconDescription(string locator, string message1, string removelocator, string message2, string message3)
        {
            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");

            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(By.CssSelector(removelocator)).Text);
            TakeScreenShot(Status.Pass, "Remove Add To Cart Button Text");

            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(removelocator)).Click();
            TakeScreenShot(Status.Pass, "Click On Remove to Remove Add To Cart Button Text");


            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

        }



        public void Continueshopping(string locator, string message1, string message2)
        {


            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);


            TakeScreenShot(Status.Pass, "Click On Continue Button");
            driver.FindElement(continueshoping).Click();


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(productLBL).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

        }




        public void Cancelproduct(string locator, string message1, string message2, string message3)
        {


            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

            Thread.Sleep(5000);

            driver.FindElement(Checkoutproduct).Click();
            TakeScreenShot(Status.Pass, "Click On Checkout Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(Checkoutproducttitle).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

            Thread.Sleep(5000);


            TakeScreenShot(Status.Pass, "Click On cancel Button");
            driver.FindElement(cancelproduct).Click();


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

        }



        public void finishwithorder(string locator, string message1, string message2, string message3, string firstName, string lastName, string code, string message4)
        {


            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

            Thread.Sleep(5000);

            driver.FindElement(Checkoutproduct).Click();
            TakeScreenShot(Status.Pass, "Click On Checkout Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(Checkoutproducttitle).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Enter First Name");
            driver.FindElement(Firstname).SendKeys(firstName);

            TakeScreenShot(Status.Pass, "Enter Last Name");
            driver.FindElement(Lastname).SendKeys(lastName);

            TakeScreenShot(Status.Pass, "Enter Postal Code");
            driver.FindElement(postalcode).SendKeys(code);


            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Continue Button");
            driver.FindElement(ContinueBTN).Click();

            Thread.Sleep(5000);


            TakeScreenShot(Status.Pass, "Click On Finish Button");
            driver.FindElement(FinishBTN).Click();

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Back To Home Button");
            driver.FindElement(BackToHomeBTN).Click();


            Thread.Sleep(5000);

            Assert.AreEqual(message4, driver.FindElement(productLBL).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

        }



        public void finishwithnoorder(string locator, string removelocator, string message1, string message2, string message3, string firstName, string lastName, string code, string message4)
        {


            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);


            driver.FindElement(By.CssSelector(removelocator)).Click();
            TakeScreenShot(Status.Pass, "Click On Remove Button Text");


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

            Thread.Sleep(5000);

            driver.FindElement(Checkoutproduct).Click();
            TakeScreenShot(Status.Pass, "Click On Checkout Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(Checkoutproducttitle).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Enter First Name");
            driver.FindElement(Firstname).SendKeys(firstName);

            TakeScreenShot(Status.Pass, "Enter Last Name");
            driver.FindElement(Lastname).SendKeys(lastName);

            TakeScreenShot(Status.Pass, "Enter Postal Code");
            driver.FindElement(postalcode).SendKeys(code);


            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Continue Button");
            driver.FindElement(ContinueBTN).Click();

            Thread.Sleep(5000);


            TakeScreenShot(Status.Pass, "Click On Finish Button");
            driver.FindElement(FinishBTN).Click();

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Back To Home Button");
            driver.FindElement(BackToHomeBTN).Click();


            Thread.Sleep(5000);

            Assert.AreEqual(message4, driver.FindElement(productLBL).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

        }


        public void Checkouttheproductwithnofirstname(string locator, string message1, string message2, string message3, string firstName, string lastName, string code, string message4)
        {

            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

            Thread.Sleep(5000);

            driver.FindElement(Checkoutproduct).Click();
            TakeScreenShot(Status.Pass, "Click On Checkout Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(Checkoutproducttitle).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Enter First Name");
            driver.FindElement(Firstname).SendKeys(firstName);

            TakeScreenShot(Status.Pass, "Enter Last Name");
            driver.FindElement(Lastname).SendKeys(lastName);

            TakeScreenShot(Status.Pass, "Enter Postal Code");
            driver.FindElement(postalcode).SendKeys(code);


            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Continue Button");
            driver.FindElement(ContinueBTN).Click();



            Thread.Sleep(5000);

            Assert.AreEqual(message4, driver.FindElement(Nofirstname).Text);
            TakeScreenShot(Status.Pass, "Checkout Without First Name");
        }




        public void Checkouttheproductwithnolastname(string locator, string message1, string message2, string message3, string firstName, string lastName, string code, string message4)
        {

            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

            Thread.Sleep(5000);

            driver.FindElement(Checkoutproduct).Click();
            TakeScreenShot(Status.Pass, "Click On Checkout Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(Checkoutproducttitle).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Enter First Name");
            driver.FindElement(Firstname).SendKeys(firstName);

            TakeScreenShot(Status.Pass, "Enter Last Name");
            driver.FindElement(Lastname).SendKeys(lastName);

            TakeScreenShot(Status.Pass, "Enter Postal Code");
            driver.FindElement(postalcode).SendKeys(code);


            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Continue Button");
            driver.FindElement(ContinueBTN).Click();



            Thread.Sleep(5000);

            Assert.AreEqual(message4, driver.FindElement(Nolastname).Text);
            TakeScreenShot(Status.Pass, "Checkout Without Last Name");
        }





        public void Checkouttheproductwithnopostalcode(string locator, string message1, string message2, string message3, string firstName, string lastName, string code, string message4)
        {

            Assert.AreEqual(message1, driver.FindElement(By.CssSelector(locator)).Text);
            TakeScreenShot(Status.Pass, "Add To Cart Button Text");

            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click On Add To Cart Button Text");



            Thread.Sleep(5000);


            driver.FindElement(cartIcon).Click();
            TakeScreenShot(Status.Pass, "Cart Icon Click");


            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(cartIcondescription).Text);
            TakeScreenShot(Status.Pass, "Cart Icon Description");

            Thread.Sleep(5000);

            driver.FindElement(Checkoutproduct).Click();
            TakeScreenShot(Status.Pass, "Click On Checkout Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(Checkoutproducttitle).Text);
            TakeScreenShot(Status.Pass, "Check the Checkout Product Title");

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Enter First Name");
            driver.FindElement(Firstname).SendKeys(firstName);

            TakeScreenShot(Status.Pass, "Enter Last Name");
            driver.FindElement(Lastname).SendKeys(lastName);

            TakeScreenShot(Status.Pass, "Enter Postal Code");
            driver.FindElement(postalcode).SendKeys(code);


            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Click On Continue Button");
            driver.FindElement(ContinueBTN).Click();



            Thread.Sleep(5000);

            Assert.AreEqual(message4, driver.FindElement(Nopostalcode).Text);
            TakeScreenShot(Status.Pass, "Checkout Without Postal Code");
        }

    }
}
