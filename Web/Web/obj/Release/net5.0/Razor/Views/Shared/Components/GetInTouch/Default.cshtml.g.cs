#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a5a0476358184eb68dc3d37981d330190bdbe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetInTouch_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetInTouch/Default.cshtml")]
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
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a5a0476358184eb68dc3d37981d330190bdbe9", @"/Views/Shared/Components/GetInTouch/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GetInTouch_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-lg-6\">\r\n\r\n    <div class=\"appear-animation animated fadeIn appear-animation-visible\" data-appear-animation=\"fadeIn\" data-appear-animation-delay=\"800\" style=\"animation-delay: 800ms;\">\r\n        <h4 class=\"mt-2 mb-1\"><strong>");
#nullable restore
#line 7 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n        <ul class=\"list list-icons list-icons-style-2 mt-2\">\r\n            <li>\r\n                <i class=\"fas fa-map-marker-alt top-6\"></i>\r\n                <strong class=\"text-dark\">Address:</strong>\r\n                <span>");
#nullable restore
#line 12 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                 Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </li>\r\n            <li>\r\n                <i class=\"fas fa-phone top-6\"></i>\r\n                <strong class=\"text-dark\">Tel:</strong>\r\n                ");
#nullable restore
#line 18 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
           Write(Model.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                <i class=\"fas fa-envelope top-6\"></i>\r\n                <strong class=\"text-dark\">E-Posta:</strong>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 919, "\"", 938, 1);
#nullable restore
#line 23 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
WriteAttributeValue("", 926, Model.Email, 926, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            </li>
        </ul>
    </div>

    <div class=""appear-animation animated fadeIn appear-animation-visible"" data-appear-animation=""fadeIn"" data-appear-animation-delay=""950"" style=""animation-delay: 900ms;"" itemprop=""businessDays"" itemtype=""https://schema.org/OpeningHoursSpecification"" itemscope>
        <meta itemprop=""dayOfWeek"" content=""https://schema.org/Monday"" />
        <meta itemprop=""dayOfWeek"" content=""https://schema.org/Tuesday"" />
        <meta itemprop=""dayOfWeek"" content=""https://schema.org/Wednesday"" />
        <meta itemprop=""dayOfWeek"" content=""https://schema.org/Thursday"" />
        <meta itemprop=""dayOfWeek"" content=""https://schema.org/Friday"" />
        <meta itemprop=""dayOfWeek"" content=""https://schema.org/Saturday"" />
        <h4 class=""pt-5""><strong>Çalışma Saatleri</strong></h4>
        <ul class=""list list-icons list-dark mt-2"">
            <li><i class=""far fa-clock top-6""></i> ");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                              Write(Model.WorkDay1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                                                Write(Model.WorkHour1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><i class=\"far fa-clock top-6\"></i> ");
#nullable restore
#line 38 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                              Write(Model.WorkDay2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 38 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                                                Write(Model.WorkHour2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><i class=\"far fa-clock top-6\"></i> ");
#nullable restore
#line 39 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                              Write(Model.WorkDay3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 39 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                                                Write(Model.WorkHour3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"appear-animation animated fadeIn appear-animation-visible\" data-appear-animation=\"fadeIn\" data-appear-animation-delay=\"950\" style=\"animation-delay: 1000ms;\">\r\n        <h4 class=\"pt-5\"> <strong>");
#nullable restore
#line 43 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                             Write(Model.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n        <p class=\"lead mb-0 text-4\"> ");
#nullable restore
#line 44 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\GetInTouch\Default.cshtml"
                                Write(Html.Raw(Model.ContactContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
