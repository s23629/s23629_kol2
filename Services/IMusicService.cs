using s23629.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s23629.Services
{
    public interface IMusicService
    {
        IQueryable<Musician> GetMusician(int id);
        IQueryable<Musician> GetMusicianId(int id);
    }
}
