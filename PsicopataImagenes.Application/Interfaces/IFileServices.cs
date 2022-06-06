using PsicopataImagenes.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Application.Interfaces
{
    public interface IFileServices
    {
        Task<bool> GetAllImages();
        Task<string> PostImages(PhotoDto file);
    }
}
