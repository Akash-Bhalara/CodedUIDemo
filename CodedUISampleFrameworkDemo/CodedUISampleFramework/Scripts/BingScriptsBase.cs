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
using CodedUISampleFramework.UIMaps.HomepageUIClasses;
using CodedUISampleFramework.UIMaps.SearchResultsUIClasses;
using CodedUISampleFramework.Library;
using CodedUISampleFramework.Config;

namespace CodedUISampleFramework.Scripts
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class BingScriptsBase
    {
        public BingScriptsBase()
        {
        }

        private static TestContext bingTestContext;

        public static TestContext BingTestContext
        {
            get { return BingScriptsBase.bingTestContext; }
            set { BingScriptsBase.bingTestContext = value;}
        }

        #region TestInitialize
        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public virtual void MyTestInitialize()
        {
            Browser.CloseAllBrowsers();
            BING.HomepageUI = new HomepageUI();
            BING.SearchResultsUI = new SearchResultsUI();
            BingTestContext = testContextInstance;
            //PlaybackSettings();
        }
        #endregion

        /// <summary>
        /// Confugure the Global Playback Settings
        /// </summary>
        private void PlaybackSettings()
        {
            PlaybackConfig.SetThinkSearchTimeOut();
            PlaybackConfig.SetWaitForReadyTimeout();
        }

        #region TestCleanup
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public virtual void MyTestCleanup()
        {
            BING.HomepageUI = new HomepageUI();
            BING.SearchResultsUI = new SearchResultsUI();
            Browser.CloseAllBrowsers();
        }
        #endregion

        #region TestContext
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
        #endregion
    }
}
