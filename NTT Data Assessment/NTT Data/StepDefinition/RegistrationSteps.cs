using NTT_Data.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NTT_Data.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

            [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            registrationPage.NavigateToWebsite(url);
        }

        [Given(@"I Enter a first name ""(.*)""")]
        public void GivenIEnterAFirstName(string first)
        {
            registrationPage.EnterFirstName(first);
        }

        [Given(@"I Enter a last name ""(.*)""")]
        public void GivenIEnterALastName(string last)
        {
            registrationPage.EnterLastName(last);
        }

        [Given(@"I Enter my email ""(.*)""")]
        public void GivenIEnterMyEmail(string mail)
        {
            registrationPage.EnterEmailAddress(mail);
        }


        [Given(@"I Select male as gender")]
        public void GivenISelectMaleAsGender()
        {
            registrationPage.ClickMaleGender();
        }


        [Given(@"I Select female as gender")]
        public void GivenISelectFemaleAsGender()
        {
            registrationPage.ClickFemaleGender();
        }


        [Given(@"I Enter my mobile number ""(.*)""")]
        public void GivenIEnterMyMobileNumber(string number)
        {
            registrationPage.EnterMobileNumber(number);
        }

        [When(@"I Click submit")]
        public void WhenIClickSubmit()
        {
            registrationPage.ClickSubmitButton();
        }

        [Then(@"I Should see a pop up showing all information that was sent")]
        public void ThenIShouldSeeAPopUpShowingAllInformationThatWasSent()
        {
            //registrationPage.IsPopUpDisplayed();
            Assert.IsTrue(registrationPage.IsPopUpDisplayed(), "Thanks for submitting the form");
        }


        [Then(@"I Should not see the pop up message and error is displayed")]
        public void ThenIShouldNotSeeThePopUpMessageAndErrorIsDisplayed()
        {
            Assert.False(registrationPage.IsPopUpDisplayed());
        }

    }
}

