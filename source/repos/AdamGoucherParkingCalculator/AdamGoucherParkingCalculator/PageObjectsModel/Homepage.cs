using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdamGoucherParkingCalculator.Main
{
    public class Homepage : Utility
    {
        #region Public Methods
        public string SelectAnyShoppingCategory()
        {
            CustomClickElement(shopByCategoryBtn);
            return ShopByCategoryLink();
        }

        public Tuple<string, IWebElement> ShopByCategoryDropdownSelector()
        {
            var randomCategory = AllCategoriesSelectorValues
                .ElementAt(GetRandomNumber(AllCategoriesSelectorValues.Count)).Value;
            CustomClickElement(categoriesDropdownSelector);
            var categorySelected = SelectValueAndValidate(findElement(categoriesDropdownSelector), randomCategory);
            CustomSendKeys(searchForBox, "cars");
            return new Tuple<string, IWebElement>("cars", categorySelected);
        }
        #endregion

        private string ShopByCategoryLink()
        {
            var randomCategory = CategoryLinks.ElementAt(GetRandomNumber(CategoryLinks.Count)).Value;
            CustomClickElement(By.XPath("//a[@href='https://www.ebay.co.uk/" + randomCategory));
            return CategoryLinks
                .ToList()
                .Find(category => category.Value == randomCategory).Key;
        }

        #region Public Menbers
        public static Dictionary<string, string> CategoryLinks = new Dictionary<string, string>() { { "Collectables", "rpp/collectables']" },
            { "Sports Memorabilia", "rpp/sports-memorabilia']" },
            { "Coins, Banknotes & Bullion", "rpp/coins']"},
            { "Mobile phones", "rpp/mobile-home-phone']"} };
        public static Dictionary<string, string> AllCategoriesSelectorValues = new Dictionary<string, string>() { { "2984", "Baby" },
            { "12576", "Business, Office & Industrial" },
            { "625", "Cameras & Photography"},
            { "9800", "Cars, Motorcycles & Vehicles"},
            { "58058", "Computers/Tablets & Networking"},
            { "3252", "Holidays & Travel"} };

        public By categoriesDropdownSelector = By.Id("gh-cat");
        public By shopByCategoryBtn = By.Id("gh-shop-a");
        public By searchForBox = By.Id("gh-ac");
        public By headerPageText = By.XPath("//h1[@class='b-pageheader']"); 
        #endregion
    }
}
