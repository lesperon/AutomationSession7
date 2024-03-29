﻿using AutomationSession7.BaseFiles;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSession7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {


            SetUp();

            FnSendKeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendKeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));

            /*Xpath Version*/
            FnSendKeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username2"));
            FnSendKeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password2"));



            driver.FindElement(By.Name("login")).Click();

            
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a"));
            foreach (IWebElement el in ElementList)
            {

                el.GetAttribute("href");
            }
            
            
            //AfterTest();

           
           
        }
    }
}
