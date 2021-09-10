using System;

namespace ColorModelsConverter.Application.Services.Exceptions
{
    public class Rgb2HslNotValidException : ApplicationException
    {
        public Rgb2HslNotValidException(string message) : base(message)
        {
        }
    }
}
