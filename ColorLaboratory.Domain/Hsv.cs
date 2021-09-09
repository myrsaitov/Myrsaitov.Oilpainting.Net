namespace ColorLaboratory.Domain
{
    /// TODO
    /// <summary>
    /// HSB color system
    /// https://ru.wikipedia.org/wiki/HSV_(%D1%86%D0%B2%D0%B5%D1%82%D0%BE%D0%B2%D0%B0%D1%8F_%D0%BC%D0%BE%D0%B4%D0%B5%D0%BB%D1%8C)
    /// </summary>
    public class Hsb
    {
        /// <summary>
        /// Hue, floating point 0...1
        /// </summary>
        public byte H { get; set; }
        /// <summary>
        /// Saturation, floating point 0...1
        /// </summary>
        public byte S { get; set; }
        /// <summary>
        /// Brightness, floating point 0...1
        /// </summary>
        public byte B { get; set; }
    }
}
