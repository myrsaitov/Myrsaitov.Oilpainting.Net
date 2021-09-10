namespace ColorModelsConverter.Domain
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
        public double Hue { get; set; }
        /// <summary>
        /// Saturation, floating point 0...1
        /// </summary>
        public double Saturation { get; set; }
        /// <summary>
        /// Lightness, floating point 0...1
        /// </summary>
        public double Lightness { get; set; }
    }
}
