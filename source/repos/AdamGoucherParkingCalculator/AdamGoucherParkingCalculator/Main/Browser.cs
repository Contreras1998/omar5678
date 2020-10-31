using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AdamGoucherParkingCalculator.Main
{
    public class Browser
    {
        // I am creating a class so I can select in runtime in which browser I want to execute my script.
        public static IWebDriver driver;
        String browsername = "firefox"; //The browser enviroment will depend on the value of browsername.
        String webURL = "https://www.ebay.co.uk/";
        
        public void browser_Selector()
        {
            // if browsername value is chrome then the scrit will run on Chrome browser
            if (browsername.Equals("chrome"))
            {
                driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driver.Manage().Window.Maximize();
                driver.Url = webURL;
            }
            // if the value of browsername is firefox then the script will be executed on firefox
            else if (browsername.Equals("firefox"))
            {
                driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driver.Manage().Window.Maximize();
                driver.Url = webURL;
            }
            // if the value of browsername is IE then the script will run on IE browser.
            else if (browsername.Equals("ie"))
            {
                driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driver.Manage().Window.Maximize();
                driver.Url = webURL;
            }
        }
    }
}
