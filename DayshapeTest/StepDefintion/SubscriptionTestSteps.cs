using DayshapeTest.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DayshapeTest.StepDefintion
{
    [Binding]
    public class SubscriptionTestSteps
    {
       //Instantiating the home page
        HomePage homePage;
        public SubscriptionTestSteps()
        {
            homePage = new HomePage();
        }

        //Opening the dayshape page 
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            homePage.OpenHomePage();
        }
        
        //Entering valid email addresss for subscription in the textbox
        [Given(@"I enter a valid email address for subscription")]
        public void GivenIEnterAValidEmailAddressForSubscription()
        {
            homePage.ClickEmailTextBox();
            homePage.EnterEmail("test@gmail.com");
        }
        
        //Validating subscribe button is displayed and user can click
        [When(@"I click on the subscribe button")]
        public void WhenIClickOnTheSubscribeButton()
        {
            Assert.IsTrue(homePage.SubscribeBtn.Displayed);
            homePage.ClickSubscribe();
        }
        
        //Validating subscription is successful
        [Then(@"I see a successful message")]
        public void ThenISeeASuccessfulMessage()
        {
            Assert.IsTrue(homePage.SuccessMsg.Displayed);
            string expectedText = "Thanks for subscribing! Please check your inbox for your first edition.";
            string text = homePage.SuccessMsg.Text;
            Assert.AreEqual(text, expectedText);
        }

        //Entering invalid email for subscription
        [Given(@"I enter an invalid email address for subscription")]
        public void GivenIEnterAnInvalidEmailAddressForSubscription()
        {
            homePage.ClickEmailTextBox();
            homePage.EnterEmail("test");
        }

        //Validating error displayed for invalid email id 
        [Then(@"I see an error message")]
        public void ThenISeeAnErrorMessage()
        {
            Assert.IsTrue(homePage.ErrorValidationMsg.Displayed);
            string expectedText = "Please enter a valid email address.";
            string text = homePage.ErrorValidationMsg.Text;
            Assert.AreEqual(text, expectedText);
        }

        //Entering empty string for email id
        [Given(@"I don't enter any email address")]
        public void GivenIDonTEnterAnyEmailAddress()
        {
            homePage.ClickEmailTextBox();
            homePage.EnterEmail("");

        }

        //Validating error for empty string and also whether the message is displayed.
        [Then(@"I see an empty field validation message")]
        public void ThenISeeAnEmptyFieldValidationMessage()
        {
            Assert.IsTrue(homePage.ErrorValidationMsg.Displayed);
            string expectedText = "At least one field must be filled out";
            string text = homePage.ErrorValidationMsg.Text;
            Assert.AreEqual(text, expectedText);
        }


    }
}
