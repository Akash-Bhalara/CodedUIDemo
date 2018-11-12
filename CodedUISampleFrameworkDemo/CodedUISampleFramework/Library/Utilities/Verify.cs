using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;
using CodedUISampleFramework.Resources;

namespace CodedUISampleFramework.Library
{
    class Verify 
    {
        /// <summary>
        /// Waits and checks the property value of a control 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="property"></param>
        /// <param name="expectedValue"></param>
        /// <param name="millisecondsTimeout"></param>
        public static void WaitForControlPropertyEqual(UITestControl control, string property, string expectedValue, int millisecondsTimeout)
        {
            Assert.IsTrue(control.WaitForControlPropertyEqual(property, expectedValue, millisecondsTimeout),
                string.Format("Expected : {0} Actual : {1}", expectedValue, control.GetProperty(property)));
        }
    }
}
