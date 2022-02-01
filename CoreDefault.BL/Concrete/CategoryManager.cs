using CoreDefult.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.BL.Concrete
{
    public class CategoryManager // IService'den kalıtım alcak.
    {
        EFCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EFCategoryRepository();
        }
    }
}
