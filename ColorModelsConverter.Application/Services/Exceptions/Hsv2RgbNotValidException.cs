using System;

namespace ColorModelsConverter.Application.Services.Exceptions
{
    public class Hsv2RgbNotValidException : ApplicationException
    {
        public Hsv2RgbNotValidException(string message) : base(message)
        {
        }
    }
}
