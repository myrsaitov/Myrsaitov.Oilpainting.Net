using System;

namespace ColorModelsConverter.Application.Services.Exceptions
{
    public class Hsl2RgbNotValidException : ApplicationException
    {
        public Hsl2RgbNotValidException(string message) : base(message)
        {
        }
    }
}
