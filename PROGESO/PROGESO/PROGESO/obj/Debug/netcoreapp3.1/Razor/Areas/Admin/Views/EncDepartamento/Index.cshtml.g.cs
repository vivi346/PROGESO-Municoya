#pragma checksum "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645ffd8b107a4b16a865ca3d6928e72729c6e955"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EncDepartamento_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/EncDepartamento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645ffd8b107a4b16a865ca3d6928e72729c6e955", @"/Areas/Admin/Views/EncDepartamento/Index.cshtml")]
    public class Areas_Admin_Views_EncDepartamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROGESO.Models.EncDepartamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
</div>
<!-- Start header -->
<div class=""all-page-title page-breadcrumb"">
    <div class=""container text-center"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1>
                    Encargados
                </h1>
            </div>
        </div>
    </div>
</div>
<!-- End header -->

<div class=""border backgroundWhite"">
    <div class=""row"">
        <div class=""col-6"">

        </div>
        <div class=""col-6 text-right"">
            ");
#nullable restore
#line 32 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
       Write(Html.Partial("_CreateButtonPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 37 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped border"">
                <tr class=""table-secondary"">
                    <th>
                        <label for=""IDEncargado"">Encargado</label>
                    </th>

                    <th>
                        <label for=""Correo"">Correo</label>
                    </th>
                    <th>
                        <label for=""Nombre"">Nombre</label>
                    </th>

                    <th>
                        <label for=""Apellido1"">Apellido1</label>
                    </th>
                    <th>
                        <label for=""Apellido2"">Apellido2</label>
                    </th>
                    <th>
                        <label for=""Departament.Name"">Departamento</label>
                    </th>
                    <th></th>
                    <th></th>
                </tr>

");
#nullable restore
#line 65 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Apellido1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Apellido2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Departament.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645ffd8b107a4b16a865ca3d6928e72729c6e9558990", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2642, "~/Admin/EncDepartamento/Edit/", 2642, 29, true);
#nullable restore
#line 87 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
AddHtmlAttributeValue("", 2671, item.Id, 2671, 8, false);

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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645ffd8b107a4b16a865ca3d6928e72729c6e95510686", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2753, "~/Admin/EncDepartamento/Delete/", 2753, 31, true);
#nullable restore
#line 88 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
AddHtmlAttributeValue("", 2784, item.Id, 2784, 8, false);

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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645ffd8b107a4b16a865ca3d6928e72729c6e95512385", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2867, "~/Admin/EncDepartamento/Details/", 2867, 32, true);
#nullable restore
#line 89 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
AddHtmlAttributeValue("", 2899, item.Id, 2899, 8, false);

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
            WriteLiteral("\r\n\r\n                        </td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 99 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"color:black\">No hay encargados</p>\r\n");
#nullable restore
#line 103 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<div class=\"col-6\">\r\n    ");
#nullable restore
#line 111 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Index.cshtml"
Write(Html.Partial("_BackButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROGESO.Models.EncDepartamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
