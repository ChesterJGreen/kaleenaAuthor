using System;

namespace kaleenaAuthor.Models
{
    public class Book
    {
        public int Id {get; set;}
        public string Name {get;set;}
        public int ProgressPercent {get;set;}
        public string Image {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt { get;set;}

    }
}