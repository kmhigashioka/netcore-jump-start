using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using NetCoreWebApiPoC.Data;
using NetCoreWebApiPoC.Data.Context;
using NetCoreWebApiPoC.Domain;
using Xunit;

namespace NetCoreWebApiPoC.Test.CQRS.Query
{
    public class GetTodosQueryTests
    {
        [Fact]
        public void Get_Todos()
        {
            var mockContext = new Mock<ITodoContext>();
            var mockDbSetTodos = new Mock<DbSet<Todo>>();
            mockContext.Setup(t => t.Todos).Returns(mockDbSetTodos.Object);


            //var mediator = new Mediator().Send(new GetTodosQuery());
        }
    }
}
