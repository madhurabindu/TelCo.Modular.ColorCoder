using System;
using System.Drawing;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// Class responsible for initializing the colors in color pair
    /// </summary>
    internal static class ColorReader
    {
        /// <summary>
        /// Initialize the colors and return the color pair
        /// </summary>
        internal static ColorPair[] InitializeColors()
        {
            // Set of major and minor colors in order
            Color[] colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            Color[] colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

            int majorLength = colorMapMajor.Length;
            int minorLength = colorMapMinor.Length;

            // Construct the color pair
            ColorPair[] colorPairs = new ColorPair[majorLength * minorLength];
            int pairIndex = 0;
            for (int i = 0; i < majorLength; i++)
            {
                for (int j = 0; j < minorLength; j++)
                {
                    ColorPair pair = new ColorPair()
                    {
                        MajorColor = colorMapMajor[i],
                        MinorColor = colorMapMinor[j]
                    };

                    colorPairs[pairIndex] = pair;
                    pairIndex++;
                }
            }
            // return the color pairs
            return colorPairs;
        }
    }
}
