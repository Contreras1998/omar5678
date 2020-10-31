using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdamGoucherParkingCalculator.Main
{
    // the purpose of this class is to gather as much as possible reusable method while creating scripts.

    public class Utility : Browser
    {
        public void ClearElement(By by)
        {
            driver.FindElement(by).Clear();
        }

        public void CustomSendKeys(By by, String text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        public void selectElementByText(By by, String text)
        {
            new SelectElement(driver.FindElement(by))
                .SelectByText(text);
        }

        public void CustomClickElement(By by)
        {
            driver.FindElement(by).Click();
        }

        public bool verify_ElementDisplayed(By by)
        {
            return driver.FindElement(by).Displayed;
        }

        public IWebElement findElement(By by)
        {
            return driver.FindElement(by);
        }

        public string GetElementTextByAttribute(By by)
        {
            return driver.FindElement(by)
                .GetAttribute("textContent");
        }

        public static int GetRandomNumber(int b)
        {
            return random.Next(0, b);
        }

        public IWebElement SelectValueAndValidate(IWebElement element, string value)
        {
            selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
            return selectElement.SelectedOption;
        }

        private static SelectElement selectElement;
        private static Random random = new Random();
    }
}
