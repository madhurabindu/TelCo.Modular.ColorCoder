using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// Default Program class
    /// </summary>
    class TestColor
    {
       
        /// <summary>
        /// Test Get Color function
        /// </summary>
        internal void TestGetColor()
        {
            PositiveTestGetColor();
            NegativeTestGetColor();
        }
       
        /// <summary>
        /// Test for correct data
        /// </summary>
        internal void PositiveTestGetColor()
        {
            // Positive case 1
            int pairNumber = 5;
            ColorPair testPair1 = ColorCodeRegistry.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.SlateGray);

            // Positive case 2
            pairNumber = 24;
            testPair1 = ColorCodeRegistry.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == Color.Violet);
            Debug.Assert(testPair1.MinorColor == Color.Brown);
        }

        /// <summary>
        /// Test for incorrect data
        /// </summary>
        private void NegativeTestGetColor()
        {
            // Negatice test case with wrong pair number as input to simulate error condition
            int pairNumber = 0;
            bool errorConditionHandled = false;
            try
            {
                ColorPair testPair1 = ColorCodeRegistry.GetColorFromPairNumber(pairNumber);
                Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            }
            catch (Exception ex)
            {
                errorConditionHandled = true;
            }
            Debug.Assert(errorConditionHandled);
        }

    }
}
