using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.BLL.DTO
{
    public class PictureModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DAL.Entities.Category Category { get; set; }
        public string Description { get; set; }
        public IEnumerable<TagModel> Tags { get; set; }
    }
}
