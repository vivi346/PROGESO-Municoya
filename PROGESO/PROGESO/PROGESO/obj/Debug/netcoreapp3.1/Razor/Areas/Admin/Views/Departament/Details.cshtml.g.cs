#pragma checksum "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d98b90eed0cce98048496c5deff2cdf5768a067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Departament_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Departament/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d98b90eed0cce98048496c5deff2cdf5768a067", @"/Areas/Admin/Views/Departament/Details.cshtml")]
    public class Areas_Admin_Views_Departament_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROGESO.Models.Departament>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
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
                    Detalles de departamentos
                </h1>
            </div>
        </div>
    </div>
</div>
<h2 class=""text-info""></h2>
<br />

");
#nullable restore
#line 25 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
 using (Html.BeginForm("Details", "Departament", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group-row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 29 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
   Write(Html.HiddenFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            <label for=\"Id\">Id</label>\r\n            ");
#nullable restore
#line 32 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
       Write(Html.TextBoxFor(d => d.Id, "", new { @class = "form-control" , @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label for=\"Name\">Nombre</label>\r\n            ");
#nullable restore
#line 36 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
       Write(Html.TextBoxFor(d => d.Name, "", new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <br />\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n    <div class=\"col-6\">\r\n        ");
#nullable restore
#line 46 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
   Write(Html.Partial("_BackButton"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\Departament\Details.cshtml"
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
