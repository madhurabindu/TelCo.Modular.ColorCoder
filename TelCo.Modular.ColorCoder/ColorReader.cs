using System;
using System.Drawing;

namespace TelCo.Modular.ColorCodeProvider
{
    internal static class ColorReader
    {
        /// <summary>
        /// 
        /// </summary>
        internal static ColorPair[] InitializeColors()
        {
            Color[] colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            Color[] colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

            int majorLength = colorMapMajor.Length;
            int minorLength = colorMapMinor.Length;

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

            return colorPairs;
        }
    }
}
