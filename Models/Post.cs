using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DateOfPublish { get; set; }
        public string Context { get; set; }

    }
}