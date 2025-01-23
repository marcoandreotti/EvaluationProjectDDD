using AutoMapper;
using MediatR;

namespace Application.Common
{
    public abstract class BaseHandler<TRequest, TResult> : IRequestHandler<TRequest, TResult> where TRequest : IRequest<TResult>
    {
        private readonly IMapper _mapper;

        protected BaseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return await HandleRequest(request, cancellationToken);
        }

        protected abstract Task<TResult> HandleRequest(TRequest request, CancellationToken cancellationToken);
    }
}
