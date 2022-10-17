using CoreDefault.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefult.DAL.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetListWithBlog();
    }
}
