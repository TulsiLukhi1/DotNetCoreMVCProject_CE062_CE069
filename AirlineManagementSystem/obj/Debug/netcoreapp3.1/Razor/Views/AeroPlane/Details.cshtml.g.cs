#pragma checksum "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c0e13b6ba67dde15013bbca4e02a3a65718a29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AeroPlane_Details), @"mvc.1.0.view", @"/Views/AeroPlane/Details.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\_ViewImports.cshtml"
using AirlineManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\_ViewImports.cshtml"
using AirlineManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c0e13b6ba67dde15013bbca4e02a3a65718a29", @"/Views/AeroPlane/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b1701f6e22b9c020ca82a2b043cb90fa5a8809", @"/Views/_ViewImports.cshtml")]
    public class Views_AeroPlane_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AirlineManagementSystem.Models.AeroPlaneModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-lg-10 grid-margin stretch-card"" style=""margin:37px"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Aeroplane Information</h4>
                        <p class=""card-description"">

                        </p>
                        <div class=""table-responsive"">
                            <table class=""table table-hover"">
                                <thead>
                                    <tr>

                                        <th>");
#nullable restore
#line 26 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.APlaneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 27 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.SeatingCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 28 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>

                                            ");
#nullable restore
#line 36 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.APlaneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 39 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.SeatingCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 42 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\AeroPlane\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                    </tr>
                                    <tr>
                                    </tr>

                                </tbody>


                            </table>
                            <div style=""margin:20px"">

                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AirlineManagementSystem.Models.AeroPlaneModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
