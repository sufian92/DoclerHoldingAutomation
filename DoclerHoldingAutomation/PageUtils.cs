using OpenQA.Selenium;

namespace DoclerHoldingAutomation
{
    class PageUtils
    {
        public bool IsElementPresent(IWebDriver Driver,By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
