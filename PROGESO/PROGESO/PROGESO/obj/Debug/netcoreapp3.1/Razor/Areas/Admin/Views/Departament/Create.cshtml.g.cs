#pragma checksum "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1586d517f23f0c911814e4d8cc48fb0dd8acbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Departament_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Departament/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1586d517f23f0c911814e4d8cc48fb0dd8acbd", @"/Areas/Admin/Views/Departament/Create.cshtml")]
    public class Areas_Admin_Views_Departament_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Departament>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
  
    ViewData["Tittle"] = "Departament";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
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
                    Ingresar Departamento
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 25 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
 using (Html.BeginForm("Create", "Departament", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div>\r\n                ");
#nullable restore
#line 30 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
           Write(Html.LabelFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
           Write(Html.TextBoxFor(d => d.Name, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n         \r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"col-6\">\r\n\r\n        ");
#nullable restore
#line 41 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
   Write(Html.Partial("_CreateAndBackToListButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\vivi3\OneDrive\Escritorio\PROY-PROGESO\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROGESO.Models.Departament> Html { get; private set; }
    }
}
#pragma warning restore 1591