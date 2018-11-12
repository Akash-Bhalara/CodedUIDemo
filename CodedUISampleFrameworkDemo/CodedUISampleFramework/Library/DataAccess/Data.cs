using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodedUISampleFramework.Scripts;

namespace CodedUISampleFramework.Library
{
    public class Data
    {
        public static string GetValue(string columnName)
        {
            return (string)BingScriptsBase.BingTestContext.DataRow[columnName];
        }
    }
}
