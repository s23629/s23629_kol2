using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s23629.Models
{
    public class MusicianDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public List<Record> Records { get; set; }
    }
    public class Record {
        public string TrackName { get; set; }

        public float Duration { get; set; }

        public int? IdMusicAlbum { get; set; }
    }
}
