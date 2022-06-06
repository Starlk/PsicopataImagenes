using PsicopataImagenes.Application.Dto;
using PsicopataImagenes.Application.Interfaces;
using PsicopataImagenes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Infraestructure.repository
{
    public class FileRepository : IFileRepository
    {
        BlobFile blobFile;
        public Task<bool> GetImageFromAzure()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostImageToAzure(PhotoDto file)
        {
            blobFile = new BlobFile(AzureBlob.ConnectionContainerString, AzureBlob.container);
            try
            {
             return await blobFile.UploadImage(file);
            }catch (Exception ex)
            {
                throw new Exception($"failed {ex.Message}");
            }
        }
    }
}
