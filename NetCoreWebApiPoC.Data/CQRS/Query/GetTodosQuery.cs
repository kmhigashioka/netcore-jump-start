using MediatR;
using Omu.ValueInjecter;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NetCoreWebApiPoC.Domain.Entities;
using NetCoreWebApiPoc.Persistence;

namespace NetCoreWebApiPoC.Data
{
    public class GetTodosQuery : IRequest<List<Todo>>
    {

    }

    public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, List<Todo>>
    {
        private readonly ITodoContext _context;

        public GetTodosQueryHandler(ITodoContext context)
        {
            _context = context;
        }

        public Task<List<Todo>> Handle(GetTodosQuery request, CancellationToken cancellationToken)
        {
            var todos = _context.Todos.Select(t => Mapper.Map<Todo>(t, null)).ToList();

            return Task.FromResult(todos);
        }
    }
}
