#pragma checksum "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0174096c1e2133067bb1630ab98350516d328a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Busca), @"mvc.1.0.view", @"/Views/Home/Busca.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0174096c1e2133067bb1630ab98350516d328a7", @"/Views/Home/Busca.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73feb13f73acfcd6ba9bb4378b1af15ffd8e98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Busca : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leilao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
  
    Layout = "_AreaPublica";
    ViewData["Title"] = "Busca";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Você pesquisou por \"");
#nullable restore
#line 8 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
                   Write(ViewData["termo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h1>\n<h3>Leilões encontrados</h3>\n<section class=\"tiles\">\n");
#nullable restore
#line 11 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
     foreach (var leilao in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article class=\"leilao\">\n            <span class=\"image\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 325, "\"", 348, 1);
#nullable restore
#line 15 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
WriteAttributeValue("", 331, leilao.PosterUrl, 331, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 349, "\"", 369, 1);
#nullable restore
#line 15 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
WriteAttributeValue("", 355, leilao.Titulo, 355, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </span>\n            <h4>");
#nullable restore
#line 17 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
           Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <div class=\"content\">\n                <p>");
#nullable restore
#line 19 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
              Write(leilao.Descricao.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </article>\n");
#nullable restore
#line 22 "D:\PROJETOS\C#\SOLID - Alura\SOLID\solid-csharp-roteiro-aula-lsp-isp\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leilao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
