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
        /// String represnetation of color pair
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }
    }
}
