using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Posts;
using Application.Posts.Commands.CreatePost;
using Application.Posts.Queries.GetAllPosts;

namespace Infrastructure.JsonPlaceholderApi
{
    public class PostsApi : IPostsApi
    {
        private readonly JsonPlaceholderClient _client;

        public PostsApi(JsonPlaceholderClient client)
        {
            _client = client;
        }
        
        public async Task<IEnumerable<GetAllPostsResponse>> GetAllPosts()
        {
            return await _client.GetAllPosts();
        }

        public async Task<CreatePostResponse> CreatePost(CreatePostRequest request)
        {
            return await _client.CreatePost(request);
        }
    }
}