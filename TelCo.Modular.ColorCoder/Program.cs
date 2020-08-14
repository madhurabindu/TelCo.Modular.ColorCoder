using System;
using System.Drawing;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// Default Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);

            pairNumber = 23;
            testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);

            ColorPair testPair2 = new ColorPair() { MajorColor = Color.Yellow,MinorColor = Color.Green };
            pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);

            testPair2 = new ColorPair() { MajorColor = Color.White, MinorColor = Color.Brown };
            pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
        }
    }
}
