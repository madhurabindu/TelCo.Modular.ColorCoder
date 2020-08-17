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
            int pairNumber = ColorCodeRegistry.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 16);

            // Positive case 2
            testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Green };
            pairNumber = ColorCodeRegistry.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 8);
        }

        /// <summary>
        /// Test for incorrect data
        /// </summary>
        private void NegativeTestGetPair()
        {
            // negative test case with wrong color as input to simulate error condition
            bool errorConditionHandled = false;
            ColorPair testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Maroon };
            try
            {
                int pairNumber = ColorCodeRegistry.GetPairNumberFromColor(testPair2);
                Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);

            }
            catch (Exception)
            {
                errorConditionHandled = true;
                Console.WriteLine("Invalid Color : {0}, Error Condition handled\n", testPair2);
            }
            Debug.Assert(errorConditionHandled);
        }
    }
}
