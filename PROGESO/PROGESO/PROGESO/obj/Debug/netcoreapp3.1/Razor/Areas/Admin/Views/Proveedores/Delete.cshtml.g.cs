#pragma checksum "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dc117100bb51042912bc82ce38fc24039f5e77c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Proveedores_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Proveedores/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dc117100bb51042912bc82ce38fc24039f5e77c", @"/Areas/Admin/Views/Proveedores/Delete.cshtml")]
    public class Areas_Admin_Views_Proveedores_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Proveedores>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
Write(ViewBag.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<br />

<!-- Start header -->
<div class=""all-page-title page-breadcrumb"">
    <div class=""container text-center"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1>
                    Eliminar Proveedor
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 25 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
 using (Html.BeginForm("Delete", "Proveedores", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group-row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 29 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
   Write(Html.HiddenFor(d => d.ced_juridica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n\r\n            <label for=\"ced_juridica\">Ced_Juridica</label>\r\n            ");
#nullable restore
#line 33 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
       Write(Html.TextBoxFor(d => d.ced_juridica, "", new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 34 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
       Write(Html.ValidationMessageFor(d => d.ced_juridica, "", new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label for=\"nombre\">Nombre</label>\r\n            ");
#nullable restore
#line 38 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
       Write(Html.TextBoxFor(d => d.nombre, "", new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
       Write(Html.ValidationMessageFor(d => d.nombre, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <br />\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n    <div class=\"col-md-5\">\r\n        ");
#nullable restore
#line 49 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
   Write(Html.Partial("_DeleteAndBackToListButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Proveedores\Delete.cshtml"
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
