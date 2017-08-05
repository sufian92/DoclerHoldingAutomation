using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerHoldingAutomation.PageObjects
{
    class ErrorPage: DuodecaditsBasePage
    {
        
        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement Logo { get; set; }
        private PageUtils pageUtils = new PageUtils();

        public ErrorPage(IWebDriver driver) :base(driver)
        {
            PageFactory.InitElements(driver, this);
            
        }

        public String GetTitle()
        {
            return this.driver.Title;
        }

       
        public bool IsCompanyLogoPresent()
        {
            return pageUtils.IsElementPresent(this.driver, By.Id(("dh_logo")));
        }

        
    }
}
