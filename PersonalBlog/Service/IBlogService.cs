using PersonalBlog.Models;
using System.Collections.Generic;

namespace PersonalBlog.Service
{
    public interface IBlogService
    {
        List<BlogPost> GetLatestPosts();
        List<BlogPost> GetOlderPosts(int olderBlogPostId);
        string GetPostText(string link);
    }

}
