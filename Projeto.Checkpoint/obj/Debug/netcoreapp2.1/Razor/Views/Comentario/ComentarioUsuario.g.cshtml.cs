#pragma checksum "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\ComentarioUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3ba7e7411c7e6ead42308db5451b6e90c97b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_ComentarioUsuario), @"mvc.1.0.view", @"/Views/Comentario/ComentarioUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/ComentarioUsuario.cshtml", typeof(AspNetCore.Views_Comentario_ComentarioUsuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3ba7e7411c7e6ead42308db5451b6e90c97b58", @"/Views/Comentario/ComentarioUsuario.cshtml")]
    public class Views_Comentario_ComentarioUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\ComentarioUsuario.cshtml"
  
    ViewBag.Title = "Comentários do Usuário";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(84, 4061, true);
            WriteLiteral(@"
<link href=""/css/style.css"" rel=""stylesheet"" type=""text/css"">

<header>
        <div class=""background-topos"">
            <div class=""logo"">
                <img class=""none none2"" src=""img/logo.png"" alt=""#"">
            </div>
            <div class=""content-topo"">
                <div class=""login none none2"">
                    <a href=""Usuario/Login"">Login</a>
                </div>
                <div class=""login none none2"">
                    <a href=""Usuario/Cadastrar"">Cadastrar</a>
                </div>
                <nav class=""nav-bar"">
                    <ul>
                        <li>
                            <a href=""http://localhost:5000"">
                                <div class=""link m-res"">
                                    Home
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""sobre.html"">
                                <div class=""link m-res"">
          ");
            WriteLiteral(@"                          Sobre Nós
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""Comentario/ComentarioUsuario"">
                                <div class=""link m-res"">
                                    Comentários
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""contato.html"">
                                <div class=""link"">
                                    Fale Conosco
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""duvidas.html"">
                                <div class=""link"">
                                    Dúvidas Frequentes
                                </div>
                            </a>
                        </li>
          ");
            WriteLiteral(@"          </ul>
                </nav>
            </div>
            <!-- fim content-topo -->
        </div>
        <!-- fim do background-topo -->
    </header>

    <main>
        <div class=""comentario"">
            <h1>Comentários</h1>
            <form class=""area-comentario""> 
                <label>Escreva seu comentario sobre o CheckList:<br>
                    <textarea name=""texto"" placeholder=""Digite aqui..."" required=""true"" maxlength=""100"" minlength=""1"">
                    </textarea>
                </label><br> 
                <input class=""botao"" type=""submit"" value=""Enviar"">
            </form>

        </div>

        <div class=""comentarios"">
            <div class=""caixa-comen"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>

            <div class=""caixa-com");
            WriteLiteral(@"en"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>
        </div>
        <div class=""comentarios"">

            <div class=""caixa-comen"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>

            <div class=""caixa-comen"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>
        </div>
    </main>");
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
