using PsicopataImagenes.Application.Dto;
using PsicopataImagenes.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Application.Services
{
    public class FileServices : IFileServices
    {
        private readonly IFileRepository _repoFile;

        public FileServices(IFileRepository repo)
        {
            _repoFile = repo;
        }
        public Task<bool> GetAllImages()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostImages(PhotoDto photo)
        {
            long size = photo.photo.Length;
            if (size < 0) throw new Exception("Imagen doesn't exist");

            return await _repoFile.PostImageToAzure(photo);
      
        }
    }
}
