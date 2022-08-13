using Blazor_Tarefas.Entidades;

namespace Blazor_Tarefas.Repositorios
{
    public interface IRepositorio
    {
        List<Tarefa> ObterTarefas();
    }
}
