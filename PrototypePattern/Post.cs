using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Post: ICloneablePost
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int Likes { get; set; }
        public ICloneablePost Clone()
        {
            return new Post
            {
                Author = this.Author,
                Content = this.Content,
                Timestamp = this.Timestamp,
                Likes= this.Likes
            };
        }

        public void DisplayPostInfo()
        {
            Console.WriteLine($"Author: {Author}\nContent: {Content}\nTimestamp: {Timestamp}\nLikes: {Likes}\n");
        }
    }
}
