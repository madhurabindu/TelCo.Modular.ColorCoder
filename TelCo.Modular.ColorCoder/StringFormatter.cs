using System;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// string Formatter class for color codes
    /// </summary>
    internal class StringFormatter
    {
        /// <summary>
        /// Given color pairs this class formats the pairs into a printable format
        /// </summary>
        /// <param name="colorPairs"></param>
        /// <returns></returns>
        internal static string Format(ColorPair[] colorPairs)
        {
            string display = String.Format("|{0,5}|{1,15}|{2,15}|\n", "Pair", 
                CenterAlign("Major Color", 15),
                CenterAlign("Minor Color", 15));
            string line = new string('-', display.Length);

            display = line + "\n" + display + line + "\n";

            for (int i = 0; i < colorPairs.Length; i++)
            {
                string mjrColorAligned = CenterAlign(colorPairs[i].MajorColor.Name, 15);
                string minorColorAligned = CenterAlign(colorPairs[i].MinorColor.Name, 15);

                display = display +
                    String.Format("|{0,-5}|{1,15}|{2,15}|\n", i+1, 
                    mjrColorAligned, minorColorAligned);
            }
            display = display + line + "\n";
            return display;
        }
        /// <summary>
        /// Center align the string as the 
        /// String.Format only provides left align and right align
        /// </summary>
        /// <param name="value"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        private static string CenterAlign(string value, int width)
        {
            var padding = (width + value.Length) / 2;
            return value.PadRight(padding, ' ');
        }
    }
}
