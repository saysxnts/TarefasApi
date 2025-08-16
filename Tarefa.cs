// Tarefa.cs
public class Tarefa
{
    public int Id { get; set; }
    public string? Titulo { get; set; } // O '?' indica que o Titulo pode ser nulo
    public bool Concluida { get; set; }
}