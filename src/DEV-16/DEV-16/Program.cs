using DEV_16.Commands;
using DEV_16.CommandCreators;
using System;

namespace DEV_16
{
    /// <summary>
    /// Microframework to test site
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // path to read commands and write results
                string path = @"F:\AT\currenttime\src\DEV-16\input.txt";
                string outPutPath = @"F:\AT\currenttime\src\DEV-16\output.txt";

                CreatorCommand creatorCommand = new CreatorOpen(
                                                new CreatorCheckPageTitle(
                                                new CreatorCheckPageContains(
                                                new CreatorCheckLinkPresentByName(
                                                new CreatorCheckLinkPresentByHref(null)))));
                
                Provider provider = Provider.GetInstance(creatorCommand,outPutPath);
                provider.Execute(path);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
