using CoreDefault.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.BL.Abstract
{
    public interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsletter);
    }
}
