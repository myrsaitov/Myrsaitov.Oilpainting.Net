using ColorLaboratory.Domain;

namespace ColorLaboratory.Application.Services.Contracts
{
    public class Cmyk2Rgb
    {
        public sealed class Request
        {
            public Cmyk cmyk { get; set; }
        }
        public sealed class Response
        {
            public Rgb rgb { get; set; }
        }
    }
}