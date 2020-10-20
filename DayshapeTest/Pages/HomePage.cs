using OpenQA.Selenium;
using System;

namespace DayshapeTest.Pages
{  
  public  class HomePage
    {

        //Initialise the web driver
        IWebDriver driver;
        
        public HomePage()
        {
            driver = Hooks.driver;
        }

        //Capturing UI elements for subscription, validation messages
        public IWebElement EmailTextBox => driver.FindElement(By.Id("input_2_2"));

        public IWebElement SubscribeBtn => driver.FindElement(By.Id("gform_submit_button_2"));

        public IWebElement SuccessMsg => driver.FindElement(By.CssSelector("#gform_confirmation_message_2"));

        public IWebElement ErrorValidationMsg => driver.FindElement(By.CssSelector("#validation_message_2_2"));

        public IWebElement PromptBtn => driver.FindElement(By.Id("hs-eu-confirmation-button"));


        //Actions - These are the actions performed on the page.

        //Opens the webpage,accept the prompt - Our site uses cookies to improve your experience
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://dayshape.com/");
            PromptBtn.Click();
            //Wait given for the previous action to finish
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        //To pass in the email data in the field
        public void EnterEmail(string emailAddress)
        {
            EmailTextBox.SendKeys(emailAddress);
        }

        public void ClickEmailTextBox() => EmailTextBox.Click();

        public void ClickSubscribe() => SubscribeBtn.Click();


    }
}
