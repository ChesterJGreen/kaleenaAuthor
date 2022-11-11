using System;

namespace kaleenaAuthor.Models
{
    public class Blog
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Body {get;set;}
        public string Image {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
}