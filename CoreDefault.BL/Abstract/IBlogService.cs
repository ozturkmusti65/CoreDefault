﻿using CoreDefault.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.BL.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);
    }
}