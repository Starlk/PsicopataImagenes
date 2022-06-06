using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PsicopataImagenes.Application.Dto;
using PsicopataImagenes.Application.Interfaces;

namespace PsicopataImagenes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesAzureController : ControllerBase
    {
        private readonly IFileServices _file;

        public ImagesAzureController(IFileServices file) 
        {
            _file = file;
   
        }
        [HttpPost]
        public async Task<IActionResult> post([FromForm]PhotoDto file) 
        {
            var req = await _file.PostImages(file);
            if (req != null)  return Ok(req);
            return BadRequest("Won't upload the image  ");
        }
    }
}
