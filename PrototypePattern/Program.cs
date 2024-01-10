using PrototypePattern;

ICloneablePost originalPost= new Post
{
    Author = "John Doe",
    Content = "This is a post",
    Timestamp = DateTime.Now,
    Likes = 10
};

SocialMediaManager manager = new SocialMediaManager();
ICloneablePost post1=manager.CreateAndDisplayPost(originalPost, "Jane Doe", "This is a shared post");
ICloneablePost post2=manager.CreateAndDisplayPost(originalPost, "John Smith", "This is a shared post");

Console.WriteLine("Original post:");
originalPost.DisplayPostInfo();
Console.WriteLine("Post 1:");
post1.DisplayPostInfo();
Console.WriteLine("Post 2:");
post2.DisplayPostInfo();



