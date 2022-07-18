using ePicture.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.DAL.Interfaces
{
    public interface IPictureRepository : IRepository<Picture>
    {
        IEnumerable<Picture> GetByCategory(Category category);
        IEnumerable<Picture> GetByName(string pictureName);
        IEnumerable<Picture> GetByTags(IEnumerable<string> tags);
    }
}
