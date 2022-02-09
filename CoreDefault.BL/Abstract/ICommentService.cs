using CoreDefault.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.BL.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void DeleteComment(Comment comment);
        //void UpdateComment(Comment comment);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}
