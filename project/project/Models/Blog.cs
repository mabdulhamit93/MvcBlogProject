using System;
using System.Data.Entity;

namespace project.Models
{
    public class Blog
    {
        public Blog()
        {
            ReleaseDate = DateTime.Now;
        }
        
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }
        
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}