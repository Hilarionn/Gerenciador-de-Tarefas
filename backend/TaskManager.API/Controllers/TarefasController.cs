using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Models;

namespace TaskManager.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    private readonly List<Tarefa> _tarefas = new()
    {
        new Tarefa { Id = 1, Titulo = "Estudar C#", Concluida = false },
        new Tarefa { Id = 2, Titulo = "Aprender React", Concluida = false },
        new Tarefa { Id = 3, Titulo = "Conhecer APIs", Concluida = true }
    };

    [HttpGet]
    public IActionResult Listar()
    {
        return Ok(_tarefas);
    }

    [HttpGet("{id}")]
    public IActionResult BuscarPorId(int id)
    {
        var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);

        if (tarefa == null)
        {
            return NotFound();
        }

        return Ok(tarefa);
    }
}