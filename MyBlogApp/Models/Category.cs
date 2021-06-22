using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlogApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string CategoryName { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}