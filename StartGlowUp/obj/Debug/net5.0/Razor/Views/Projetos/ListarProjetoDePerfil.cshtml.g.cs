#pragma checksum "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9214d8407ee51e8fea821d4119a3a8c54279c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projetos_ListarProjetoDePerfil), @"mvc.1.0.view", @"/Views/Projetos/ListarProjetoDePerfil.cshtml")]
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
#nullable restore
#line 1 "E:\StartGlowUp\StartGlowUp\Views\_ViewImports.cshtml"
using StartGlowUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\StartGlowUp\StartGlowUp\Views\_ViewImports.cshtml"
using StartGlowUp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9214d8407ee51e8fea821d4119a3a8c54279c9", @"/Views/Projetos/ListarProjetoDePerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460d851391e83043c77055127acbf42f1fe020fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Projetos_ListarProjetoDePerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projetos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Publicacoes/ListarPublicacoes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Usuario/Sair"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Publicacoes/ListarPublicacoesPerfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Projetos/ListarProjetoDePerfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
  
    Usuario u = JsonConvert.DeserializeObject<Usuario>
        (Context.Session.GetString("user").ToString());
    string formatoImg_user = "data:image/jpeg;base64," + Convert.ToBase64String(u.Img);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c95977", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""/CSS/index.css"">
    <link rel=""stylesheet"" href=""/JS/index.js"">
    <script src=""https://kit.fontawesome.com/9ab573c9fb.js"" crossorigin=""anonymous""></script>
    <title>Perfil</title>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c97523", async() => {
                WriteLiteral("\r\n\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg \">\r\n            <div class=\"container\">\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 1031, "\"", 1039, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c98093", async() => {
                    WriteLiteral("<img class=\"logo\" src=\"/IMG/logo1.JPG\">");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"div-links\">\r\n                    <div class=\"link\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c99408", async() => {
                    WriteLiteral("<i id=\"icones\" class=\"fa-solid fa-house-chimney\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"link\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c910692", async() => {
                    WriteLiteral("<i id=\"icones\" class=\"fa-solid fa-arrow-right-to-bracket\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>

        </nav>
    </header>

    <div class=""pagina"">

        <div class=""bio container"">

            <div class=""identificacao conteiner row "">
                <div class=""foto-perfil col-3"">
                    <img");
                BeginWriteAttribute("src", " src=\"", 1870, "\"", 1892, 1);
#nullable restore
#line 51 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
WriteAttributeValue("", 1876, formatoImg_user, 1876, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"nome text-white\">");
#nullable restore
#line 54 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                                          Write(u.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"text-white\">\r\n                        ");
#nullable restore
#line 56 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                   Write(u.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"publi\">\r\n            <hr>\r\n            <br>\r\n\r\n            <div class=\"publicacao-perfil\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c913476", async() => {
                    WriteLiteral("<strong>PUBLICAÇÃO</strong>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9214d8407ee51e8fea821d4119a3a8c54279c914736", async() => {
                    WriteLiteral("<strong>PROJETO</strong>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 73 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
         if (Model != null)
        {


            foreach (Projetos p in Model)
            {
                int i = 0;


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"publicacao container\">\r\n\r\n            <div class=\"identificacao conteiner row \">\r\n                <div class=\"foto-perfil col-3\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 2865, "\"", 2887, 1);
#nullable restore
#line 85 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
WriteAttributeValue("", 2871, formatoImg_user, 2871, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"nome\">");
#nullable restore
#line 88 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                               Write(u.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <div class=\"info\">\r\n                        <p>");
#nullable restore
#line 90 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                      Write(p.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <p> R$ ");
#nullable restore
#line 91 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                          Write(p.Custo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                    <p>\r\n                      ");
#nullable restore
#line 94 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                 Write(p.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 100 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
             foreach (byte[] img in p.Galeria)
            {
                string formatoImg_proj = "data:image/jpeg;base64," + Convert.ToBase64String(p.Galeria[i]);


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"imagens container\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 3521, "\"", 3543, 1);
#nullable restore
#line 105 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
WriteAttributeValue("", 3527, formatoImg_proj, 3527, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n");
#nullable restore
#line 107 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
                i++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 111 "E:\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoDePerfil.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
       

    </div>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
            crossorigin=""anonymous""></script>


");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projetos>> Html { get; private set; }
    }
}
#pragma warning restore 1591