using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlog
    {
        Context c = new Context();
        public void AddCategory(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteCategory(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return c.blogs.Find(id);
        }

        public List<Blog> listAllCategory()
        {
            return c.blogs.ToList();
        }

        public void UpdateCategory(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
