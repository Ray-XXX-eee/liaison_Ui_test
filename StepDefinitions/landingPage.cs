//using LiaisonDemo.Drivers;
//using Microsoft.Playwright;
//using NUnit.Framework;

//namespace LiasonGroup_test.landingPage
//{
//    [Binding]
//    public class landingPage
//    {
//        [Given("user navigates to the website")]
//        public async Task Test() {
//            _browser = new Drivers(browserType:'chromium');
//            await page.GotoAsync("https://www.liaisongroup.com/");
//            await page.WaitForTimeoutAsync(3000);
//            var isExist = await page.Locator(selector: "text='How can we'").IsVisibleAsync();
//            Assert.IsTrue(isExist);

//        }

//    }

//}

//using System.Threading.Tasks;
//using LiaisonDemo.Drivers;
//using Microsoft.Playwright;
//using NUnit.Framework;
//using TechTalk.SpecFlow;

//namespace LiaisonDemo.Tests
//{
//    [Binding]
//    public class DriverSteps
//    {
//        private readonly Driver _driver;
//        private IBrowser _browser;

//        public DriverSteps(Driver driver)
//        {
//            _driver = driver;
//        }

//        [Given(@"I launch the browser")]
//        public async Task GivenILaunchTheBrowser()
//        {
//            _browser = await _driver.Browser;
//        }

//        [Then(@"the browser should be launched")]
//        public void ThenTheBrowserShouldBeLaunched()
//        {
//            Assert.IsNotNull(_browser);
//        }

//        [AfterScenario]
//        public async Task AfterScenarioAsync()
//        {
//            if (_browser != null)
//            {
//                await _browser.CloseAsync();
//            }
//        }
//    }
//}
