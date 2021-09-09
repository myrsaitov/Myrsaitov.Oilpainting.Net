namespace ColorLaboratory.Domain
{
    /// <summary>
    /// CMYK color system
    /// </summary>
    public class Cmyk
    {
        /// <summary>
        /// Cyan, floating point 0...1
        /// </summary>
        public double C { get; set; }
        /// <summary>
        /// Magenta, floating point 0...1
        /// </summary>
        public double M { get; set; }
        /// <summary>
        /// Yellow, floating point 0...1
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// Black (Key), floating point 0...1
        /// </summary>
        public double K { get; set; }
    }
}
