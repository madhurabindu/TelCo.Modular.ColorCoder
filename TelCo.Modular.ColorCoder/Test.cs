using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// Test class for testing the color code functionality
    /// </summary>
    internal class Test
    {

        /// <summary>
        /// Print the table
        /// </summary>
        internal void PrintColorTable()
        {
            ColorCoder coder = new ColorCoder();
            Console.WriteLine(coder.ToString());
        }
        /// <summary>
        /// Test Get color function
        /// </summary>
        internal void TestGetColor()
        {
            TestColor testColor = new TestColor();
            testColor.TestGetColor();
        }
        /// <summary>
        /// Test Get pair funciton
        /// </summary>
        internal void TestGetPair()
        {
            TestPair testPair = new TestPair();
            testPair.TestGetPair();
        }
    }
}
