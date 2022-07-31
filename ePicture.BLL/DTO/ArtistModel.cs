using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.BLL.DTO
{
    public class ArtistModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<PictureModel> Pictures { get; set; }
    }
}
