using System;
using System.Windows.Forms;

namespace DataExtraction
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Logger.SetLogDestination(@"./");
                Logger.Log(Logger.LogType.INFO, "DataExtraction. AlexandreScorreia Tecnologia.");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Log(Logger.LogType.ERROR, $"An error occurred while running the application: {ex.Message}");
                Environment.Exit(1);
            }
        }
    }
}
