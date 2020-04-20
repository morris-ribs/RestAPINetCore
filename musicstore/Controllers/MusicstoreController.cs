using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Musicstore.Models;
using Musicstore.Services;

namespace Musicstore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicstoreController : ControllerBase
    {
        private readonly AlbumService _albumService;
        private static Random rng = new Random();
        private static ArrayList Albums = new ArrayList();
        private readonly ILogger<MusicstoreController> _logger;

        public MusicstoreController(ILogger<MusicstoreController> logger, AlbumService albumService)
        {
            _logger = logger;
            _albumService = albumService;
        }

        [HttpGet]
        public ActionResult<List<Album>> Get() =>
            _albumService.Get();

        [HttpGet("{id:length(24)}", Name = "GetAlbum")]
        public ActionResult<Album> Get(string id)
        {
            var album = _albumService.Get(id);

            if (album == null)
            {
                return NotFound();
            }

            return album;
        }

        [HttpPost]
        public ActionResult<Album> Create(Album album)
        {
            _albumService.Create(album);
            return CreatedAtRoute("GetAlbum", new { id = album.Id.ToString() }, album);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Album albumIn)
        {
            var album = _albumService.Get(id);

            if (album == null)
            {
                return NotFound();
            }

            _albumService.Update(id, albumIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var album = _albumService.Get(id);

            if (album == null)
            {
                return NotFound();
            }

            _albumService.Remove(album.Id);

            return NoContent();
        }
    }
}
