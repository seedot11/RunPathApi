using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RunPathApi.Core.Models;
using RunPathApi.Core.Services;

namespace RunPathApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : ControllerBase
    {
        private readonly ILogger<PhotoController> _logger;
        private readonly PhotoService photoService;

        public PhotoController(ILogger<PhotoController> logger)
        {
            _logger = logger;
            photoService = PhotoService.Create();
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Album> Get()
        {
            try
            {
                return photoService.GetPhotosAndAlbums();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("{userId:int}")]
        public IEnumerable<Album> Get(int userId)
        {
            try
            {
                return photoService.GetPhotosAndAlbums(userId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
