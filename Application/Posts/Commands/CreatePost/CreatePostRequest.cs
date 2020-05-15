using Application.Common.Mappings;
using AutoMapper;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostRequest : IMapFrom<CreatePostCommand>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePostCommand, CreatePostRequest>();
        }
    }
}