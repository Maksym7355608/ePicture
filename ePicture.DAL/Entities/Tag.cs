using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.DAL.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public int PictureId { get; set; }
        public string NameTag { get; set; }
    }
}
