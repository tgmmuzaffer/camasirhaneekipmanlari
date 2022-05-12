#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08b57b58bc0d25d7f9965c0a178c5963fdd4690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Industry_Industries), @"mvc.1.0.view", @"/Views/Industry/Industries.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\_ViewImports.cshtml"
using Recaptcha.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08b57b58bc0d25d7f9965c0a178c5963fdd4690", @"/Views/Industry/Industries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Industry_Industries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IndustryDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
  
    var breadcrumbdata = TempData["BreadCrumb"];
    var page = TempData["Page"];
    string _page = page.ToString();

    TempData["Title"] = page;
    Breadcrumb breadcrumb = new();
    if (breadcrumbdata != null && page != null)
    {
        breadcrumb.Page = page.ToString();
        breadcrumb.Data = breadcrumbdata as List<string>;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("itemscope", " itemscope=\"", 445, "\"", 457, 0);
            EndWriteAttribute();
            WriteLiteral(" itemtype=\"https://schema.org/WebPage\">\r\n    <span style=\"display:none;\">");
#nullable restore
#line 20 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
                           Write(_page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <span style=\"display:none;\">Tüm Ürünler</span>\r\n    ");
#nullable restore
#line 22 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div id=\"examples\" class=\"container py-2\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <div class=\"row mt-lg-5\">\r\n");
#nullable restore
#line 29 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 mb-3-5"">
                                   <span class=""thumb-info thumb-info-no-borders thumb-info-no-borders-rounded thumb-info-lighten thumb-info-bottom-info thumb-info-bottom-info-dark thumb-info-bottom-info-show-more thumb-info-no-zoom"">
                                    <span class=""thumb-info-wrapper"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1392, "\"", 1437, 1);
#nullable restore
#line 34 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
WriteAttributeValue("", 1398, StaticDetails.GetImage(item.ImagePath), 1398, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1456, "\"", 1462, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span class=\"thumb-info-title\">\r\n                                            <span class=\"thumb-info-inner line-height-1\">");
#nullable restore
#line 36 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
                                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </span>\r\n                                    </span>\r\n                                    </span>\r\n                                </div>\r\n");
#nullable restore
#line 41 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Industry\Industries.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IndustryDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
