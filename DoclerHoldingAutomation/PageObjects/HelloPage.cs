using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerHoldingAutomation.PageObjects
{
    class HelloPage
    {
        public readonly IWebDriver driver;
        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement Logo { get; set; }
        private PageUtils pageUtils = new PageUtils();

        public HelloPage(IWebDriver browser) 
        {
            this.driver = browser;
            PageFactory.InitElements(driver, this);
            
        }

        public String GetTitle()
        {
            return this.driver.Title;
        }

        public void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));
        }

        public bool IsCompanyLogoPresent()
        {
            return pageUtils.IsElementPresent(this.driver, By.Id(("dh_logo")));
        }

        public string GetResultText()
        {
            return this.driver.FindElement(By.CssSelector(".ui-test h1")).Text;
        }

        public FormPage ReturnToFormPage()
        {
            driver.Navigate().Back();

            return new FormPage(this.driver);
        }


    }
}
