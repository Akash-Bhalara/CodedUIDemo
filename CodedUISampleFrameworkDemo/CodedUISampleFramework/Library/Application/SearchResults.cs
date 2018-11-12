using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodedUISampleFramework.Resources;
using Microsoft.VisualStudio.TestTools.UITesting;
using CodedUISampleFramework.Scripts;

namespace CodedUISampleFramework.Library
{
    class SearchResults
    {
        public static int SearchResultsCount()
        {
            return 1; //Dummy
        }

        /// <summary>
        /// Verifies whether any results were displayed for a search condition
        /// </summary>
        /// <returns>true if there were results, false if not</returns>
        public static bool IsSuccess()
        {
            return BING.SearchResultsUI.noResultspane.InnerText.StartsWith(SearchResource.NoResultTextStart);
        }

        public static void NavigateLinks()
        {
            string linkText = Data.GetValue("ResultLinksText");
           // ObjectIdentification.UpdateSearchProperties(linkText);
            ObjectIdentification.AddUpdateSearchProperties(BING.SearchResultsUI.resultLink, "InnerText", linkText);
            UITestControlCollection col =  BING.SearchResultsUI.resultLink.FindMatchingControls();
            Mouse.Click(BING.SearchResultsUI.resultLink);
        }

        public static void VerifyResults(string searchText)
        {
            if (SearchResults.IsSuccess())
            {
                throw new ZeroSearchResultsException("No results were displayed for the search text : " + searchText);
            }
        }

        public static void CheckRelatedLinks()
        {
            for(int i=0;i < 4;i++) 
            {
                ObjectIdentification.AddUpdateSearchProperties(BING.SearchResultsUI.relatedSearchesHyperlink, "TagInstance", (i + 1).ToString());
                BingScriptsBase.BingTestContext.WriteLine(BING.SearchResultsUI.relatedSearchesHyperlink.InnerText);
            }
        }
    }
}
