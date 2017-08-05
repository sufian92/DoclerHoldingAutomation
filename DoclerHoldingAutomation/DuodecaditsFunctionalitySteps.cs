using DoclerHoldingAutomation.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace DoclerHoldingAutomation
{
    [Binding]
    public class DuodecaditsFunctionalitySteps
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        
        HomePage homePage;
        FormPage formPage;
        ErrorPage errorPage;
        HelloPage helloPage;
        Dictionary<string, string> pageTitles = new Dictionary<string, string>();
        Dictionary<string, bool> pageLogos = new Dictionary<string, bool>();
        List<string> names = new List<string> { "John", "Sophia","Charlie", "Emily"};
        List<string> helloPageResults = new List<string>();

        [Given("I Navigated to \"http://uitest.duodecadits.com/\"")]
        public void GivenINavigatedToApplication()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            homePage = new HomePage(this.Driver);
            homePage.Navigate();
        }
        
        [When("I navigate to each page in the application")]
        public void WhenINavigateToEachPage()
        {
            pageTitles.Add("home page", homePage.GetTitle());
            pageLogos.Add("home page", homePage.IsCompanyLogoPresent());

            formPage = homePage.OpenFormPage();
            pageTitles.Add("form page", formPage.GetTitle());
            pageLogos.Add("form page", formPage.IsCompanyLogoPresent());

            errorPage = formPage.OpenErrorPage();
            pageTitles.Add("error page", errorPage.GetTitle());
            pageLogos.Add("error page", errorPage.IsCompanyLogoPresent());

        }

        [When("I Click on the Home button")]
        public void WhenIClickTheHomeButton()
        {
            homePage = homePage.OpenHomePage();
        }

        [When("I Click on the Form button")]
        public void WhenIClickTheFormButton()
        {
            formPage = homePage.OpenFormPage();
        }

        [When("I Click on the Error button")]
        public void WhenIClickTheErrorButton()
        {
            errorPage = homePage.OpenErrorPage();
        }

        [When("I Click on the UI Testing button")]
        public void WhenIClickTheUITestingButton()
        {
            homePage = homePage.ClickUITestingButton();
        }

        [When("i submit the form with a name")]
        public void WhenISubmitFormWithNames()
        {
            formPage = homePage.OpenFormPage();

            foreach (string name in names)
            {
                helloPage = formPage.SubmitForm(name);
                helloPageResults.Add(helloPage.GetResultText());
                formPage = helloPage.ReturnToFormPage();
            }
            formPage.driver.Close();
        }

        [Then("the title of each page should be \"UI Testing Site\"")]
        public void ThenTheTileShouldBeCorrect()
        {
            foreach (KeyValuePair<string, string> title in pageTitles)
            {
                Assert.AreEqual("UI Testing Site", title.Value ,"Title for " + title.Key + " is wrong");
            }

            errorPage.driver.Close();
        }

        [Then("the company logo must be present")]
        public void ThenTheCompanyLogoIsPresent()
        {
            foreach (KeyValuePair<string, bool> isPresent in pageLogos)
            {
                Assert.True(isPresent.Value, "Company logo for " + isPresent.Key + " is not visible");
            }

            errorPage.driver.Close();
        }

        [Then("I am redirected to the home page")]
        public void HomePageMustOpen()
        {
            Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.", homePage.GetHomePageContentText(), "Home page is not opened!");
            homePage.driver.Close();
        }
        

        [Then("the home button becomes active")]
        public void HomeButtonIsActive()
        {
            Assert.True(homePage.IsHomeTabActive(), "Home Button not active!");
            homePage.driver.Close();
        }

        [Then("I am redirected to the Form page")]
        public void FormPageMustOpen()
        {
            Assert.True(formPage.IsHelloInputPresent(), "Form page is not opened!");
            formPage.driver.Close();
        }

        [Then("the Form button becomes active")]
        public void FormButtonIsActive()
        {
            Assert.True(formPage.IsFormTabActive(), "Form Button not active!");
            homePage.driver.Close();
        }

        [Then("i get a 404 HTTP response code")]
        public void ErrorPageMustOpen()
        {
            Assert.True( errorPage.GetTitle().Contains("404 Error"), "The HTTP response code is not 404 ");
            errorPage.driver.Close();
        }

        [Then("the header of the page should be \"Welcome to the Docler Holding QA Department\"")]
        public void HomePageHeaderIsCorrect()
        {
            Assert.AreEqual("Welcome to the Docler Holding QA Department", homePage.GetHomePageHeaderText(), "Home page header is not correct!");
            homePage.driver.Close();
        }

        [Then("the content message of the page should be \"This site is dedicated to perform some exercises and demonstrate automated web testing.\"")]
        public void HomePageContentMsgIsCorrect()
        {
            Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.", homePage.GetHomePageContentText(), "Home page content message is not correct!");
            homePage.driver.Close();
        }

        [Then("the form page opens and contains one input box and one submit button")]
        public void FormPageMustContainsCorrectContent()
        {
            Assert.True(formPage.IsHelloInputPresent(), "The Input box is not visible!");
            Assert.True(formPage.IsSubmitButtonPresent(), "The Submit button is not visible!");
            Assert.True(formPage.GetNumberOfInputFields() == 1, "There is more than one input box!");
            Assert.True(formPage.GetNumberOfSubmitButtons() == 1, "There is more than one Submit button!");
            formPage.driver.Close();
        }

        [Then("the hello page appears and it contains the name i submitted along side a hello message")]
        public void HelloPageShowsCorrectResult()
        {
            Assert.AreEqual("Hello John!", helloPageResults[0], "Hello page result is wrong!");
            Assert.AreEqual("Hello Sophia!", helloPageResults[1], "Hello page result is wrong!");
            Assert.AreEqual("Hello Charlie!", helloPageResults[2], "Hello page result is wrong!");
            Assert.AreEqual("Hello Emily!", helloPageResults[3], "Hello page result is wrong!");
        }
    }
}
