using MediatR;
using NetCoreWebApiPoC.Data.Context;
using NetCoreWebApiPoC.Domain;
using Omu.ValueInjecter;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NetCoreWebApiPoC.Data
{
    public class GetTodosQuery : IRequest<List<Todo>>
    {

    }

    public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, List<Todo>>
    {
        private readonly TodoContext _context;

        public GetTodosQueryHandler(TodoContext context)
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
