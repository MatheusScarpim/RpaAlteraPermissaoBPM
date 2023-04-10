using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using SeleniumtestFrameWork;
using System.Threading;

namespace SeleniumTestFrameWork
{
    class SeleniumSetMethods
    {
        public static void EnterText(string element, string value, PropertyType elementtype, bool Delay = false)
        {
            int tentativas = 60;
            for (int i = 0; i < tentativas; i++)
            {
                try
                {
                    if (elementtype == PropertyType.Id)
                        PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
                    if (elementtype == PropertyType.Name)
                        PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
                    if (Delay == true)
                    {
                        Thread.Sleep(1500);
                    }
                    return;
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public static void Click(string element, PropertyType elementtype, bool Delay = false)
        {
            int tentativas = 60;
            for (int i = 0; i < tentativas; i++)
            {
                try
                {
                    if (elementtype == PropertyType.Id)
                        PropertiesCollection.driver.FindElement(By.Id(element)).Click();
                    if (elementtype == PropertyType.Name)
                        PropertiesCollection.driver.FindElement(By.Name(element)).Click();
                    if (elementtype == PropertyType.ClassName)
                        PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
                    if (elementtype == PropertyType.Xpath)
                        PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
                    if(Delay == true)
                    {
                        Thread.Sleep(1500);
                    }
                    return;
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                }
            }

        }
        public static void SelectDropDown(string element, string value, PropertyType elementtype, bool Delay = false)
        {
            int tentativas = 60;
            for (int i = 0; i < tentativas; i++)
            {
                try
                {
                    if (elementtype == PropertyType.Id)
                        new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
                    if (elementtype == PropertyType.Name)
                        new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
                    if (elementtype == PropertyType.Xpath)
                        new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
                    if (Delay == true)
                    {
                        Thread.Sleep(1500);
                    }
                    return;
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
