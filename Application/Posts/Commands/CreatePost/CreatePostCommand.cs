using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<CreatePostVm>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        
        public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, CreatePostVm>
        {
            private readonly IPostsApi _postsApi;
            private readonly IMapper _mapper;

            public CreatePostCommandHandler(IPostsApi postsApi, IMapper mapper)
            {
                _postsApi = postsApi;
                _mapper = mapper;
            }
            
            public async Task<CreatePostVm> Handle(CreatePostCommand request, CancellationToken cancellationToken)
            {
                var response = await _postsApi.CreatePost(_mapper.Map<CreatePostRequest>(request));
                return _mapper.Map<CreatePostVm>(response);
            }
        }
    }
}