using ePicture.DAL.EF;
using ePicture.DAL.Entities;
using ePicture.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void Delete(Picture entity)
        {
            context.Pictures.Remove(entity);
        }

        public IEnumerable<Picture> GetAll()
        {
            return context.Pictures;
        }

        public IEnumerable<Picture> GetByCategory(Category category)
        {
            return context.Pictures.Where(p => p.Category == category);
        }

        public Picture GetById(int id)
        {
            return context.Pictures.Find(id);
        }

        public IEnumerable<Picture> GetByName(string pictureName)
        {
            return context.Pictures.Where(p => p.Name == pictureName);
        }

        public IEnumerable<Picture> GetByTags(IEnumerable<string> tags)
        {
            return context.Pictures.Where(p => p.Tags == tags);
        }

        public void Update(Picture entity)
        {
            context.Pictures.Update(entity);
        }
    }
}
