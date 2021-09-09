using System;

namespace ColorLaboratory.Application.Services.Exceptions
{
    public class Cmyk2RgbNotValidException : ApplicationException
    {
        public Cmyk2RgbNotValidException(string message) : base(message)
        {
        }
    }
}
