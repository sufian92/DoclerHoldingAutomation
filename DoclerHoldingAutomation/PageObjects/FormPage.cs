using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerHoldingAutomation.PageObjects
{
    class FormPage: DuodecaditsBasePage
    {
        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement InputField { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement Logo { get; set; }
        private PageUtils pageUtils = new PageUtils();

        public FormPage(IWebDriver driver) :base(driver)
        {
            PageFactory.InitElements(driver, this);
            this.WaitForPageLoad();
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

        public bool IsHelloInputPresent()
        {
            return pageUtils.IsElementPresent(this.driver, By.Id(("hello-input")));
        }

        public bool IsSubmitButtonPresent()
        {
            return pageUtils.IsElementPresent(this.driver, By.Id(("hello-submit")));
        }

        public int GetNumberOfInputFields()
        {
            return driver.FindElements(By.TagName("input")).Count();
        }

        public int GetNumberOfSubmitButtons()
        {
            return driver.FindElements(By.CssSelector(".input-group-btn button")).Count();
        }

        public HelloPage SubmitForm(string name)
        {
            InputField.Clear();
            InputField.SendKeys(name);
            SubmitButton.Click();

            return new HelloPage(driver);
        }

    }
}
