#pragma checksum "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee6ee113fb4d7e0aa4500aa017b2ffb7a55f3f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Producto_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Producto/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee6ee113fb4d7e0aa4500aa017b2ffb7a55f3f8", @"/Areas/Admin/Views/Producto/Edit.cshtml")]
    public class Areas_Admin_Views_Producto_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 8 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
Write(ViewBag.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<br />
</div>
<!-- Start header -->
<div class=""all-page-title page-breadcrumb"">
    <div class=""container text-center"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1>
                    Editar Producto
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 26 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
 using (Html.BeginForm("Edit", "Producto", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group-row\">\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 30 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
       Write(Html.HiddenFor(d => d.cod_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div>\r\n                <label for=\"descripcion\">Descripcion</label>\r\n                ");
#nullable restore
#line 34 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
           Write(Html.TextBoxFor(d => d.descripcion, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
           Write(Html.ValidationMessageFor(d => d.descripcion, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n           \r\n\r\n            <br />\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        ");
#nullable restore
#line 44 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
   Write(Html.Partial("_EditAndBackToListButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROGESO.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591