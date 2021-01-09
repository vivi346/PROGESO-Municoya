#pragma checksum "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "959eef51645d5668bf7d207ca07c23195e183e2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959eef51645d5668bf7d207ca07c23195e183e2a", @"/Areas/Admin/Views/User/Index.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROGESO.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral(@"    <!-- Start header -->
    <div class=""all-page-title page-breadcrumb"">
        <div class=""container text-center"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h1>
                        Insertar Usuario
                    </h1>
                </div>
            </div>
        </div>
    </div>
    <!-- End header -->
    <div class=""border backgroundWhite"">
        <div class=""row"">
            <div class=""col-6"">
                <h2 class=""text-info"">Lista de Usuario</h2>
            </div>
            <div class=""col-6 text-right"">
                <a asp-area=""Identity"" asp-page=""/Account/Register"" class=""btn btn-info"">
                    <i class=""fas fa-plus""></i>&nbsp;Nuevo Registro
                </a>
            </div>
        </div>
        <br />
        <div>
");
#line 35 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
            WriteLiteral("                <table class=\"table table-striped border\">\r\n                    <tr class=\"table-secondary\">\r\n                        <th>\r\n                            ");
#line 40 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#line 43 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Telefono));

#line default
#line hidden
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#line 46 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Distrito));

#line default
#line hidden
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n");
#line 53 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#line 57 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#line 60 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Telefono));

#line default
#line hidden
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#line 63 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(m => item.Distrito));

#line default
#line hidden
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#line 66 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                                 if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                                {

#line default
#line hidden
            WriteLiteral("                                    <a class=\"btn btn-success text-white\" asp-action=\"Lock\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2510, "\"", 2533, 1);
#line 68 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2525, item.Id, 2525, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fas fa-lock-open\"></i>\r\n                                    </a>\r\n");
#line 71 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            WriteLiteral("                                    <a class=\"btn btn-danger text-white\" asp-action=\"UnLock\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2853, "\"", 2876, 1);
#line 74 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2868, item.Id, 2868, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fas fa-lock\"></i>\r\n                                    </a>\r\n");
#line 77 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                                }

#line default
#line hidden
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <a class=\"btn btn-danger text-white\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3183, "\"", 3206, 1);
#line 80 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 3198, item.Id, 3198, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fas fa-trash-alt\"></i>\r\n                                </a>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#line 86 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("                </table>\r\n");
#line 88 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            WriteLiteral("                <h3 style=\"color:red;\">No hay usuarios registrados...</h3>\r\n");
#line 92 "C:\Users\Usuario\Desktop\PROGESO MUNI\vivi346\PROGESO-Municoya\PROGESO\PROGESO\PROGESO\Areas\Admin\Views\User\Index.cshtml"
            }

#line default
#line hidden
            WriteLiteral("        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROGESO.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
