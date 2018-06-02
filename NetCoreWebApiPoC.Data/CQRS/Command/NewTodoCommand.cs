using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetCoreWebApiPoC.Data.Context;
using NetCoreWebApiPoC.Data.Dto;
using NetCoreWebApiPoC.Domain;
using Omu.ValueInjecter;

namespace NetCoreWebApiPoC.Data.CQRS.Command
{
    public class NewTodoCommand : IRequest<TodoDto>
    {
        public TodoDto Todo { get; set; }
    }

    public class NewTodoCommandHandler : IRequestHandler<NewTodoCommand, TodoDto>
    {
        private readonly TodoContext _context;

        public NewTodoCommandHandler(TodoContext context)
        {
            _context = context;
        }
        public Task<TodoDto> Handle(NewTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = Mapper.Map<Todo>(request.Todo);
            _context.Add(todo);
            _context.SaveChanges();

            return Task.FromResult(Mapper.Map<TodoDto>(todo));
        }
    }
}
