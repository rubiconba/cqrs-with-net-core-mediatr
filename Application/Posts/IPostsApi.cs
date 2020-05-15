using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Posts.Commands.CreatePost;
using Application.Posts.Queries.GetAllPosts;

namespace Application.Posts
{
    public interface IPostsApi
    {
        Task<IEnumerable<GetAllPostsResponse>> GetAllPosts();
        Task<CreatePostResponse> CreatePost(CreatePostRequest request);
    }
}