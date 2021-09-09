using System;

namespace ColorLaboratory.Application.Services.Exceptions
{
    public class Rgb2CmykNotValidException : ApplicationException
    {
        public Rgb2CmykNotValidException(string message) : base(message)
        {
        }
    }
}
