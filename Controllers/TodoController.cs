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
    ViewData["Title"] = "Lista de Tarefas";
    var todos = _context.Todos.ToList();
    return View(todos);
  }

  public IActionResult Create() {
    ViewData["Title"] = "Nova Tarefa";
    return View("Form");
  }
  [HttpPost]
  public IActionResult Create(Todo todo) {
    _context.Todos.Add(todo);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }

}