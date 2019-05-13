using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdamGoucherParkingCalculator
{
   public class BasePage
    {
        /* Initialising IWebdriver reference variable so we can use the variable to execute
           the script on multiple browsers without the need of creating again the reference
           variable of Iwebdriver */
        public static IWebDriver driver;
    }
}
