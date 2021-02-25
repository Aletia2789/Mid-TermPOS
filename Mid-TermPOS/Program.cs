using System;
using System.IO;
using System.Text;

namespace Mid_TermPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var mymenu = new ReadMenu();
            //Console.WriteLine(mymenu);

            //StreamReader reader = new StreamReader("C:\Documents\displayMenu.txt");

            MenuReader menu = new MenuReader();
            MenuReader.MyMenu();

            //    try
            //    {

            //        StreamReader menu = new StreamReader("C:\\Users\\banka\\Documents\\displayMenu.txt");

            //        var line = menu.ReadLine();

            //        while (line != null)
            //        {

            //            Console.WriteLine(line);

            //            line = menu.ReadLine();
            //        }

            //        menu.Close();
            //        Console.ReadLine();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Exception: " + e.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Executing finally block.");
            //    }
            //}
        }
    }
}
