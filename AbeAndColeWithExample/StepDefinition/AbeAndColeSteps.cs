using AbeAndColeWithExample.PageObject;
using AbeAndColeWithExample.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AbeAndColeWithExample.StepDefinition
{
    [Binding]
    public class AbeAndColeSteps
    {
        AbeAndColeWithExamplePage abeAndColeWithExamplePage;
        IWebDriver driver;
        public AbeAndColeSteps()
        {
            abeAndColeWithExamplePage = new AbeAndColeWithExamplePage();
            driver = Hooks1.driver;
        }
        

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            abeAndColeWithExamplePage.NavigateToForm();
        }

        [When(@"I enter first name ""(.*)""")]
        public void WhenIEnterFirstName(string Firstname)
        {
            abeAndColeWithExamplePage.EnterFirstName(Firstname);
        }


        [When(@"I enter last name ""(.*)""")]
        public void WhenIEnterLastName(string Lastname)
        {
            abeAndColeWithExamplePage.EnterLastName(Lastname);
        }
        
        [When(@"I enter email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string Email)
        {
            abeAndColeWithExamplePage.EnterEmailAddress(Email);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string Password)
        {
            abeAndColeWithExamplePage.EnterPassword(Password);
        }
        
        [When(@"I enter postcode ""(.*)""")]
        public void WhenIEnterPostcode(string Postcode)
        {
            abeAndColeWithExamplePage.EnterPostCode(Postcode);
        }
        
        [When(@"I click on find address")]
        public void WhenIClickOnFindAddress()
        {
            abeAndColeWithExamplePage.ClickOnFindAddress();
        }
        
        [When(@"I select from the drop down")]
        public void WhenISelectFromTheDropDown()
        {
            abeAndColeWithExamplePage.ClickOnDropDown();
        }

        [When(@"I select Address from drop down arrow")]
        public void WhenISelectAddressFromDropDownArrow()
        {
            abeAndColeWithExamplePage.ClickOnAddress();
        }


        [When(@"I enter where to leave box ""(.*)""")]
        public void WhenIEnterWhereToLeaveBox(string Porch)
        {
            abeAndColeWithExamplePage.EnterLeaveBox(Porch);
        }
        
        [When(@"I enter contact number ""(.*)""")]
        public void WhenIEnterContactNumber(string Contactnumber)
        {
            abeAndColeWithExamplePage.EnterContactNumber(Contactnumber);
        }

        [When(@"I click on the drop downarrow")]
        public void WhenIClickOnTheDropDownarrow()
        {
            abeAndColeWithExamplePage.ClickOnArrowDown();
        }


        [When(@"I click on how did you hear about us")]
        public void WhenIClickOnHowDidYouHearAboutUs()
        {
            abeAndColeWithExamplePage.ClickOnHearAboutUs();
        }
        
        [When(@"I click on vegetarian box")]
        public void WhenIClickOnVegetarianBox()
        {
            abeAndColeWithExamplePage.ClickOnVegetarian();
        }

        [When(@"I click on hear news from us")]
        public void WhenIClickOnHearNewsFromUs()
        {
            abeAndColeWithExamplePage.ClickOnHearNews();
        }


        [When(@"I Accept cookies")]
        public void WhenIAcceptCookies()
        {
            abeAndColeWithExamplePage.ClickOnAcceptCookie();
        }

        [When(@"I click on dropdown")]
        public void WhenIClickOnDropdown()
        {
            abeAndColeWithExamplePage.ClickOnDropDownArrow();
            
        }


        [When(@"I click on title")]
        public void WhenIClickOnTitle()
        {
            // abeAndColeWithExamplePage.ClickOnTitle();
            driver.FindElement(By.XPath("//*[@id='signUpForm']/div/div[1]/div[2]/div[1]/div[2]/div[2]"));
            driver.FindElement(By.XPath("//*[@id='signUpForm']/div/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]")).Click();
        }

        [When(@"I click on complete sign up")]
        public void WhenIClickOnCompleteSignUp()
        {
            abeAndColeWithExamplePage.ClickOnCompleteSignUp();
        }
        
        [Then(@"I am logged in with account showing")]
        public void ThenIAmLoggedInWithAccountShowing()
        {
            Assert.That(abeAndColeWithExamplePage.IsAccountDisplayed);
        }





    }
}
