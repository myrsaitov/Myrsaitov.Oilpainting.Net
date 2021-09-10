using System;

namespace ColorModelsConverter.Application.Services.Exceptions
{
    public class Cmyk2RgbNotValidException : ApplicationException
    {
        public Cmyk2RgbNotValidException(string message) : base(message)
        {
        }
    }
}
