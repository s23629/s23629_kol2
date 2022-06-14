using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s23629.Models;
using s23629.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s23629.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusicService _service;

        public MusicController(IMusicService service)
        {
            _service = service;
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Get(int id) {

            var IdMusician = await _service.GetMusicianId(id);
            if (IdMusician == null) return NotFound();
            return (await _service.GetMusician(id).Select(e => new MusicianDto {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Nickname = e.Nickname,
                Records = e.MusicianTracks.Select(e => e.Track).Select(e => new Record {
                    TrackName = e.TrackName,
                    Duration = e.Duration,
                    IdMusicAlbum = e.IdMusicAlbum
                }).ToList()

            }).ToListAsync();
        
        }))     
        }
    }
}
