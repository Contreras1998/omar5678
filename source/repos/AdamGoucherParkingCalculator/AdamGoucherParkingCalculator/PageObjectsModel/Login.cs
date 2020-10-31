using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdamGoucherParkingCalculator.Main
{
    public class Login : Utility            
    {
        By userIdTextBox = By.Id("userid");
        By userPasswordTextBox = By.Id("pass");
        By signInBtn = By.Id("sgnBt");
        By userAccountBtn = By.XPath("//button[@id='gh-ug']");

        #region User Actions
        public void UserSignIn()
        {
            CustomSendKeys(userIdTextBox, "oandreu.14@gmail.com");
            CustomSendKeys(userPasswordTextBox, "andresD1411");
            CustomClickElement(signInBtn);
        }
        #endregion

        #region Login Validations
        public void ValidateUserLoggedInWithoutaHitch()
        {
            var expectedUserMessage = GetElementTextByAttribute(userAccountBtn);
            Assert.AreEqual(expectedUserMessage, "Hello Omar Andres");
        }
        #endregion
    }
}
