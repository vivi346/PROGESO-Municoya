#pragma checksum "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7311a2041db736c0de07d9dcc0e788b19fc6be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Proveedores_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Proveedores/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7311a2041db736c0de07d9dcc0e788b19fc6be", @"/Areas/Admin/Views/Proveedores/Index.cshtml")]
    public class Areas_Admin_Views_Proveedores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROGESO.Models.Proveedores>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
  
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
                    Proveedores
                </h1>
            </div>
        </div>
    </div>
</div>
<!-- End header -->

<div class=""border backgroundWhite"">
    <div class=""row"">
        <div class=""col-6"">
");
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-6 text-right\">\r\n            ");
#nullable restore
#line 30 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
       Write(Html.Partial("_CreateButtonPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 35 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-sm table-striped border"">
                <tr class=""table-secondary"">
                    <th>
                        <label for=""ced_juridica"">Ced_Juridica</label>
                    </th>

                    <th>
                        <label for=""nombre"">Nombre Proveedor</label>
                    </th>
                    <th></th>
                    <th></th>
                </tr>

");
#nullable restore
#line 50 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
               Write(Html.DisplayFor(m => item.ced_juridica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
               Write(Html.DisplayFor(m => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7311a2041db736c0de07d9dcc0e788b19fc6be6871", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1662, "~/Admin/Proveedores/Edit/", 1662, 25, true);
#nullable restore
#line 60 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
AddHtmlAttributeValue("", 1687, item.ced_juridica, 1687, 18, false);

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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7311a2041db736c0de07d9dcc0e788b19fc6be8571", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1778, "~/Admin/Proveedores/Delete/", 1778, 27, true);
#nullable restore
#line 61 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
AddHtmlAttributeValue("", 1805, item.ced_juridica, 1805, 18, false);

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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec7311a2041db736c0de07d9dcc0e788b19fc6be10273", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1897, "~/Admin/Proveedores/Details/", 1897, 28, true);
#nullable restore
#line 62 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
AddHtmlAttributeValue("", 1925, item.ced_juridica, 1925, 18, false);

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
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 70 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"color:black\">No hay proveedores</p>\r\n");
#nullable restore
#line 74 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n    <div class=\"col-6\">\r\n        ");
#nullable restore
#line 83 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Index.cshtml"
   Write(Html.Partial("_BackButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n\r\n<!--<div class=\"col-6\">-->\r\n");
            WriteLiteral(@"
<!--</div>-->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROGESO.Models.Proveedores>> Html { get; private set; }
    }
}
#pragma warning restore 1591
