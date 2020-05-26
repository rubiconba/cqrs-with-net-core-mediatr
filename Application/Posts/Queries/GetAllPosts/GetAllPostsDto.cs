using Application.Common.Mappings;
using AutoMapper;

namespace Application.Posts.Queries.GetAllPosts
{
    public class GetAllPostsDto : IMapFrom<GetAllPostsResponse>
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetAllPostsResponse, GetAllPostsDto>();
        }
    }
}