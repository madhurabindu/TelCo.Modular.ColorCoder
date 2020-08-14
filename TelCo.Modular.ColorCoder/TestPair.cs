using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// Default Program class
    /// </summary>
    class TestPair
    {
        /// <summary>
        /// Test GetPair function
        /// </summary>
        internal void TestGetPair()
        {
            PositiveTestGetPair();
            NegativeTestGetPair();
        }
        /// <summary>
        /// Test for correct data
        /// </summary>
        private void PositiveTestGetPair()
        {
            // Positive case 1
            ColorPair testPair2 = new ColorPair() { MajorColor = Color.Yellow, MinorColor = Color.Blue };
            int pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 16);

            // Positive case 2
            testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Green };
            pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 8);
        }

        /// <summary>
        /// Test for incorrect data
        /// </summary>
        private void NegativeTestGetPair()
        {
            // negative test case with wrong color as input to simulate error condition
            bool errorConditionHandled = false;
            try
            {
                ColorPair testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Maroon };
                int pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            }
            catch (Exception ex)
            {
                errorConditionHandled = true;
            }
            Debug.Assert(errorConditionHandled);
        }
    }
}
