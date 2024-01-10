using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class SocialMediaManager
    {
        public ICloneablePost CreateAndDisplayPost(ICloneablePost prototype, string author, string content)
        {
            var post = prototype.Clone();
            post.Author = author;
            post.Content = content;
            post.DisplayPostInfo();
            return post;
        }
    }
}
