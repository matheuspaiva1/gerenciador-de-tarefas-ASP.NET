using Microsoft.AspNetCore.Mvc;
using TWtodos2.Contexts;
using TWtodos2.Models;

namespace TWtodos2.Controllers;

public class TodoController : Controller {
  private readonly TWTodosContext _context;

  public TodoController(TWTodosContext context) {
    _context = context;
  }
  public IActionResult Index() {
    var todos = _context.Todos.ToList();
    return View(todos);
  }
}