#pragma checksum "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c29653f8da22e784a9b5af9e538ccc85ae858e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductoProveedor_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductoProveedor/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c29653f8da22e784a9b5af9e538ccc85ae858e1", @"/Areas/Admin/Views/ProductoProveedor/Details.cshtml")]
    public class Areas_Admin_Views_ProductoProveedor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.ProductoProveedor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
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
                    Detalles de Compra
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 26 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
 using (Html.BeginForm("Details", "ProductoProveedor", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group-row\">\r\n        <div class=\"col-md-4\">\r\n\r\n            ");
#nullable restore
#line 31 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
       Write(Html.HiddenFor(d => d.cod_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div>\r\n                <label for=\"cod_prod\">Producto</label>\r\n                ");
#nullable restore
#line 35 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.TextBoxFor(d => d.Producto.descripcion, "", new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.Producto.descripcion, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"ced_juridica\">Proveedor</label>\r\n                ");
#nullable restore
#line 41 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.TextBoxFor(d => d.Proveedores.nombre, "", new { @class = "form-control" , @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.Proveedores.nombre, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"precio\">Precio</label>\r\n                ");
#nullable restore
#line 47 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.TextBoxFor(d => d.precio, "", new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 48 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.precio, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"cantidad\">Cantidad</label>\r\n                ");
#nullable restore
#line 53 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.TextBoxFor(d => d.cantidad, "", new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 54 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.cantidad, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            \r\n            <div>\r\n                <label for=\"FechaCompra\">Fecha Compra</label>\r\n                ");
#nullable restore
#line 59 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.TextBoxFor(d => d.FechaCompra, "{0:dd-MM-yyyy}", new { @class = "form-control datepicker", placeholder = "Fecha de Compra", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 60 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.FechaCompra, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <div class=\"col-6\">\r\n\r\n        ");
#nullable restore
#line 71 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
   Write(Html.Partial("_BackButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 73 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\ProductoProveedor\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROGESO.Models.ProductoProveedor> Html { get; private set; }
    }
}
#pragma warning restore 1591
