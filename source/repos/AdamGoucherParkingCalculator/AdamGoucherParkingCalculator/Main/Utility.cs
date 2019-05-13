using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdamGoucherParkingCalculator.Main
{
    // the purpose of this class is to gather as much as possible reusable method while creating scripts.

    public class Utility : BasePage
    {
        // clear reusable method, If I want to clear a field I just need to pass the locator as parameter.
        public void clearElement(By by)
        {
            driver.FindElement(by).Clear();
        }

        /* Method to input a text on any text field, while calling this function 
           we need to pass the locator and the text we want to input on the field. */
        public void sendKeysMethod(By by, String text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        // Method to select a value from a dropdown by visible text.
        public void selectValue_ByVisibleText(By by, String text)
        {
            IWebElement element = driver.FindElement(by);
            var selectTest = new SelectElement(element);
            selectTest.SelectByText(text);
        }

        // Reusable method to click on an element.
        public void clickElementMethod(By by)
        {
            driver.FindElement(by).Click();
        }

        // Reusable method to find out if element is displayed or present. 
        public bool verify_ElementDisplayed(By by)
        {
            bool element = driver.FindElement(by).Displayed;
            return element;
        }

        // Method to avoid the need of writting driver.findElement all the time in my script.
        public void findElement(By by)
        {
            driver.FindElement(by);
        }

        // function to retrieve a text from the webpage.
        public string getText(By by)
        {
            string text = driver.FindElement(by).Text; 
            return text;
        }


    }
}
