using AdamGoucherParkingCalculator.Main;
using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using System.IO;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Threading;
using NUnit.Framework;

namespace AdamGoucherParkingCalculator.Test
{
    [TestFixture]
    public class BaseTest : Utility
    {
       
        // I am creating an object of Selector class so I can pass the value of browser here.
        // if browser == chrome then the block of code inside that method will be executed here.

        BrowserSelector selector = new BrowserSelector();

        [SetUp]
        public void set_Up()
        {
           
            selector.browser_Selector();
        }
        

        

        [TearDown]
        public void tear_Down()
        {
            driver.Quit();
        }

    }
}
