using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdamGoucherParkingCalculator.Main
{
    class ParkingCalculatorHomepage : Utility
    /*The purpose of this class is to capture and perform any particular action of the 
    calculator main page. By following POM design we divide the user action into small actions so 
    later we can re-use the user actions and use them to write new scripts*/
    {
        // Storing locator at the top so other class can have access to it and achieve reusability.
        public By _choose_a_LotDropDown = By.Id("Lot");
        public By _entry_Time_Field = By.Id("EntryTime");
        public By _PM_EntryTime_RadioButton = By.XPath("//input[@name='EntryTimeAMPM' and @value='PM']");
        public By _AM_EntryTime_RadioButton = By.XPath("//input[@name='EntryTimeAMPM' and @value='AM']");
        public By _entry_Date_Field = By.Id("EntryDate");
        public By _exit_Time_Field = By.Id("ExitTime");
        public By _PM_ExitTime_RadioButton = By.XPath("//input[@name='ExitTimeAMPM' and @value='PM' ]");
        public By _AM_ExitTime_RadioButton = By.XPath("//input[@name='ExitTimeAMPM' and @value='AM' ]");
        public By _exit_Date_Field = By.Id("ExitDate");
        public By _Calculate_SubmitButton = By.XPath("//input[@value='Calculate' or @type='submit']");
        public By _price_Displayed = By.XPath("//b[starts-with(text(),'$')]");
        public By _entryDate_CalendarIcon = By.XPath("//img[@src='cal.gif']");
        public By _exitDate_CalendarIcon = By.XPath("//input[@id='ExitDate'] / following-sibling::a/img");
        public By _ExitDate_Before_EntryDate_WarningMessage = By.XPath("//b[text()='ERROR! Your Exit Date Or Time Is Before Your Entry Date or Time']");

        //this function will select Economy Parking value from the Choose a Lot drop down.
        public void user_Select_a_Lot_from_dropdown()
        {
            selectValue_ByVisibleText(_choose_a_LotDropDown,("Economy Parking"));           
        }

        // function to clear the default time and input a new time on the entry time field.
        public void user_input_Entrytime_on_ChooseEntryDateAndTimeField(String text)
        {
            clearElement(_entry_Time_Field);          
            sendKeysMethod(_entry_Time_Field,(text));           
        }

        // function to select PM radio button from the entry time field.
        public void user_click_on_EntryTime_PM_RadioButton()
        {
            clickElementMethod(_PM_EntryTime_RadioButton);
        }

        // function to input a date on the entry date field.
        public void user_Input_EntryDate_on_ChooseEntryDateandTimeField()
        {
            clearElement(_entry_Date_Field);
            sendKeysMethod(_entry_Date_Field,("05/14/2019"));
        }

        // function to input an exit time on the leaving time field.
        public void user_input_ExitTime_on_ChooseLeavingDateandTimeField(String text)
        {
            clearElement(_exit_Time_Field);
            sendKeysMethod(_exit_Time_Field,text);
        }

        // function to select PM radio button from the exit time field.
        public void user_Click_on_ExitTime_PM_RadioButton()
        {
            clickElementMethod(_PM_ExitTime_RadioButton);
        }

        //
        public void user_Click_on_EntryTime_AM_Button()
        {
            clickElementMethod(_AM_EntryTime_RadioButton);
        }
        //
        public void user_Click_on_ExitTime_AM_Button()
        {
            clickElementMethod(_AM_ExitTime_RadioButton);
        }

        // function to specify the exit date on the choose leaving date field.
        public void user_input_ExitDate_on_ChooseLeavingDateandTimeField()
        {
            clearElement(_exit_Date_Field);
            sendKeysMethod(_exit_Date_Field,("05/14/2019"));
        }

        // function to click on Calculate button, so user can get a price.
        public void user_click_on_Calculate_SubmitButton()
        {
            clickElementMethod(_Calculate_SubmitButton);
        } 

        // function to click on calendar icon from the entry date field.
        // While writting this script We need to handle windows pop pups so We need to use SwitchTo method.
        public void user_Click_OnEntryDate_CalendarIcon()
        {          
            clickElementMethod(_entryDate_CalendarIcon);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            clickElementMethod(By.XPath("//a[text()='15']"));
            driver.SwitchTo().Window(driver.WindowHandles[0]);           
        }

        /* Again we need to handle multiple windows so we need to use SwitchTo method. in this case 
           I want to specify the Exit date */
        public void user_Click_onExitDate_CalendarIcon()
        {         
            clickElementMethod(_exitDate_CalendarIcon);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            clickElementMethod(By.XPath("//a[text()='16']"));
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        // User action to click on Select a Lot dropdown and select Short-term.
        public void userSelectShort_TermLot()
        {
            selectValue_ByVisibleText(_choose_a_LotDropDown, ("Short-Term Parking"));
        }
        public void feedBoard()
        {
            Console.Write("omar");
        }

        public void customBoaard()
        {
            Console.WriteLine("Practice");
        }
    }
}
