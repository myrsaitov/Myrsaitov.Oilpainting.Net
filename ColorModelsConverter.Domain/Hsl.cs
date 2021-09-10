﻿namespace ColorModelsConverter.Domain
{
    /// TODO
    /// <summary>
    /// HSL color system
    /// https://ru.wikipedia.org/wiki/HSL
    /// </summary>
    public class Hsl
    {
        /// <summary>
        /// Hue, 0...360 deg
        /// </summary>
        public byte H { get; set; }
        /// <summary>
        /// Saturation, floating point 0...1
        /// </summary>
        public byte S { get; set; }
        /// <summary>
        /// Lightness, floating point 0...1
        /// </summary>
        public byte L { get; set; }
    }
}