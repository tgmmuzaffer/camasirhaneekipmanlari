#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13e12104afc36e3c3b473317ac7065d12677863b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e12104afc36e3c3b473317ac7065d12677863b", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/N_2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("64"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
  
    string url = ViewBag.Url;
    var f = Model.Adress;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
 if (!string.IsNullOrEmpty(url) && url != "/BizeUlasin")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row justify-content-center py-4 text-center"">
            <div class=""col"">
                <a class=""text-uppercase font-weight-bold text-3 text-color-light icon-aria-expanded-change"" data-bs-toggle=""collapse"" href=""#hiddenMap"" role=""button"" aria-expanded=""false"" aria-controls=""hiddenMap"">
                    Konum Bilgisi Al <i class=""ms-1 fas fa-chevron-down""></i><i class=""ms-1 fas fa-chevron-up""></i>
                </a>
            </div>
        </div>
    </div>
    <div class=""collapse"" id=""hiddenMap"">
        <div id=""googlemaps"" class=""google-map map-style-1 m-0"" style=""height: 475px;"">           
");
            WriteLiteral(@"        </div>
    </div>
    <div class=""footer-bg-color-2 footer-bottom-light-border"">
        <div class=""container"">
            <div class=""row justify-content-center text-center"">
                <div class=""col py-5"">
                    <a href=""/"" class=""logo"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "13e12104afc36e3c3b473317ac7065d12677863b6469", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""footer-bg-color-2 footer-bottom-light-border"">
        <div class=""container"">
            <div class=""row justify-content-center text-center py-5"">
                <div class=""col-md-4 text-center mb-4 mb-md-0"">
                    <i class=""fas fa-map-marker-alt text-9 text-color-light mb-3 mt-2""></i>
                    <p class=""mb-0"">
                        <strong class=""text-color-light text-uppercase"">");
#nullable restore
#line 43 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        <span class=\"d-block text-2 p-relative bottom-3\">");
#nullable restore
#line 44 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                    Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </p>
                </div>
                <div class=""col-md-4 text-center mb-4 mb-md-0"">
                    <i class=""far fa-clock text-9 text-color-light mb-3 mt-2""></i>
                    <p class=""mb-0"">
                        <strong class=""text-color-light text-uppercase"">Çalışma Gün ve Saatleri</strong>                   
                        <span class=""d-block text-2 p-relative bottom-3"">");
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                    Write(Model.WorkDay1);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;/&nbsp;");
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                Write(Model.WorkHour1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"d-block text-2 p-relative bottom-3\">");
#nullable restore
#line 52 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                    Write(Model.WorkDay2);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;/&nbsp;");
#nullable restore
#line 52 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                Write(Model.WorkHour2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"d-block text-2 p-relative bottom-3\">");
#nullable restore
#line 53 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                    Write(Model.WorkDay3);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;/&nbsp;");
#nullable restore
#line 53 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                Write(Model.WorkHour3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </p>
                </div>
                <div class=""col-md-4 text-center"">
                    <i class=""fas fa-phone-volume text-9 text-color-light mb-3 mt-2""></i>
                    <p class=""mb-0"">
                        <strong class=""text-color-light text-uppercase"">Bize Ulaşın</strong>
                        <span class=""d-block text-2 p-relative bottom-3""><a");
            BeginWriteAttribute("href", " href=\"", 3066, "\"", 3090, 2);
            WriteAttributeValue("", 3073, "tel:", 3073, 4, true);
#nullable restore
#line 60 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3077, Model.Phone1, 3077, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">");
#nullable restore
#line 60 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                                             Write(Model.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                        <span class=\"d-block text-2 p-relative bottom-3\"><a");
            BeginWriteAttribute("href", " href=\"", 3222, "\"", 3248, 2);
            WriteAttributeValue("", 3229, "mailto:", 3229, 7, true);
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3236, Model.Email, 3236, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">");
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""footer-copyright"">
    <div class=""container py-2"">
        <div class=""row py-4"">
            <div class=""col text-center"">
                <ul class=""footer-social-icons social-icons social-icons-clean social-icons-icon-light mb-3"">
                    <li class=""social-icons-facebook""><a");
            BeginWriteAttribute("href", " href=\"", 3715, "\"", 3745, 1);
#nullable restore
#line 74 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3722, Model.InstagramAccount, 3722, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" title=\"Facebook\"><i class=\"fab fa-instagram text-2\"></i></a></li>\r\n                    <li class=\"social-icons-twitter\"><a");
            BeginWriteAttribute("href", " href=\"", 3885, "\"", 3913, 1);
#nullable restore
#line 75 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3892, Model.TwitterAccount, 3892, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" title=\"Twitter\"><i class=\"fab fa-twitter text-2\"></i></a></li>\r\n                    <li class=\"social-icons-linkedin\"><a");
            BeginWriteAttribute("href", " href=\"", 4051, "\"", 4080, 1);
#nullable restore
#line 76 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 4058, Model.LinkedInAccount, 4058, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" title=\"Linkedin\"><i class=\"fab fa-linkedin-in text-2\"></i></a></li>\r\n                </ul>\r\n                <p>Çamaşırhane Ekipmanları © Copyright 2022. Tüm Hakları Saklıdır.</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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