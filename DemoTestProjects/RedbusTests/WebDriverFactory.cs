
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RedbusTests
{
    public class WebDriverFactory
    {
        private static IWebDriver _driver;
        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    CreateWebDriver();
                }
                return _driver;
            }
        }
        private static void CreateWebDriver()
        {
            var options = new ChromeOptions();
            //options.AddArguments("--disable-geolocation");
            options.AddArguments("--enable-strict-powerful-feature-restrictions");
            _driver = new ChromeDriver(options);
        }
    }
}
