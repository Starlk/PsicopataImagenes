using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Application.Interfaces
{
    public interface IProfileImages
    {
        string name{ set; get; }
        IFormFile photo { get; set; }
    }
}
