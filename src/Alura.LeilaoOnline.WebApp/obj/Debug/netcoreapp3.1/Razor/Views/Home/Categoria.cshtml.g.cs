#pragma checksum "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d8cc0c8833a38cb6de2827b81b6571328b2dfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categoria), @"mvc.1.0.view", @"/Views/Home/Categoria.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d8cc0c8833a38cb6de2827b81b6571328b2dfd", @"/Views/Home/Categoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73feb13f73acfcd6ba9bb4378b1af15ffd8e98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Categoria>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
  
    Layout = "_AreaPublica";
    ViewData["Title"] = "Categoria";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 8 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<span class=\"image main img-categoria\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52d8cc0c8833a38cb6de2827b81b6571328b2dfd4103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 170, "~/", 170, 2, true);
#nullable restore
#line 10 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
AddHtmlAttributeValue("", 172, Model.Imagem, 172, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
AddHtmlAttributeValue("", 192, Model.Descricao, 192, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</span>\n<h3>Leilões em andamento</h3>\n<section class=\"tiles\">\n");
#nullable restore
#line 14 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
 foreach (var leilao in Model.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Pregao))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <article class=\"leilao\">\n        <span class=\"image\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 438, "\"", 461, 1);
#nullable restore
#line 18 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 444, leilao.PosterUrl, 444, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 462, "\"", 482, 1);
#nullable restore
#line 18 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 468, leilao.Titulo, 468, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </span>\n        <h4>");
#nullable restore
#line 20 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
       Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <div class=\"content\">\n            <p>");
#nullable restore
#line 22 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
          Write(leilao.Descricao.Substring(0,100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </article>\n");
#nullable restore
#line 25 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Categoria.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
