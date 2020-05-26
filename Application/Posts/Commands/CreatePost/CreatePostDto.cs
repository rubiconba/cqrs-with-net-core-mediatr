using Application.Common.Mappings;
using AutoMapper;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostDto : IMapFrom<CreatePostResponse>
    {
        public int Id { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePostResponse, CreatePostDto>();
        }
    }
}