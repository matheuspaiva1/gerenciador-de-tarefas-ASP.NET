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
    if(ModelState.IsValid){
      todo.CreatedAt = DateTime.Now;
      _context.Todos.Add(todo);
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    ViewData["Title"] = "Nova tarefa";

    return View("Form", todo);
  }

  public IActionResult Edit(int id){
    var todo = _context.Todos.Find(id);
    ViewData["Title"] = "Editar tarefa";
    return View("Form", todo);
  }
  [HttpPost]
  public IActionResult Edit(Todo todo){
    if(ModelState.IsValid){
      _context.Todos.Update(todo);
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
  }

  public IActionResult Delete(int id){
    var todo = _context.Todos.Find(id);
    ViewData["Title"] = "Excluir Tarefa";
    return View(todo);
  }
  [HttpPost]
  public IActionResult Delete(Todo todo){
    _context.Todos.Remove(todo);
    _context.SaveChanges();
    return RedirectToAction(nameof(Index));
  }

}