#pragma checksum "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c50471a523dc0e7f86957526372e13ab49c5fd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Departament_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Departament/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c50471a523dc0e7f86957526372e13ab49c5fd9", @"/Areas/Admin/Views/Departament/Edit.cshtml")]
    public class Areas_Admin_Views_Departament_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Departament>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
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
                    Editar Departamento
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 26 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
 using (Html.BeginForm("Edit", "Departament", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group-row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 30 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
   Write(Html.HiddenFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            <label for=\"Name\">Nombre</label>\r\n            ");
#nullable restore
#line 33 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
       Write(Html.TextBoxFor(d => d.Name, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <!--<br />\r\n        <div class=\"col-6\">\r\n            <input value=\"Editar\" class=\"btn btn-primary\" type=\"submit\" />-->\r\n");
            WriteLiteral("        <!--<input type=\"button\" onClick=\"history.back()\" value=\"Volver Atrás\">\r\n        </div>-->\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("    <div class=\"col-md-5\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 47 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
   Write(Html.Partial("_EditAndBackToListButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 49 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROGESO.Models.Departament> Html { get; private set; }
    }
}
#pragma warning restore 1591
