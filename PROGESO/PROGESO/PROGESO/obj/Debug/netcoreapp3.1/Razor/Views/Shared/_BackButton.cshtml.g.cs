#pragma checksum "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Views\Shared\_BackButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d10a23662617dfd09c728cd818e6c5103e3a29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BackButton), @"mvc.1.0.view", @"/Views/Shared/_BackButton.cshtml")]
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
#nullable restore
#line 1 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Views\_ViewImports.cshtml"
using PROGESO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jspab\Desktop\PROGESO MUNI\PROGESO\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Views\_ViewImports.cshtml"
using PROGESO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d10a23662617dfd09c728cd818e6c5103e3a29", @"/Views/Shared/_BackButton.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5396d4dfdc1e2223a2edb98afed0568bc9508115", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BackButton : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row \">\r\n    <div class=\"col-md-4\">\r\n        <a onClick=\"history.back()\" class=\"btn btn-info form-control\">\r\n            &nbsp;Atrás\r\n        </a>\r\n    </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
