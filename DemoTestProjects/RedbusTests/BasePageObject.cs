
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RedbusTests
{
    public abstract class BasePageObject
    {
        public IWebDriver Driver { get; private set; }

        public BasePageObject(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }

        public void Dispose()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}
