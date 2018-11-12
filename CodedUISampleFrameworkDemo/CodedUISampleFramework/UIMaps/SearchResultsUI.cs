namespace CodedUISampleFramework.UIMaps.SearchResultsUIClasses
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
   
    public partial class SearchResultsUI
    {
        #region Constructor

        public SearchResultsUI()
        {
            noResultspane = BingSearchResultsBrowser.BingResultsPage.NoResultsPane;
            searchSubmit = BingSearchResultsBrowser.BingResultsPage.SearchButton;
            searchText = BingSearchResultsBrowser.BingResultsPage.SearchEdit;
            relatedSearchesPane = BingSearchResultsBrowser.BingResultsPage.RelatedSearchesPane;
            relatedSearchesHyperlink = BingSearchResultsBrowser.BingResultsPage.RelatedSearchesPane.RelatedSearchesHyperlink;
        }

        #endregion 

        #region PageControls

        public HtmlDiv noResultspane;
        public HtmlHyperlink resultLink;
        public HtmlEdit searchText;
        public HtmlInputButton searchSubmit;
        public HtmlDiv relatedSearchesPane;
        public HtmlHyperlink relatedSearchesHyperlink;

        #endregion
    }
}
