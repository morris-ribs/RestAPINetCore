using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace musicstore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicstoreController : ControllerBase
    {
        private static Random rng = new Random();
        private static ArrayList Albums = new ArrayList();
        private readonly ILogger<MusicstoreController> _logger;

        public MusicstoreController(ILogger<MusicstoreController> logger)
        {
            _logger = logger;
            // if (Albums.Count == 0) {
            //     Albums.Add(new Album {
            //         ID = rng.Next(1, 2000).ToString(),
            //         Title = "Title N 1",
            //         Artist = "Artist N 1",
            //         Year = rng.Next(1950, 2020)
            //     });
                
            //     Albums.Add(new Album
            //     {
            //         ID = rng.Next(1, 2000).ToString(),
            //         Title = "Title N 2",
            //         Artist = "Artist N 2",
            //         Year = rng.Next(1950, 2020)
            //     });
                
            //     Albums.Add(new Album
            //     {
            //         ID = rng.Next(1, 2000).ToString(),
            //         Title = "Title N 3",
            //         Artist = "Artist N 3",
            //         Year = rng.Next(1950, 2020)
            //     }); 
            // }
        }

        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return Albums.Cast<Album>();
        }

        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<Album>> PostAlbum(Album album)
        {
            Albums.Add(album);
            // _context.Albums.Add(album);
            // await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(Get), album);
        }
    }
}
