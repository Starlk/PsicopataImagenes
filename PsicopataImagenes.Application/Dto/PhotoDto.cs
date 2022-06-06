using Microsoft.AspNetCore.Http;
using PsicopataImagenes.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Application.Dto
{
    public class PhotoDto : IProfileImages
    {
        public string name { get; set; }
        public IFormFile photo { get; set; }
    }
}
