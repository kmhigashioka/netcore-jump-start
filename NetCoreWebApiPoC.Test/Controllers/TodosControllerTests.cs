using MediatR;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiPoC.Application.Todos.Queries.GetTodos;
using NetCoreWebApiPoC.Domain.Entities;
using NetCoreWebApiPoC.WebUI.Controllers;
using Xunit;

namespace NetCoreWebApiPoC.Test.Controllers
{
    public class TodosControllerTests
    {
        [Fact]
        public void Get_Todos()
        {
            var mockMediator = new Mock<IMediator>();
            mockMediator
                .Setup(t => t.Send(It.IsAny<GetTodosQuery>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(new List<Todo> {
                    new Todo
                    {
                        Id = 1000,
                        Task = "Write unit test",
                        Done = true
                    }
                }));
            var controller = new TodosController(mockMediator.Object);


            var result = controller.GetTodos();


            var okResult = Assert.IsType<OkObjectResult>(result);
            var todos = Assert.IsType<List<Todo>>(okResult.Value);
            Assert.Single(todos);
        }
    }
}
