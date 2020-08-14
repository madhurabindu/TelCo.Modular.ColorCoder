using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.Modular.ColorCodeProvider
{
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Test p = new Test();
            // Print the table
            p.PrintColorTable();

            // Test the GetColor function 
            p.TestGetColor();

            // Test the GetColor function 
            p.TestGetPair();

        }
    }
}
