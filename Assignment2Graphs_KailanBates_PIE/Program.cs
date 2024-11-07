namespace Assignment2Graphs_KailanBates_PIE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // for testing
            //Pie.AddNewData(new DataInput("Fish", 5));
            //Pie.AddNewData(new DataInput("Cats", 5));
            //Pie.AddNewData(new DataInput("Dogs", 5));
            //Pie.AddNewData(new DataInput("Rats", 5));
            //Pie.AddNewData(new DataInput("Horses", 5));


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


          
        }
    }
}