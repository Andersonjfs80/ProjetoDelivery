using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Domain.Services.Domain
{
    public interface IGenericReturn
    {
        string Message { get; set; }
        bool Success { get; set; }
        string Json { get; set; }
    }
}
