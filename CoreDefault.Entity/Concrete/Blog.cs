﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefault.Entity.Concrete
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ThumbnailImage { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public int Id { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }

    }
}