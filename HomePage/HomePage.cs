using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HomePage
{
    public class HomePage : BasePage
    {
        #region locators
        public static By ProductSort = By.ClassName("product_sort_container");
        private By productLBL = By.ClassName("title");
        private By productname = By.ClassName("inventory_item_name");




        #endregion

        #region Methods


        public void SortProduct(string option)
        {
            TakeScreenShot(Status.Pass, "Sorting The Product");
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(driver.FindElement(ProductSort));
            select.SelectByText(option);
            Thread.Sleep(1000);
            TakeScreenShot(Status.Pass, "Producted Sorted");
        }

        public void productlabel(string message1)
        {
            Assert.AreEqual(message1, driver.FindElement(productLBL).Text);
            TakeScreenShot(Status.Pass, "Product Title");

            Thread.Sleep(5000);

        }

        public void VerifyHomeProduct(string productName)
        {
            TakeScreenShot(Status.Pass, "Home Page Loaded");

            string pageTitle = driver.FindElement(productLBL).Text;
            TakeScreenShot(Status.Pass, "Home Page Title: " + pageTitle);

            var products = driver.FindElements(productname);
            bool isFound = false;

            foreach (var product in products)
            {
                if (product.Text.Trim().Equals(productName.Trim()))
                {
                    TakeScreenShot(Status.Pass, "Product Found: " + productName);
                    isFound = true;
                    break;
                }
            }

            // Assertion inside HomePage
            Assert.IsTrue(isFound, "Product NOT found on Home Page: " + productName);
            TakeScreenShot(Status.Pass, "Assertion Passed for Product: " + productName);

            Thread.Sleep(5000);
        }

        public void HomeProductBTNText(string productName, string locator)
        {
            TakeScreenShot(Status.Pass, "Home Page Loaded");

            string title = driver.FindElement(productLBL).Text;
            TakeScreenShot(Status.Pass, "Home Page Title: " + title);


            Assert.AreEqual(productName, driver.FindElement(By.CssSelector(locator)).Text);

            TakeScreenShot(Status.Pass, "Assertion Passed: Button Text matches expected");

            Thread.Sleep(5000);
        }

        public void CheckremoveBTNText(string message1, string message2, string locator, string removelocator)
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

        }

        #endregion

    }
}
