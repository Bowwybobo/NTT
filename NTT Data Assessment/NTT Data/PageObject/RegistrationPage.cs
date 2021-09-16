using NTT_Data.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTT_Data.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement firstName => driver.FindElement(By.XPath("//*[@id='firstName']"));

        IWebElement lastName => driver.FindElement(By.CssSelector("#lastName"));

        IWebElement email => driver.FindElement(By.XPath("//*[@id='userEmail']"));

        IWebElement genderMale => driver.FindElement(By.XPath("//label[text()='Male']"));

        IWebElement genderFemale => driver.FindElement(By.XPath("//label[text()='Female']"));

        IWebElement mobile => driver.FindElement(By.CssSelector("#userNumber"));

        IWebElement submit => driver.FindElement(By.XPath("//button[text()='Submit']"));

        IWebElement popUp => driver.FindElement(By.XPath("//div[text()='Thanks for submitting the form']"));





        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void EnterFirstName(string first)
        {
            firstName.SendKeys(first);
        }


        public void EnterLastName(string last)
        {
            lastName.SendKeys(last);
        }


        public void EnterEmailAddress(string mail)
        {
            email.SendKeys(mail);
        }


        public void ClickMaleGender()
        {
            genderMale.Click();
        }


        public void ClickFemaleGender()
        {
            genderFemale.Click();
        }

        public void EnterMobileNumber(string number)
        {
            mobile.SendKeys(number);
        }


        public void ClickSubmitButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            submit.Click();
        }


        public bool IsPopUpDisplayed()
        {
            return popUp.Displayed;
        }





        }

    }    
