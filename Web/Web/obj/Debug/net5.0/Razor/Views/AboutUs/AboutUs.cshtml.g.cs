#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa7cbeb17b966f3b9bfa10939d6251468cb6506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutUs_AboutUs), @"mvc.1.0.view", @"/Views/AboutUs/AboutUs.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa7cbeb17b966f3b9bfa10939d6251468cb6506", @"/Views/AboutUs/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AboutUs_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutUs>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
   
    var titleArray = Model.Title.Split(",");
    var animateds = titleArray.Skip(1).ToList();
    var statics = titleArray.Take(1).FirstOrDefault();
    var breadcrumbdata = TempData["BreadCrumb"];
    var page = TempData["Page"];
    Breadcrumb breadcrumb = new();
    if (breadcrumbdata != null && page != null)
    {
        breadcrumb.Page = page.ToString();
        breadcrumb.Data = breadcrumbdata as List<string>;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div role=\"main\" class=\"main\">\r\n    ");
#nullable restore
#line 18 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    <div class=""container pt-5"">
        <div class=""col"">
            <div class=""row text-center pb-5"">
                <div class=""col-md-9 mx-md-auto"">
                    <div class=""overflow-hidden mb-3"">
                        <h1 class=""word-rotator slide font-weight-bold text-8 mb-0 appear-animation animated maskUp appear-animation-visible"" data-appear-animation=""maskUp"" style=""animation-delay: 100ms;"">
                            <span>");
#nullable restore
#line 25 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                             Write(statics);

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n                            <span class=\"word-rotator-words bg-primary\" style=\"width: 142.844px;\">\r\n");
#nullable restore
#line 27 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                                 foreach (var item in animateds)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <b class=\"is-visible\">");
#nullable restore
#line 29 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                                                     Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 30 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                             
                            </span>
                        </h1>
                    </div>
                    <div class=""overflow-hidden mb-3"">
                        <p class=""lead mb-0 appear-animation animated maskUp appear-animation-visible"" data-appear-animation=""maskUp"" data-appear-animation-delay=""200"" style=""animation-delay: 200ms;"">");
#nullable restore
#line 36 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                                                                                                                                                                                                   Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
         if (!string.IsNullOrEmpty(Model.Content1))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row py-4 mb-2"">
                <div class=""col-md-7 order-2"">


                    <p class=""lead appear-animation animated fadeInUpShorter appear-animation-visible"" data-appear-animation=""fadeInUpShorter"" data-appear-animation-delay=""700"" style=""animation-delay: 700ms;"">");
#nullable restore
#line 50 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                                                                                                                                                                                                            Write(Model.Content1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <hr class=\"solid my-4 appear-animation animated fadeInUpShorter appear-animation-visible\" data-appear-animation=\"fadeInUpShorter\" data-appear-animation-delay=\"900\" style=\"animation-delay: 900ms;\">\r\n\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                 if (!string.IsNullOrEmpty(Model.ImagePath1))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-5 order-md-2 mb-4 mb-lg-0 appear-animation animated fadeInRightShorter appear-animation-visible\" data-appear-animation=\"fadeInRightShorter\" style=\"animation-delay: 100ms;\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2840, "\"", 2887, 1);
#nullable restore
#line 58 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
WriteAttributeValue("", 2846, StaticDetails.GetImage(Model.ImagePath1), 2846, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid mb-2\"");
            BeginWriteAttribute("alt", " alt=\"", 2911, "\"", 2917, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
         if (!string.IsNullOrEmpty(Model.Content2))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row py-4 mb-2\">\r\n");
#nullable restore
#line 67 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                 if (!string.IsNullOrEmpty(Model.ImagePath2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-5 order-2\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3268, "\"", 3315, 1);
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
WriteAttributeValue("", 3274, StaticDetails.GetImage(Model.ImagePath2), 3274, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid mb-2\"");
            BeginWriteAttribute("alt", " alt=\"", 3339, "\"", 3345, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 72 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-7 order-md-2 mb-4 mb-lg-0 appear-animation animated fadeInLeftShorter appear-animation-visible"" data-appear-animation=""fadeInLeftShorter"" style=""animation-delay: 100ms;"">

                    <p class=""lead appear-animation animated fadeInUpShorter appear-animation-visible"" data-appear-animation=""fadeInUpShorter"" data-appear-animation-delay=""700"" style=""animation-delay: 700ms;"">");
#nullable restore
#line 76 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                                                                                                                                                                                                            Write(Model.Content2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                    <hr class=""solid my-4 appear-animation animated fadeInUpShorter appear-animation-visible"" data-appear-animation=""fadeInUpShorter"" data-appear-animation-delay=""900"" style=""animation-delay: 900ms;"">

                </div>
            </div>
");
#nullable restore
#line 82 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
         if (!string.IsNullOrEmpty(Model.Content3))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row py-4 mb-2"">
                <div class=""col-md-7 order-2"">


                    <p class=""lead appear-animation animated fadeInUpShorter appear-animation-visible"" data-appear-animation=""fadeInUpShorter"" data-appear-animation-delay=""700"" style=""animation-delay: 700ms;"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam <a href=""#"">vehicula</a> sit amet enim ac sagittis. Curabitur eget leo varius, elementum mauris eget, egestas quam. Donec ante risus, dapibus sed lectus non, lacinia vestibulum nisi. Morbi vitae augue quam. Nullam ac laoreet libero.</p>

                    <hr class=""solid my-4 appear-animation animated fadeInUpShorter appear-animation-visible"" data-appear-animation=""fadeInUpShorter"" data-appear-animation-delay=""900"" style=""animation-delay: 900ms;"">

                </div>
");
#nullable restore
#line 94 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                 if (!string.IsNullOrEmpty(Model.ImagePath2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-5 order-md-2 mb-4 mb-lg-0 appear-animation animated fadeInRightShorter appear-animation-visible\" data-appear-animation=\"fadeInRightShorter\" style=\"animation-delay: 100ms;\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 5352, "\"", 5399, 1);
#nullable restore
#line 97 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
WriteAttributeValue("", 5358, StaticDetails.GetImage(Model.ImagePath3), 5358, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid mb-2\"");
            BeginWriteAttribute("alt", " alt=\"", 5423, "\"", 5429, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 99 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 102 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\AboutUs\AboutUs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutUs> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591