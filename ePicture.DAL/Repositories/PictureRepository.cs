using ePicture.DAL.EF;
using ePicture.DAL.Entities;
using ePicture.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePicture.DAL.Repositories
{
    public class PictureRepository : IPictureRepository
    {
        private ePictureContext context;

        public PictureRepository(ePictureContext context)
        {
            this.context = context;
        }

        public void Add(Picture entity)
        {
            context.Pictures.Add(entity);
        }

        public async Task AddAsync(Picture entity)
        {
            await context.Pictures.AddAsync(entity);
        }

        public void Delete(Picture entity)
        {
            context.Pictures.Remove(entity);
        }

        public async Task DeleteAsync(Picture entity)
        {
            await Task.Run(() => Delete(entity));
        }

        public IEnumerable<Picture> GetAll()
        {
            return context.Pictures;
        }

        public async Task<IEnumerable<Picture>> GetAllAsync()
        {
            return await Task.Run(() => GetAll());
        }

        public IEnumerable<Picture> GetByCategory(Category category)
        {
            return context.Pictures.Where(p => p.Category == category);
        }

        public async Task<IEnumerable<Picture>> GetByCategoryAsync(Category category)
        {
            return await Task.Run(() => GetByCategory(category));
        }

        public Picture GetById(int id)
        {
            return context.Pictures.Find(id);
        }

        public async Task<Picture> GetByIdAsync(int id)
        {
            return await context.Pictures.FindAsync(id);
        }

        public IEnumerable<Picture> GetByName(string pictureName)
        {
            return context.Pictures.Where(p => p.Name == pictureName);
        }

        public async Task<IEnumerable<Picture>> GetByNameAsync(string pictureName)
        {
            return await Task.Run(() => GetByName(pictureName));
        }

        public IEnumerable<Picture> GetByTags(IEnumerable<string> tags)
        {
            return context.Pictures.Where(p => p.Tags == tags);
        }

        public async Task<IEnumerable<Picture>> GetByTagsAsync(IEnumerable<string> tags)
        {
            return await Task.Run(() => GetByTags(tags));
        }

        public void Update(Picture entity)
        {
            context.Pictures.Update(entity);
        }

        public async Task UpdateAsync(Picture entity)
        {
            await Task.Run(() => Update(entity));
        }
    }
}
