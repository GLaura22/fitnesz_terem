using fitnesz_terem.Database_Backend.Functions_and_Controllers;

namespace fitnesz_terem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TEST RÉSZ

            LoadInData x = new LoadInData();
            x.DataLoad();

            ///---------



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new indulo_felulet());
        }
    }
}