// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Tarefas.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/evento1")]
    public partial class Evento1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 9 "C:\Users\Usuario\Downloads\20_Blazor_Tarefas_Invoke_JavaScript\Blazor_Tarefas\Blazor_Tarefas\Pages\Evento1.razor"
       
    private string cor = "red";

    void TeclaPressionada(KeyboardEventArgs args)
    {
        if(args.Key =="A" || args.Key=="a")
        {
            cor = "blue";
            Console.WriteLine("A tecla A/a foi pressionada");
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
