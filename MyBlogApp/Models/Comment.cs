using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlogApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public virtual Article Article { get; set; }
        [NotMapped]
        public int ArticleId { get; set; }
    }
}