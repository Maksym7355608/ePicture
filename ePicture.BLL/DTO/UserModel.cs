using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.BLL.DTO
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<PictureModel> Pictures { get; set; }
    }
}
