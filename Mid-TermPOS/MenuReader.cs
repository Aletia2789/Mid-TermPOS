using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mid_TermPOS
{
    public class MenuReader
    {
        //private static readonly string filePath = @"C:\Documents\displayMenu.txt";

        public static void MyMenu()
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\banka\\Documents\\displayMenu.txt");
                //Read the first line of text
                var line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
