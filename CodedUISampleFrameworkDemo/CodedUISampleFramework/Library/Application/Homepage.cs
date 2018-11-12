using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;

namespace CodedUISampleFramework.Library
{
    class Homepage
    {
        /// <summary>
        /// This method enters Search Text and executes itratively on the available values
        /// </summary>
        /// <param name="searchText">The current text used for search</param>
        public static void EnterSearchText(out string searchText)
        {
            searchText = Data.GetValue("SearchText");
            BING.HomepageUI.searchText.Text = searchText;        
        }

        /// <summary>
        /// Enter the search text in Search Edit 
        /// </summary>
        /// <param name="searchText">The text to be Searched in Bing</param>
        public static void EnterSearchText(string searchText)
        {
            BING.HomepageUI.searchText.Text = searchText;
        }

        /// <summary>
        /// Click on the Search Submit button
        /// </summary>
        public static void SubmitSearch()
        {
            Mouse.Click(BING.HomepageUI.searchSubmit);
        }
    }
}
