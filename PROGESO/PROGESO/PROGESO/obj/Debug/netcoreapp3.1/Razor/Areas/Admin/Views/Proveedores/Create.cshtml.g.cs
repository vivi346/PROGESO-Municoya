#pragma checksum "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b098dcaa900b6d7b99b956bac58706eba61a7fc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Proveedores_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Proveedores/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b098dcaa900b6d7b99b956bac58706eba61a7fc1", @"/Areas/Admin/Views/Proveedores/Create.cshtml")]
    public class Areas_Admin_Views_Proveedores_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Proveedores>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
  
    //ViewBag.Title = "Crear Nuevo";
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
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
                    Ingresar Proveedores
                </h1>
            </div>
        </div>
    </div>
</div>
<!-- end header -->
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 27 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
 using (Html.BeginForm("Create", "Proveedores", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group-row\">\r\n        <div class=\"col-md-6\">\r\n            <div>\r\n\r\n                <label for=\"ced_juridica\">Ced_Juridica</label>\r\n                ");
#nullable restore
#line 35 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
           Write(Html.TextBoxFor(d => d.ced_juridica, "", new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.ced_juridica, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div>\r\n\r\n                <label for=\"nombre\">Nombre</label>\r\n                ");
#nullable restore
#line 42 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
           Write(Html.TextBoxFor(d => d.nombre, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 43 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.nombre, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <br />\r\n            <!--<div class=\"col-6\">\r\n                <input value=\"Guardar\" class=\"btn btn-primary\" type=\"submit\" />-->\r\n");
            WriteLiteral("            <!--<input type=\"button\" onClick=\"history.back()\" value=\"Volver Atrás\">\r\n            </div>-->\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-6\">\r\n\r\n        ");
#nullable restore
#line 59 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
   Write(Html.Partial("_CreateAndBackToListButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\Dell\source\repos\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROGESO.Models.Proveedores> Html { get; private set; }
    }
}
#pragma warning restore 1591
