using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using DipakQualityGateProject.Pages;
using System.Threading;

namespace DipakQualityGateProject.Steps
{
    [Binding]
    public class IceborneSteps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private IceborneEvent iceborneEvents;

        [Scope(Feature = "Iceborne")]
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            iceborneEvents = new IceborneEvent(driver);
            homepage = new Homepage(driver);
        }

        [Given(@"I am on the Main-page")]
        public void GivenIAmOnTheMain_Page()
        {
            homepage.GoToPage();
            string expectedLink = "https://www.monsterhunterworld.com/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Given(@"I am on the iceborne homepage")]
        public void GivenIAmOnTheHomePage()
        {
            iceborneEvents.IceborneOfficalSite();
            string expectedLink = "https://www.monsterhunter.com/world-iceborne/uk/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Given(@"I click on consent messagebox")]
        public void GivenIClickOnConsentMessagebox()
        {
            homepage.MessageBox();
        }

        [Given(@"I am on the EventQuest schedule")]
        public void GivenIAmOnTheEventQuestSchedule()
        {
            iceborneEvents.EventQuest();
            string expectedLink = "http://game.capcom.com/world/uk/rank.html";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [When(@"I am on the Master Rank")]
        public void WhenIAmOnTheMasterRank()
        {
            iceborneEvents.MasterRank();
            string expectedLink = "http://game.capcom.com/world/uk/schedule-master.html";
            Assert.AreEqual(expectedLink, driver.Url);

        }

        [Then(@"I should be able to see Event Schedule date")]
        public void ThenIShouldBeAbleToSeeEventScheduleDate()
        {
            string result = iceborneEvents.MasterRankDates();
            Assert.AreEqual("10/18～11/08 (UTC+1)", result);
        }

        [Scope(Feature = "Iceborne")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }

    }
}
