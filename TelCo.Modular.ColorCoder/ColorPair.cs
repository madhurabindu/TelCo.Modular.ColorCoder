using System;
using System.Drawing;

namespace TelCo.Modular.ColorCodeProvider
{
    /// <summary>
    /// data type defined to hold the two colors of clor pair
    /// </summary>
    internal class ColorPair
    {
        /// <summary>
        /// Major Color
        /// </summary>
        internal Color MajorColor { get; set; }
        /// <summary>
        /// Minor color
        /// </summary>
        internal Color MinorColor { get; set; }
        /// <summary>
        /// default ctor
        /// </summary>
        public ColorPair()
        {

        }
        /// <summary>
        /// Copy ctor
        /// </summary>
        /// <param name="pair"></param>
        public ColorPair(ColorPair pair)
        {
            MajorColor = pair.MajorColor;
            MinorColor = pair.MinorColor;
        }
        /// <summary>
        /// String represnetation of color pair
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }
    }
}
