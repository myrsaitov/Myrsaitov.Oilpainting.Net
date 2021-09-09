﻿using ColorLaboratory.Domain;

namespace ColorLaboratory.Application.Services.Contracts
{
    public class Rgb2Cmyk
    {
        public sealed class Request
        {
            public Rgb rgb { get; set; }
        }
        public sealed class Response
        {
            public Cmyk cmyk { get; set; }
        }
    }
}