#pragma checksum "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf0ba0e017fe2d5d40e06cba52017213983ba34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\_ViewImports.cshtml"
using PROGESO.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\_ViewImports.cshtml"
using PROGESO.Areas.Identity.Pages;

#line default
#line hidden
#line 1 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PROGESO.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using PROGESO.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf0ba0e017fe2d5d40e06cba52017213983ba34", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c52c463cff8405b555b0a3d1774cf42cc5884b6d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ad5825a85d44e0c1cd4144f800d414dca62861", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da07a921bee09c9da80d01d4f1c0d2a9a0fdf396", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#line 6 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#line 8 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            WriteLiteral("\r\n    </div>\r\n");
#line 10 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
