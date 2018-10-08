using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataLog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

        
    }
}