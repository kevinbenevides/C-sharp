#pragma checksum "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Usuario\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df0ab732f219a0badc8538b2249621d68084664d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Contato), @"mvc.1.0.view", @"/Views/Usuario/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Contato.cshtml", typeof(AspNetCore.Views_Usuario_Contato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0ab732f219a0badc8538b2249621d68084664d", @"/Views/Usuario/Contato.cshtml")]
    public class Views_Usuario_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"pt-br\">\n\n");
            EndContext();
            BeginContext(37, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae3d74f73ca74df4a95db2138ab80707", async() => {
                BeginContext(43, 198, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"/css/style.css\">\n    <title>Checkpoint - Fale Conosco</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(248, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(250, 4934, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff99365bed64171b226f97c22ebdd04", async() => {
                BeginContext(256, 4921, true);
                WriteLiteral(@"
    <header>
        <div class=""background-topos"">
            <div class=""logo"">
                <img class=""none none2"" src=""/img/logo.png"" alt=""#"">
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
                            <a href=""/Usuario/Sobre"">
                                <div class=""link m-res"">
                                    Sobre Nós
                             ");
                WriteLiteral(@"   </div>
                            </a>
                        </li>
                        <li>
                            <a href=""/Comentario/Comentar"">
                                <div class=""link m-res"">
                                    Comentários
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""/Usuario/Contato"">
                                <div class=""link"">
                                    Fale Conosco
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""/Usuario/Duvidas"">
                                <div class=""link"">
                                    Dúvidas Frequentes
                                </div>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>
       ");
                WriteLiteral(@"     <!-- fim content-topo -->
        </div>
        <!-- fim do background-topo -->
    </header>
    <main>
        <div class=""contato-prin"">
            <h1>Fale Conosco</h1>
            <div class=""formulario"">
                <form>
                    <h3>Digite seu Nome:</h3>
                    <label class=""all-inputs"">
                        <input type=""text"" placeholder=""Digite o seu nome"" minlength=""5"" maxlength=""20"" required>
                    </label>
                    <br>
                    <br>

                    <h3>Digite seu E-mail:</h3>
                    <label class=""all-inputs"">
                        <input type=""email"" placeholder=""Digite o seu e-mail"" minlength=""15"" maxlength=""23"" required>
                    </label>
                    <br>
                    <br>

                    <h3>Telefone:</h3>
                    <label class=""all-inputs"">
                        <input type=""tel"" placeholder=""Digite o seu telefone"" minlength=""8"" maxlength=""11"" required>
 ");
                WriteLiteral(@"                   </label>
                    <br>
                    <br>

                    <h3>Mensagem:</h3>
                    <label>
                        <textarea class=""box-text"" placeholder=""Digite sua mensagem..."" minlength=""1"" maxlength=""100"" required></textarea>
                    </label>
                    <br>
                    <br>
                    <input class=""btn"" type=""button"" value=""Enviar"">
                </form>
                <div class=""none"">
                    <div id=""mapa"">
                        <h2>Endereço:</h2>
                        <div class=""mapouter "">
                            <div class=""gmap_canvas"">
                                <iframe width=""300"" height=""300"" id=""gmap_canvas"" src=""https://maps.google.com/maps?q=SENAI%20de%20Inform%C3%A1tica&t=&z=15&ie=UTF8&iwloc=&output=embed""></iframe>
                                <a href=""https://www.pureblack.de""></a>
                            </div>
                        </div>
                  ");
                WriteLiteral(@"  </div>
                </div>
            </div>


        </div>
    </main>
    <footer class=""rodape"">
        <ul class=""none none2"">
            <li>Sobre</li>
            <li>Planos</li>
            <li>Contato</li>
        </ul>
        <ul class=""none none2"">
            <li>Dúvidas</li>
            <li>Login</li>
            <li>Cadastro</li>
        </ul>
        <div class=""redes-sociais none none2 "">
            <h3>Redes Sociais:</h3>
            <a href=""#"">
                <img src=""/img/facebook.png"" alt=""#"">
            </a>
            <a href=""https://github.com/felipepoliveira"" target=""_blank"">
                <img id=""git"" src=""/img/git.png"" alt=""#"">
            </a>
            <a href=""#"">
                <img src=""/img/instagram.png"" alt=""#"">
            </a>
        </div>
    </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5184, 9, true);
            WriteLiteral("\n\n</html>");
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