﻿namespace Blazor_Tarefas.Entidades
{
    public class Tarefa
    {
        public Guid ID { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
