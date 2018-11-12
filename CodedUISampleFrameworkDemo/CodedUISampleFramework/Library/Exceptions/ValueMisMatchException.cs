using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodedUISampleFramework.Library
{
    public class ZeroSearchResultsException : Exception
    {
        public ZeroSearchResultsException() : base() { }
        public ZeroSearchResultsException(string msg) : base(msg) { }
        public ZeroSearchResultsException(string msg, Exception e) : base(msg, e) { }

        private string searchString;
        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; }
        }

    }
}
