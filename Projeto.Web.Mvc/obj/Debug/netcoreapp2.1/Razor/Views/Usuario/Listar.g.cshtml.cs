#pragma checksum "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca4f1040d69f8ba74d9a3a5c30ac5508f9f1ba98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
using Projeto.Web.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca4f1040d69f8ba74d9a3a5c30ac5508f9f1ba98", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 76, true);
            WriteLiteral("\r\n<a href=\"/Usuario/Cadastrar\">Sair</a>\r\n\r\n<h3>Listagem de Usuários</h3>\r\n\r\n");
            EndContext();
            BeginContext(109, 20, false);
#line 7 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 226, true);
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Email</th>\r\n            <th>Data de Criação</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
         foreach (var item in ViewData["Usuarios"] as List<UsuarioModel>)
        {

#line default
#line hidden
            BeginContext(441, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(502, 7, false);
#line 23 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(509, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(577, 9, false);
#line 26 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(586, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(654, 10, false);
#line 29 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(664, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(732, 36, false);
#line 32 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
               Write(item.DataCriacao.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(768, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 837, "\"", 872, 2);
            WriteAttributeValue("", 844, "/Usuario/Excluir?id=", 844, 20, true);
#line 35 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 864, item.Id, 864, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(873, 56, true);
            WriteLiteral(">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(940, 51, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<select name=\"usuaios\">\r\n");
            EndContext();
#line 43 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
     foreach (var item in ViewData["Usuarios"] as List<UsuarioModel>)
    {

#line default
#line hidden
            BeginContext(1069, 15, true);
            WriteLiteral("        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1084, "\"", 1103, 1);
#line 45 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1092, item.Email, 1092, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1104, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1120, 9, false);
#line 46 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
       Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 21, true);
            WriteLiteral("\r\n        </option>\r\n");
            EndContext();
#line 48 "C:\Users\39235256801\Documents\sprint_4\Projeto.Web.Mvc\Views\Usuario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(1157, 9, true);
            WriteLiteral("</select>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
