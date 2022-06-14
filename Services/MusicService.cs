using Microsoft.EntityFrameworkCore;
using s23629.DataAccess;
using s23629.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s23629.Services
{
    public class MusicService:IMusicService
    {
       private readonly MusicalContext _context;

        public MusicService(MusicalContext context)
        {
            _context = context;
        }

        public IQueryable<Musician> GetMusician(int id)
        {
            return _context.Musician
                .Include(e => e.MusicianTracks)
                .ThenInclude(e => e.Track);
        }

        public IQueryable<Musician> GetMusicianId(int id)
        {
            return _context.Musician.Select(e=>e.IdMusician = id);
        }

    }
}
