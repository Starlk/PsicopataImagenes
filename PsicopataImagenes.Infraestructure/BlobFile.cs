using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using PsicopataImagenes.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Infraestructure
{
    public class BlobFile
    {
        private readonly string _conn;
        private readonly string _container;
        BlobServiceClient blobClient;
        public BlobFile(string connection, string container)
        {
            _conn = connection;
            blobClient = new BlobServiceClient(connection);
            _container = container;
        }

        public async Task<string> UploadImage(IProfileImages file)
        {
            string fileName = $"{Guid.NewGuid().ToString()}-{file.name}.jpg";
            BlobContainerClient containerClient = blobClient.GetBlobContainerClient(_container);
            BlobClient client = containerClient.GetBlobClient(fileName);
            using (var fileStream = await client.OpenWriteAsync(true, new BlobOpenWriteOptions()))
            {
                await file.photo.CopyToAsync(fileStream);
                fileStream.Close();
            }
            return client.Uri.ToString();
       
        }
    }
}
