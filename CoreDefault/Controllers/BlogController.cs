using CoreDefault.BL.Concrete;
using CoreDefault.BL.ValidationRules;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.Concrete;
using CoreDefult.DAL.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CoreDefault.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetListWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult ReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBm(writerId);
            return View(values);
        }

        public void CategoryList()
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryList();
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            CategoryList();
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();

            if (result.IsValid)
            {
                blog.Status = true;
                blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterId = writerId;
                bm.TAdd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int Id)
        {
            var blogValue = bm.TGetById(Id);
            bm.TDelete(blogValue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = bm.TGetById(id);
            CategoryList();
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();
            p.WriterId = writerId;
            p.Status = true;
            p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
