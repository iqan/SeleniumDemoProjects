using NUnit.Framework;
using System;

namespace RedbusTests
{
    [TestFixture]
    public class TestClass
    {
        HomePageObject homePageObj;

        [SetUp]
        public void Init()
        {
            homePageObj = new HomePageObject(WebDriverFactory.Driver);
        }

        [Test]
        public void SearchBusMethod()
        {
            homePageObj.GoToRedBus();

            homePageObj.SearchBus("Ahmedabad", "Pune", DateTime.Now.Day.ToString());
            
        }

        [TearDown]
        public void Tear()
        {
            homePageObj.Dispose();
        }
    }
}
