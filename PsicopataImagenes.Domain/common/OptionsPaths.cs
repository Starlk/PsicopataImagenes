using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Domain.common
{
    public class OptionsPaths
    {
        public const string AllowOriginPath = "AllowOriginPath";
        public string? localhost { get; set; }
        public string? Domain { get; set; }
        public string? herokuDomain { get; set; }
    }
}
