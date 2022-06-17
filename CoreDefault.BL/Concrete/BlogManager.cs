using CoreDefault.BL.Abstract;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.BL.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetLastThreeBlog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.Id == id);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }
    }
}
