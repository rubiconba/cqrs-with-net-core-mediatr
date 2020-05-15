using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Posts.Commands.CreatePost;
using Application.Posts.Queries.GetAllPosts;

namespace Infrastructure.JsonPlaceholderApi
{
    public class JsonPlaceholderClient : BaseHttpClient
    {
        public JsonPlaceholderClient(HttpClient httpClient) : base(httpClient)
        {
            
        }

        public async Task<IEnumerable<GetAllPostsResponse>> GetAllPosts()
        {
            return await Get<IEnumerable<GetAllPostsResponse>>(Endpoints.Posts.GetAllPosts);
        }

        public async Task<CreatePostResponse> CreatePost(CreatePostRequest request)
        {
            return await Post<CreatePostResponse>(Endpoints.Posts.CreatePost, request);
        }
    }
}