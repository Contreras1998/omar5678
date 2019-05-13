﻿using AdamGoucherParkingCalculator.Main;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AdamGoucherParkingCalculator.Test
{
    class TestSuite : BaseTest
    {
        /* creating and putting all the page class objects at the top of the class so we can have access
        to it's functions. */
        ParkingCalculatorHomepage parkingCalculatorHomepage = new ParkingCalculatorHomepage();
        //Class1 class1 = new Class1();


        [Test, Order(1)]
        /* The purpose of this script is to test the web applicattion validating all the fields and 
           buttons avaialable in the web interface and comparing expected behaviour with actual.*/
        public void when_User_fill_all_the_Fields_Corretly_User_should_be_able_to_get_a_price()
        {          
                parkingCalculatorHomepage.user_Select_a_Lot_from_dropdown();
                parkingCalculatorHomepage.user_input_Entrytime_on_ChooseEntryDateAndTimeField("12:00");
                parkingCalculatorHomepage.user_Click_on_EntryTime_AM_Button();
                parkingCalculatorHomepage.user_Input_EntryDate_on_ChooseEntryDateandTimeField();
                parkingCalculatorHomepage.user_input_ExitTime_on_ChooseLeavingDateandTimeField("19:00");
                parkingCalculatorHomepage.user_Click_on_ExitTime_PM_RadioButton();
                parkingCalculatorHomepage.user_input_ExitDate_on_ChooseLeavingDateandTimeField();
                parkingCalculatorHomepage.user_click_on_Calculate_SubmitButton();

                // Comparing expected with actual behaviour, I want to find out if price is displayed on the screen.
                try
                {
                    bool priceIsDisplayed = verify_ElementDisplayed(parkingCalculatorHomepage._price_Displayed);
                    bool expectedResult = true;
                    Assert.AreEqual(expectedResult, priceIsDisplayed);
                }
                catch (Exception)
                {
                    Console.Write("Asserttion errored");
                }
           
        }

        /* The purpose of this script is to verify that user can specify entry and exit date by clicking 
           on the calendar icon visible and present on the Choose entry date and Leaving date fields.*/ 

        [Test, Order(2)]
        public void user_Should_be_able_to_specify_EntryAndExit_Date_By_ClickingOnCalendaryIcon_andGetPrice()
        {
            /* Each method contains the behaviour to perform the action on the browser 
            so we just need to call them. */
            parkingCalculatorHomepage.user_Select_a_Lot_from_dropdown();
            parkingCalculatorHomepage.user_input_Entrytime_on_ChooseEntryDateAndTimeField("16:00");
            parkingCalculatorHomepage.user_click_on_EntryTime_PM_RadioButton();
            parkingCalculatorHomepage.user_Click_OnEntryDate_CalendarIcon();
            parkingCalculatorHomepage.user_input_ExitTime_on_ChooseLeavingDateandTimeField("19:00");
            parkingCalculatorHomepage.user_Click_on_ExitTime_PM_RadioButton();
            parkingCalculatorHomepage.user_Click_onExitDate_CalendarIcon();

            /* Comparing results using Assert class, I am using try-catch block because the assertion 
              may faile at runtime, in order to handle the exception I am using exception handling mechanism.*/
            try
            {
                string expected_EntryDate = "5/15/2019";
                string actual_EntryDate = driver.FindElement(parkingCalculatorHomepage._entry_Date_Field).GetAttribute("value");
                Assert.AreEqual(expected_EntryDate, actual_EntryDate);
               
            }
            catch (Exception)
            {
                Console.WriteLine("Assertion failed");
            }
           
            try
            {
                string expected_ExitDate = "5/16/2019";
                string actual_ExitDate = driver.FindElement(parkingCalculatorHomepage._exit_Date_Field).GetAttribute("value");
                Assert.AreEqual(expected_ExitDate,actual_ExitDate);

            }
            catch (Exception)
            {
                Console.WriteLine("Assertion failed");
            }

            parkingCalculatorHomepage.user_click_on_Calculate_SubmitButton();

        }


        [Test,Order(3)]
        public void VerifythatWhenExitDateortimeisbeforeUserEntrydateortimeInput_SystemshoulddisplayAwarningmessage()
        {
            parkingCalculatorHomepage.userSelectShort_TermLot();
            parkingCalculatorHomepage.user_input_Entrytime_on_ChooseEntryDateAndTimeField("20:00");
            parkingCalculatorHomepage.user_click_on_EntryTime_PM_RadioButton();
            parkingCalculatorHomepage.user_Input_EntryDate_on_ChooseEntryDateandTimeField();
            parkingCalculatorHomepage.user_input_ExitTime_on_ChooseLeavingDateandTimeField("14:00");
            parkingCalculatorHomepage.user_Click_on_ExitTime_AM_Button();
            parkingCalculatorHomepage.user_input_ExitDate_on_ChooseLeavingDateandTimeField();
            parkingCalculatorHomepage.user_click_on_Calculate_SubmitButton();

            try
            {
                string expectedResult = "ERROR! YOUR EXIT DATE OR TIME IS BEFORE YOUR ENTRY DATE OR TIME";
                string actualResult = getText(parkingCalculatorHomepage._ExitDate_Before_EntryDate_WarningMessage);

                Assert.AreEqual(expectedResult, actualResult, "Assertion failed");
            }
            catch (Exception)
            {
                Console.WriteLine("Assertion failed");
            }
            
        }
    }
}