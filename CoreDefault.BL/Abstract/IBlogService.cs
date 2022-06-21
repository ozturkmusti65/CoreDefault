using CoreDefault.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.BL.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListByWriter(int id);
    }
}
