﻿using Blazor_Tarefas.Entidades;

namespace Blazor_Tarefas.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa
                {

                    ID = new Guid("f0dcda47-1f23-4538-92e0-a47dcdcc7850"),
                    Descricao = "Fazer o curso de Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2022-08-12")
                },
                new Tarefa
                {
                    ID = new Guid("d21b0f7e-a5a9-45ee-ad9b-eafd911e22fa"),
                    Descricao = "Estudar Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2022-07-11")
                }
            };
        }
    }
}


