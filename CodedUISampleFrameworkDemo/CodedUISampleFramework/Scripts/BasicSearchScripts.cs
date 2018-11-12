using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using CodedUISampleFramework.Library;
using CodedUISampleFramework.UIMaps;
using CodedUISampleFramework.Config;

namespace CodedUISampleFramework.Scripts
{
    /// <summary>
    /// Summary description for BasicSearchScripts
    /// </summary>
    [CodedUITest]
    public class BasicSearchScripts : BingScriptsBase
    {
        public BasicSearchScripts()
        {      
        }

        #region TestInitialize
        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public override void MyTestInitialize()
        {
            Console.WriteLine("Initialize");
            base.MyTestInitialize();
            //BrowserWindow.CurrentBrowser = "Chrome";
            
        }
        #endregion

        #region Scripts
        [Description("This test will search many search strings")]
        [Owner("Viswa")]
        [Priority(0)]
        [TestProperty("TestcaseID", "12341")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData\\SearchData.csv", "SearchData#csv", DataAccessMethod.Sequential), DeploymentItem("CodedUISampleFramework\\TestData\\SearchData.csv"), TestMethod]
        public void SearchTextMany()
        {
            string searchText = null;
            BrowserWindow.Launch(AppConfig.GetValue("URL"));
            Homepage.EnterSearchText(out searchText);
            Homepage.SubmitSearch();
            SearchResults.VerifyResults(searchText);
        }

        [TestMethod]
        [Description("This test is to test that the search string is displayed in the second page")]
        [Owner("Viswa")]
        [Priority(0)]
        [TestProperty("TestcaseID","12342")]
        public void SearchText()
        {
           BingScriptsBase.BingTestContext.WriteLine("Test Start");
           BrowserWindow.Launch(AppConfig.GetValue("URL"));
           Homepage.EnterSearchText("Bill Gates"); //Not recommended to Hardcode values in scripts     
           Homepage.SubmitSearch();
           //Not recommended to use Static Wait Statements as given below  
           Playback.Wait(5000);
           //Not recommended to Hardcode values in scripts  
           Verify.WaitForControlPropertyEqual(BING.SearchResultsUI.searchText, "Text", "Bill Gates", 15000);
           BingScriptsBase.BingTestContext.WriteLine("Test Stop");
        }

        [TestMethod]
        [Description("This test will Verify Related Searches for a Search Condition")]
        [Owner("Viswa")]
        [Priority(0)]
        [TestProperty("TestcaseID", "12344")]
        [TestCategory("Daily")]
        public void VerifyRelatedSearchesLinks()
        {
            BrowserWindow.Launch(AppConfig.GetValue("URL"));
            //Not recommended to Hardcode values in scripts
            Homepage.EnterSearchText("Testing");
            Homepage.SubmitSearch();
            SearchResults.CheckRelatedLinks();
        }

        #endregion  

       //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public override void MyTestCleanup()
        {
            base.MyTestCleanup();
        }
    }
}
