using DEV_16.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.IO;

namespace DEV_16
{
    /// <summary>
    /// Contains method to work with page
    /// </summary>
    class Provider
    {
        public static Provider provider;
        Stopwatch testTime = new Stopwatch();

        public string outputFile { get; set; }

        public CreatorCommand commandCreator;
        private Logger logger;
        private ResultTest result;

        IWebDriver driver;

        private Provider(CreatorCommand commandCreator,string outputFile )
        {
            this.driver = new ChromeDriver();
            this.logger = new Logger(outputFile);
            this.commandCreator = commandCreator;
            this.outputFile = outputFile;
        }

        public static Provider GetInstance(CreatorCommand commandCreator, string outputFile)
        {
            if (provider==null)
            {
                provider = new Provider(commandCreator,outputFile);
            }
            return provider;
        }

        Command command;
        /// <summary>
        /// Read file and Execute input commands
        /// </summary>
        /// <param name="path"></param>
        public void Execute(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string notParsedCommand = reader.ReadLine();
                while (notParsedCommand!= null)
                {                   
                    command = commandCreator.GetCommand(notParsedCommand);
                    if(command != null)
                    {
                        command.Execute();
                    }
                    notParsedCommand = reader.ReadLine();
                }
            }
            logger.WriteResult();         
        }

        /// <summary>
        /// Open Url
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="time">time</param>
        public void Open(string url,TimeSpan time)
        {
            testTime.Start();
            driver.Navigate().GoToUrl(url);
            testTime.Stop();        
            result = new ResultTest(time>=testTime.Elapsed,command.commandString,testTime.Elapsed);
            logger.results.Add(result);
        }

        /// <summary>
        /// Check link by href
        /// </summary>
        /// <param name="href">href</param>
        public void CheckLinkPresenrByHref(string href)
        {
            testTime.Start();
            string xpath = string.Concat("//a[@href='", href, "']");
            bool isExist = driver.FindElements(By.XPath(xpath)).Count  != 0 ? true : false;          
            testTime.Stop();
            result = new ResultTest(isExist, command.commandString, testTime.Elapsed);
            logger.results.Add(result);
        }

        /// <summary>
        /// Check link by name
        /// </summary>
        /// <param name="text">name</param>
        public void CheckLinkPressentByName(string text)
        {
            testTime.Start();
            string xpath = string.Concat(".//*[contains(text(),'", text, "')]");
            bool isExist = driver.FindElements(By.XPath(xpath)).Count != 0 ? true : false;
            testTime.Stop();
            result = new ResultTest(isExist, command.commandString, testTime.Elapsed);
            logger.results.Add(result);
        }

        /// <summary>
        /// Check yexy contains
        /// </summary>
        /// <param name="text">text</param>
         public void CheckContains(string text)
        {
            testTime.Start();
            bool isContains = driver.PageSource.Contains(text);
            testTime.Stop();
            result = new ResultTest(isContains, command.commandString, testTime.Elapsed);
            logger.results.Add(result);
        }

        /// <summary>
        /// Check page title
        /// </summary>
        /// <param name="title">title</param>
        public void CheckPageTitle(string title)
        {
           testTime.Start();
           bool isCorrect = driver.Title.Equals(title);
           testTime.Stop();
           result = new ResultTest(isCorrect, command.commandString, testTime.Elapsed);
           logger.results.Add(result);
        }
    }
}
