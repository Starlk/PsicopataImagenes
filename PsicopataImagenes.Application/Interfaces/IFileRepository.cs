using PsicopataImagenes.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Application.Interfaces
{
    public interface IFileRepository
    {
        Task<bool> GetImageFromAzure();
        Task<string> PostImageToAzure(PhotoDto file);
    }
}
