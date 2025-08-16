// Controllers/TarefasController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController] // Anotação que identifica esta classe como um Controller de API
[Route("api/[controller]")] // Define a rota base como "api/tarefas"
public class TarefasController : ControllerBase
{
    // Nosso "banco de dados" em memória. 'static' garante que a lista seja a mesma para todas as requisições.
    private static List<Tarefa> tarefas = new List<Tarefa>
    {
        new Tarefa { Id = 1, Titulo = "Aprender ASP.NET Core", Concluida = false },
        new Tarefa { Id = 2, Titulo = "Construir a primeira API", Concluida = true }
    };
    private static int nextId = 3;

    // GET: api/tarefas
    [HttpGet]
    public ActionResult<IEnumerable<Tarefa>> GetTodasAsTarefas()
    {
        return Ok(tarefas); // Retorna a lista completa de tarefas com status 200 OK
    }

    // GET: api/tarefas/1
    [HttpGet("{id}")]
    public ActionResult<Tarefa> GetTarefaPorId(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
        {
            return NotFound(); // Retorna 404 Not Found se a tarefa não existir
        }
        return Ok(tarefa);
    }

    // POST: api/tarefas
    [HttpPost]
    public ActionResult<Tarefa> CriarTarefa(Tarefa novaTarefa)
    {
        novaTarefa.Id = nextId++;
        tarefas.Add(novaTarefa);

        // Retorna 201 Created com a localização da nova tarefa e o objeto criado
        return CreatedAtAction(nameof(GetTarefaPorId), new { id = novaTarefa.Id }, novaTarefa);
    }

    // PUT: api/tarefas/1
    [HttpPut("{id}")]
    public IActionResult AtualizarTarefa(int id, Tarefa tarefaAtualizada)
    {
        var tarefaExistente = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefaExistente == null)
        {
            return NotFound();
        }

        tarefaExistente.Titulo = tarefaAtualizada.Titulo;
        tarefaExistente.Concluida = tarefaAtualizada.Concluida;

        return NoContent(); // Retorna 204 No Content, indicando sucesso sem corpo de resposta
    }

    // DELETE: api/tarefas/1
    [HttpDelete("{id}")]
    public IActionResult DeletarTarefa(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
        {
            return NotFound();
        }

        tarefas.Remove(tarefa);
        return NoContent(); // Retorna 204 No Content
    }
}