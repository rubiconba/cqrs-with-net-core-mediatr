using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<CreatePostDto>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        
        public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, CreatePostDto>
        {
            private readonly IPostsApi _postsApi;
            private readonly IMapper _mapper;

            public CreatePostCommandHandler(IPostsApi postsApi, IMapper mapper)
            {
                _postsApi = postsApi;
                _mapper = mapper;
            }
            
            public async Task<CreatePostDto> Handle(CreatePostCommand request, CancellationToken cancellationToken)
            {
                var response = await _postsApi.CreatePost(_mapper.Map<CreatePostRequest>(request));
                return _mapper.Map<CreatePostDto>(response);
            }
        }
    }
}