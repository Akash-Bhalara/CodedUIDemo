using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodedUISampleFramework.Library
{
    public class ValueMisMatchException : Exception
    {
        public ValueMisMatchException() : base() { }
        public ValueMisMatchException(string msg) : base(msg) { }
        public ValueMisMatchException(string msg, Exception e) : base(msg, e) { }
    }
}
