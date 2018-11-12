using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUISampleFramework.Library
{
    public class ObjectIdentification
    {
        public static void AddUpdateSearchProperties(UITestControl control, string property, string value)
        {
            control.SearchProperties.Add(property, value);
        }

        public static void RemoveSearchProperties(UITestControl control, string property)
        {
            control.SearchProperties.Remove(property);
        }

        public static void AddUpdateSearchProperties(UITestControl control, Dictionary<string,string> propertyDict)
        {
            PropertyExpressionCollection expCollection = new PropertyExpressionCollection();
            foreach(KeyValuePair<string,string> propValue in propertyDict)
            {
                expCollection.Add(propValue.Key, propValue.Value);
            }
            control.SearchProperties.AddRange(expCollection);
            
        }
    }
}
