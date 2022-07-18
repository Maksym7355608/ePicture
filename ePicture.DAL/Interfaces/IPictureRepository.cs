using ePicture.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ePicture.DAL.Interfaces
{
    public interface IPictureRepository : IRepository<Picture>
    {
        IEnumerable<Picture> GetByCategory(Category category);
        IEnumerable<Picture> GetByName(string pictureName);
        IEnumerable<Picture> GetByTags(IEnumerable<string> tags);

        Task<IEnumerable<Picture>> GetByCategoryAsync(Category category);
        Task<IEnumerable<Picture>> GetByNameAsync(string pictureName);
        Task<IEnumerable<Picture>> GetByTagsAsync(IEnumerable<string> tags);
    }
}
