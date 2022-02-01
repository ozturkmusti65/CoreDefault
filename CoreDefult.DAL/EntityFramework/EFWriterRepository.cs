using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.Abstract;
using CoreDefult.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefult.DAL.EntityFramework
{
    public class EFWriterRepository : GenericRepository<Writer>, IWriterDal
    {
    }
}
