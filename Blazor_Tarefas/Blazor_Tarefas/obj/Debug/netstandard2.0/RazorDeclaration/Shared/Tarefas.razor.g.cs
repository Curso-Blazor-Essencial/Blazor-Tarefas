// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Tarefas.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas;

#line default
#line hidden
#line 7 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Shared;

#line default
#line hidden
#line 8 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Entidades;

#line default
#line hidden
#line 9 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Repositorios;

#line default
#line hidden
    public partial class Tarefas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 37 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
      

    [Parameter] public List<Tarefa> tarefas { get; set; }
    [Parameter] public string Titulo { get; set; }

    private string novaTarefa = "";

    //instancia do componente Confirma 
    Confirma confirmacao;

    Tarefa tarefaRemover;

    private void RemoveTarefa(Tarefa tarefa)
    {
        //confirmacao.Exibir();
        //tarefaRemover = tarefa;
        //var resultado =
        //    await js.InvokeAsync<bool>("confirm", "Excluir Tarefa ?");

        var resultado = ((IJSInProcessRuntime)js).Invoke<bool>("confirm", "Excluir esta tarefa ?");

        if(resultado)
        {
            tarefas.Remove(tarefa);
            //await js.InvokeVoidAsync("alert", "Tarefa excluida com sucesso");
            //await js.InvokeAsync<object>("MostraAlerta", "Ok, tarefa excluida !!!");
        }
    }

    void RemoverTarefaConfirmacao()
    {
        tarefas.Remove(tarefaRemover);
        tarefaRemover = null;
        confirmacao.Ocultar();
    }

    void CancelaConfirmacao()
    {
        confirmacao.Ocultar();
        tarefaRemover = null;
    }

    static int totalTarefas = 0;

    async void AdicionarNovaTarefa()
    {
        if (!string.IsNullOrWhiteSpace(novaTarefa))
        {
            tarefas.Add(new Tarefa
            {
                DataCriacao = DateTime.Now,
                Descricao = novaTarefa,
                ID = Guid.NewGuid()
            });
            novaTarefa = "";
            totalTarefas = tarefas.Count();
            await js.InvokeVoidAsync("getTotalTarefas");
        }
    }
    [JSInvokable]
    public static Task<int> ObterTotalTarefas()
    {
        return Task.FromResult(totalTarefas);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
