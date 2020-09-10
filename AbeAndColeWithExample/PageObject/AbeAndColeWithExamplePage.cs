using AbeAndColeWithExample.Utilities;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AbeAndColeWithExample.PageObject
{
    class AbeAndColeWithExamplePage
    { IWebDriver driver;
        public AbeAndColeWithExamplePage()
        {
            driver = Hooks1.driver;
            // Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        IWebElement acceptCookie => driver.FindElement(By.XPath("//button[@id='ccc-notify-accept']"));
        IWebElement selectTitle => driver.FindElement(By.XPath("(//div[text()='Miss'])[2]"));
        IWebElement dropDownArrow => driver.FindElement(By.XPath("(//span[@class='Dropdown-arrow'])[1]"));
        IWebElement firstName => driver.FindElement(By.XPath("//input[@name='FirstName']"));
        IWebElement lastName => driver.FindElement(By.XPath("//*[@name='LastName']"));
        IWebElement emailAddress => driver.FindElement(By.XPath("//*[@name='EmailAddress']"));
        IWebElement password => driver.FindElement(By.XPath("//*[@name='Password']"));
        IWebElement postCode => driver.FindElement(By.XPath("//input[@name='Postcode']"));
        IWebElement findAddress => driver.FindElement(By.XPath("//input[@name='findAddress']"));
        IWebElement dropDown => driver.FindElement(By.XPath("(//span[@class='Dropdown-arrow'])[2]"));
        IWebElement address => driver.FindElement(By.XPath("//div[text()='5 Rippolson Road, London']"));
        IWebElement leaveBox => driver.FindElement(By.XPath("//textarea[@name='DeliveryNotes']"));
        IWebElement contactNumber => driver.FindElement(By.XPath("//input[@name='Telephone']"));
        IWebElement arrowDown => driver.FindElement(By.XPath("(//span[@class='Dropdown-arrow'])[3]"));
        IWebElement hearAboutUs => driver.FindElement(By.XPath("//div[text()='Saw your van']"));
        IWebElement Vegetarian => driver.FindElement(By.XPath("//*[@id='signUpForm']/div/div[6]/label[1]/i"));
        IWebElement hearNews => driver.FindElement(By.XPath("//*[@id='signUpForm']/div/div[7]/div/div[1]/label[2]/i"));
        IWebElement completeSignUp => driver.FindElement(By.XPath("//input[@value='Complete sign up']"));
        IWebElement isAccountDisplayed => driver.FindElement(By.XPath("//*[@id='my-account']/a/div"));









        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://www.abelandcole.co.uk/SignUp");
        }

        public void ClickOnAcceptCookie()
        {
            acceptCookie.Click();
        }

        public void ClickOnTitle()
        {
            Thread.Sleep(5000);
            //selectTitle.Click();
            // Actions mouseHover = new Actions(driver);
            // mouseHover.MoveToElement(driver.FindElement(By.XPath("(//div[text()='Miss'])[2]"))).Perform();
            // selectTitle.Click();
            //driver.FindElement(By.XPath("//*[@id='signUpForm']/div/div[1]/div[2]/div[1]/div[2]/div[2]"));
            //driver.FindElement(By.XPath("//*[@id='signUpForm']/div/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]")).Click();
        }

        public void ClickOnDropDownArrow()
        {
            dropDownArrow.Click();
        }

        public void EnterFirstName(string Firstname)
        {
            firstName.SendKeys(Firstname);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            firstName.SendKeys(Firstname + randomInt);


        }

        public void EnterLastName(string Lastname)
        {
            lastName.SendKeys(Lastname);
        }

        public void EnterEmailAddress(string Email)
        {
            //emailAddress.SendKeys(Email);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailAddress.SendKeys(Email + randomInt + "@gmail.com");
        }

        public void EnterPassword(string Password)
        {
            password.SendKeys(Password);
        }

        public void EnterPostCode(string Postcode)
        {
            postCode.SendKeys(Postcode);
        }

        public void ClickOnFindAddress()
        {
            findAddress.Click();
        }

        public void ClickOnDropDown()
        {
            dropDown.Click();
        }

        public void ClickOnAddress()
        {
            address.Click();
        }

        public void EnterLeaveBox(string Porch)
        {
            leaveBox.SendKeys(Porch);
        }

        public void EnterContactNumber(string Contactnumber)
        {
            contactNumber.SendKeys(Contactnumber);
        }

        public void ClickOnArrowDown()
        {
            arrowDown.Click();
        }

        public void ClickOnHearAboutUs()
        {
            hearAboutUs.Click();
        }

        public void ClickOnVegetarian()
        {
            Vegetarian.Click();
        }

        public void ClickOnHearNews()
        {
            hearNews.Click();
        }

        public void ClickOnCompleteSignUp()
        {
            completeSignUp.Click();
        }

        public bool IsAccountDisplayed()
        {
            return isAccountDisplayed.Displayed;
        }
































        
    }

}
