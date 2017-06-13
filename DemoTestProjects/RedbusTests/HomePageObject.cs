
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RedbusTests
{
    public class HomePageObject : BasePageObject
    {
        public HomePageObject(IWebDriver driver) : base(driver) { }

        #region Elements
        [FindsBy(How = How.Id, Using = "src")]
        public IWebElement FromCity { get; set; }

        [FindsBy(How = How.Id, Using = "dest")]
        public IWebElement ToCity { get; set; }

        [FindsBy(How = How.Id, Using = "onward_cal")]
        public IWebElement OnwardsLabel { get; set; }

        [FindsBy(How = How.Id, Using = "rb-calendar_onward_cal")]
        public IWebElement OnwardsDateDiv { get; set; }

        [FindsBy(How = How.Id, Using = "search_btn")]
        public IWebElement Search { get; set; }
        #endregion

        public void GoToRedBus()
        {
            Driver.Url = "https://www.redbus.in";
        }
        public void SearchBus(string fromCity, string toCity, string onwardsDate)
        {
            // select from address
            FromCity.SendKeys(fromCity);
            FromCity.SendKeys(Keys.Enter);

            // select to address
            ToCity.SendKeys(toCity);
            ToCity.SendKeys(Keys.Enter);

            // set onwards date
            //OnwardsLabel.Click(); // not needed as pervious field enter key will open this up
            System.Threading.Thread.Sleep(1000);

            //OnwardsDateDiv.Click();
            var path = string.Format("//*[@id='rb-calendar_onward_cal']/table/tbody/tr/td[text()='{0}']", onwardsDate);
            var onwardsDateElement = OnwardsDateDiv.FindElement(By.XPath(path));
            
            onwardsDateElement.Click();

            // search
            Search.Click();
        }
    }
}
