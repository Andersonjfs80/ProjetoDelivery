using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Domain.Services.Domain
{
    public class GenericReturn: IGenericReturn
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Json { get; set; }
    }
}
