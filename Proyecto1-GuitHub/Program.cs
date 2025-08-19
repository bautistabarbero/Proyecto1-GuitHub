namespace Proyecto1_GuitHub
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
csharp

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Lindo miercoles para estar con Visual Studio 2022!");
    }
}
