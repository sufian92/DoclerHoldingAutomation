using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DoclerHoldingAutomation.PageObjects
{
    class DuodecaditsBasePage
    {
        public readonly IWebDriver driver;
        protected readonly string url = "http://uitest.duodecadits.com/";

        [FindsBy(How = How.Id, Using = "site")]
        public IWebElement UITestingButton { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement FormButton { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        public IWebElement ErrorButton { get; set; }


        public DuodecaditsBasePage(IWebDriver browser)
        {
            this.driver = browser;
           
        }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));
        }

        public HomePage OpenHomePage()
        {
            HomeButton.Click();

            return new HomePage(this.driver);
        }

        public FormPage OpenFormPage()
        {
            FormButton.Click();

            return new FormPage(this.driver);
        }

        public ErrorPage OpenErrorPage()
        {
            ErrorButton.Click();

            return new ErrorPage(this.driver);
        }

        public HomePage ClickUITestingButton()
        {
            UITestingButton.Click();

            return new HomePage(this.driver);
        }

        public bool IsHomeTabActive()
        {
            string className = HomeButton.FindElement(By.XPath("..")).GetAttribute("class");

            if(className == "active")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFormTabActive()
        {
            string className = FormButton.FindElement(By.XPath("..")).GetAttribute("class");

            if (className == "active")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
