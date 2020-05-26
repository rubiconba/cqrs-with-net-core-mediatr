using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace Application.Posts.Queries.GetAllPosts
{
    public class GetAllPostsQuery : IRequest<IEnumerable<GetAllPostsDto>>
    {
        public class GetAllPostsQueryHandler : IRequestHandler<GetAllPostsQuery, IEnumerable<GetAllPostsDto>>
        {
            private readonly IPostsApi _postsApi;
            private readonly IMapper _mapper;

            public GetAllPostsQueryHandler(IPostsApi postsApi, IMapper mapper)
            {
                _postsApi = postsApi;
                _mapper = mapper;
            }
            
            public async Task<IEnumerable<GetAllPostsDto>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
            {
                var posts = await _postsApi.GetAllPosts();
                return _mapper.Map<IEnumerable<GetAllPostsDto>>(posts);
            }
        }
    }
}