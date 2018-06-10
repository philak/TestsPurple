using NUnit.Framework;
using OpenQA.Selenium;
using PurpleBrick.PurpleBase;
using System;


namespace PurpleBrick
{
    public class Utils
    {
   
        public static bool IsElementVisibleEnabled(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        public static void VerifyElementAbsent(IWebElement element) 
        {
            try
            {
                if (element.Displayed)
                {
                    Console.WriteLine("The object is visible");
                    Assert.IsFalse(true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The object is not visible" + e);
                Assert.IsTrue(true);
            }
            }

    }
}
