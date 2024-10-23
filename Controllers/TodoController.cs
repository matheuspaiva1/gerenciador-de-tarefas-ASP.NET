using Microsoft.AspNetCore.Mvc;
using TWtodos2.Models;

namespace TWtodos2.Controllers;

public class TodoController : Controller {
  public IActionResult Index() {
    var todo = new Todo{
      Id = 1,
      Title = "Estudar c#",
      CreatedAt = DateTime.Now,
      DeadLine = DateOnly.FromDateTime(DateTime.Now)

    };
    return View(todo);
  }
}