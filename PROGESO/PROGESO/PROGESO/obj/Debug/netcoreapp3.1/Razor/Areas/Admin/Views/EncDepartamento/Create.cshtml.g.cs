#pragma checksum "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50747593ddff5ee8b0af09baecd80ab8b15057db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EncDepartamento_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/EncDepartamento/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50747593ddff5ee8b0af09baecd80ab8b15057db", @"/Areas/Admin/Views/EncDepartamento/Create.cshtml")]
    public class Areas_Admin_Views_EncDepartamento_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.EncDepartamento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 9 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
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
                    Ingresar Encargado
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />


");
#nullable restore
#line 28 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
 using (Html.BeginForm("Create", "EncDepartamento", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group-row\">\r\n\r\n        <div class=\"col-md-6\">\r\n            <div>\r\n                <label for=\"Id\">Id</label>\r\n                ");
#nullable restore
#line 35 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.TextBoxFor(d => d.Id, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.Id, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n");
            WriteLiteral("            <div>\r\n                <label for=\"Correo\">Correo</label>\r\n                ");
#nullable restore
#line 43 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.TextBoxFor(d => d.Correo, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 44 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.Correo, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"Nombre\">Nombre</label>\r\n                ");
#nullable restore
#line 49 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.TextBoxFor(d => d.Nombre, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 50 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.Nombre, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"Apellido1\">Apellido1</label>\r\n                ");
#nullable restore
#line 55 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.TextBoxFor(d => d.Apellido1, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 56 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.Apellido1, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"Apellido2\">Apellido2</label>\r\n                ");
#nullable restore
#line 61 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.TextBoxFor(d => d.Apellido2, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 62 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
           Write(Html.ValidationMessageFor(d => d.Apellido2, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"Id\">Departamento</label>\r\n                <div class=\"col-md-12 col-sm-12\">\r\n                    ");
#nullable restore
#line 68 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
               Write(Html.DropDownList("DepartamentID", null, htmlAttributes: new { @class = "select2_single form-control col-md-7 col-xs-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 69 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.DepartamentID, "", new { @class = "Text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br />\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"col-6\">\r\n\r\n        ");
#nullable restore
#line 81 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
   Write(Html.Partial("_CreateAndBackToListButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 83 "D:\1Datos Windows\Desktop\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\EncDepartamento\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROGESO.Models.EncDepartamento> Html { get; private set; }
    }
}
#pragma warning restore 1591
