using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s23629.Models
{
    public class MusicLabel
    {
        public int IdMusicLabel { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Album { get; set; }
    }
}
