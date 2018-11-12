using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodedUISampleFramework.UIMaps.HomepageUIClasses;
using CodedUISampleFramework.UIMaps.SearchResultsUIClasses;

namespace CodedUISampleFramework
{
    public class BING
    {
        private static HomepageUI homepageUI;
        private static SearchResultsUI searchResultsUI;

        public static HomepageUI HomepageUI
        {
            get
            {
                if (homepageUI == null)
                {
                    return new HomepageUI();
                }
                return homepageUI;
            }
            
            set { BING.homepageUI = value; }
        }
        
        public static SearchResultsUI SearchResultsUI
        {
            get
            {
                if (searchResultsUI == null)
                {
                    return new SearchResultsUI();
                }
                return searchResultsUI;
            }
            
            set { BING.searchResultsUI = value; }
        }
    }
}
