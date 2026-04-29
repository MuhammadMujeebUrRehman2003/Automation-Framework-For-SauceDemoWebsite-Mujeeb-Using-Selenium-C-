using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project.Core;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.AddToCartPage
{
    public class AddToCartPage : BasePage
    {
        private By productLBL = By.ClassName("title");
        public string GetProductTitle()
        {
            TakeScreenShot(Status.Pass, "Product Title");
            return driver.FindElement(productLBL).Text;
        }


        public void ClickInventoryProduct(string productName)
        {
            var products = driver.FindElements(By.ClassName("inventory_item_name"));

            foreach (var product in products)
            {
                if (product.Text.Trim().Equals(productName.Trim()))
                {
                    TakeScreenShot(Status.Pass, "Product Found: " + productName);
                    product.Click();
                    return; // stop loop after click
                }
            }

            TakeScreenShot(Status.Fail, "Product Not Found: " + productName);


            Thread.Sleep(5000);

            var Products = driver.FindElements(By.CssSelector("[data-test='inventory-item-name']"));
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


            Assert.IsTrue(isFound, "Product NOT found on Home Page: " + productName);
            TakeScreenShot(Status.Pass, "Assertion Passed for Product: " + productName);
        }




    }
}