using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.Abstract;
using CoreDefult.DAL.Concrete;
using CoreDefult.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefult.DAL.EntityFramework
{
    public class EFMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(w => w.SenderUser).Where(w => w.ReveiverId == id).ToList();
            }
        }
    }
}
