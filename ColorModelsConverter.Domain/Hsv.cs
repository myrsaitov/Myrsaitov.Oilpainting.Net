namespace ColorModelsConverter.Domain
{
    /// <summary>
    /// HSB color system
    /// https://ru.wikipedia.org/wiki/HSV_(%D1%86%D0%B2%D0%B5%D1%82%D0%BE%D0%B2%D0%B0%D1%8F_%D0%BC%D0%BE%D0%B4%D0%B5%D0%BB%D1%8C)
    /// TODO: По ссылке есть пример разложения исходной картинки
    /// на диаграммы H, L, V. Это как раз то, что нужно для анализатора
    /// </summary>
    public class Hsv
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
        /// Volume (Brightness), floating point 0...1
        /// </summary>
        public double Value { get; set; }
    }
}
