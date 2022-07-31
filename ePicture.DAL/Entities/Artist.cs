using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.DAL.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public User User { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
