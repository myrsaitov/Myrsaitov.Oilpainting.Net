using System;

namespace ColorModelsConverter.Application.Services.Exceptions
{
    public class Rgb2HsvNotValidException : ApplicationException
    {
        public Rgb2HsvNotValidException(string message) : base(message)
        {
        }
    }
}
