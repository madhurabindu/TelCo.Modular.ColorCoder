using System;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// The telecom- 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    internal class ColorCoder
    {
        /// <summary>
        /// Array of pair of colors
        /// </summary>
        private static ColorPair[] colorPairs;
        
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorCoder()
        {
            colorPairs = ColorReader.InitializeColors();
        }

        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        internal static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            if (pairNumber < 1 || pairNumber > colorPairs.Length)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Construct the return val from the values
            ColorPair pair = new ColorPair()
            {
                MajorColor = colorPairs[pairNumber-1].MajorColor,
                MinorColor = colorPairs[pairNumber-1].MinorColor
            };

            // return the value
            return pair;
        }
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        internal static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the 0 based index in color pair array 
            int pairIndex = Array.FindIndex(colorPairs, 
                item => ((item.MajorColor == pair.MajorColor) && 
            (item.MinorColor == pair.MinorColor)));

            // If colors can not be found throw an exception
            if (pairIndex == -1 )
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 is because pair number is 1 based, not zero based index)
            return (pairIndex + 1);
        }
        /// <summary>
        /// Format the color code table and return the formatted string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return StringFormatter.Format(colorPairs);
        }
    }
}

