using System;
using System.IO;
namespace RosaDAL
{
    /// <summary>
    /// Error Handler Class
    /// By Cosmin Ilie
    /// Student number: 645976
    /// </summary>
    public class ErrorHandler
    {
        public ErrorHandler(string explanation) // the explanation is simplified so a normal user can understand it
        {

            string file = @"../../../Error.log";  //put the file path in the root folder
            if (!File.Exists(file)) // if file doesn't exist, create file
                File.Create(file);

            using (StreamWriter writer = File.AppendText(file)) //append error to log file
                writer.WriteLine($"Occurance time: {DateTime.Now.ToString()} Explanation: {explanation}");

            if (Environment.UserInteractive) //if the app is interactive (winform / WPF)
                throw new InvalidOperationException(explanation);
            else
                Console.WriteLine(explanation);

        }
    }
}
