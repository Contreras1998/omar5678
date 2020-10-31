using AdamGoucherParkingCalculator.Main;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdamGoucherParkingCalculator.Test
{
    class TestSuite : BaseTest
    {
        Homepage homepage = new Homepage();
        Login login = new Login();

        [Test, Ignore("this is not ready yet")]
        public void UserLogInWithValidcredentials()
        {
            login.UserSignIn();
            login.ValidateUserLoggedInWithoutaHitch();
        }

        [Test]
        public void SelectAnyShoppingCategory()
        {
            var expectedCategoryHeader = homepage.SelectAnyShoppingCategory();
            var actualCategoryHeader = GetElementTextByAttribute(homepage.headerPageText);
            Assert.AreEqual(expectedCategoryHeader, actualCategoryHeader);
        }

        [Test]
        public void SelectCategoryByAllCategoriesSelector()
        {
            var expectedText = homepage.ShopByCategoryDropdownSelector().Item1;
            var expectedCategory = homepage.ShopByCategoryDropdownSelector().Item2;
            Assert.AreEqual(expectedText, homepage.GetElementTextByAttribute(homepage.searchForBox));
            Assert.AreEqual(expectedCategory, expectedCategory.GetAttribute("textContent"));
        }

        [Test]
        public void Linq()
        {
            var cars = new Dictionary<string, string>() { {"m3 coupe", "Bmw"},
                {"m4", "Bmw" },
                {"m4 coupe", "Bmw"},
                {"m5 saloon", "Bmw" },
                {"m6", "Bmw" },
                {"m6 coupe", "Bmw" },
                {"Caymen GT5", "Porsche"},
                {"911 Gt2 RS 2019", "Porsche"},
                {"911 Gt3 RS 2016", "Porsche"},
                {"911 Gt3 RS 2019", "Porsche"},
                {"Panamera", "Porsche"},
                {"RS4 Avant 2019", "Audi"},
                {"RS6 Avant 2019", "Audi"},
                {"P1", "Maclaren"},
                {"Audi", "Maclaren"}
            };

            // Get cars models which brand is Bmw
            cars.ToList()
                .Where(x => x.Value == "Bmw")
                .ToList()
                .ForEach(x => Console.WriteLine(x.Key));
            Console.WriteLine("------------------------------------------");
            #region Get the model that do not equal bmw manufacturer
            //// Get cars models which value is not Bmw
            //cars.ToList()
            //    .Where(x => x.Value != "Bmw")
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x.Key));

            //cars.ToList()
            //    .FindAll(x => x.Value != "Bmw")
            //    .ToList()
            //    .ForEach(X => Console.WriteLine(X.Key));

            //cars.ToList()
            //    .SkipWhile(x => !(x.Value.Equals("Maclaren")))
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x.Key));
            //cars.ToList().Where(x => x.Value == "Porsche")
            //#endregion
            //public void thisisatest()
            //{

            //}

            int a;
            int b = 20;
            Console.WriteLine($"the values of a: {a}");
            Console.WriteLine($"the values of a: {b}");
            public boolean partner { get; set; };
            public partner: boolean;
            #endregion
        }
    }
}
