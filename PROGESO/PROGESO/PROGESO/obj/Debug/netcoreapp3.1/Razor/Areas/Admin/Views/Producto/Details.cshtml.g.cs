#pragma checksum "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef709dff93563ecec17118b0b91a5f369caf44a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Producto_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Producto/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef709dff93563ecec17118b0b91a5f369caf44a", @"/Areas/Admin/Views/Producto/Details.cshtml")]
    public class Areas_Admin_Views_Producto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\r\n<h2>");
#line 7 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
Write(ViewBag.Tittle);

#line default
#line hidden
            WriteLiteral(@"</h2>
<br />
</div>
<!-- Start header -->
<div class=""all-page-title page-breadcrumb"">
    <div class=""container text-center"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1>
                    Detalles de Producto
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#line 25 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
 using (Html.BeginForm("Details", "Producto", FormMethod.Post))
{

#line default
#line hidden
            WriteLiteral("    <div class=\"form-group-row\">\r\n        <div class=\"col-md-6\">\r\n            ");
#line 29 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
       Write(Html.HiddenFor(d => d.cod_prod));

#line default
#line hidden
            WriteLiteral("\r\n\r\n            <div>\r\n                <label for=\"cod_prod\">Codigo</label>\r\n                ");
#line 33 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
           Write(Html.TextBoxFor(d => d.cod_prod, "", new { @class = "form-control" }));

#line default
#line hidden
            WriteLiteral("\r\n                ");
#line 34 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.cod_prod, null, new { @class = "red" }));

#line default
#line hidden
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <label for=\"descripcion\">Descripcion</label>\r\n                ");
#line 38 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
           Write(Html.TextBoxFor(d => d.descripcion, "", new { @class = "form-control" }));

#line default
#line hidden
            WriteLiteral("\r\n                ");
#line 39 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
           Write(Html.ValidationMessageFor(d => d.descripcion, null, new { @class = "red" }));

#line default
#line hidden
            WriteLiteral("\r\n            </div>\r\n\r\n");
            WriteLiteral("\r\n            <br />\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <div class=\"col-6\">\r\n\r\n        ");
#line 67 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
   Write(Html.Partial("_BackButton"));

#line default
#line hidden
            WriteLiteral("\r\n    </div>\r\n");
#line 69 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Producto\Details.cshtml"
}

#line default
#line hidden
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
