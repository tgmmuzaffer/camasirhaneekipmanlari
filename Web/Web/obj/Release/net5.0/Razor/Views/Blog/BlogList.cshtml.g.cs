#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c3e0bbc5cf42e9977fb334cd869e30921d31567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogList), @"mvc.1.0.view", @"/Views/Blog/BlogList.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3e0bbc5cf42e9977fb334cd869e30921d31567", @"/Views/Blog/BlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
  

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
            WriteLiteral("<div");
            BeginWriteAttribute("itemscope", " itemscope=\"", 410, "\"", 422, 0);
            EndWriteAttribute();
            WriteLiteral(" itemtype=\"https://schema.org/WebPage\">\r\n    <div itemscope itemtype=\"http://schema.org/Blog\">\r\n        ");
#nullable restore
#line 18 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
   Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <span itemprop=\"name\" style=\"display:none;\">");
#nullable restore
#line 19 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                                               Write(_page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <div class=\"container py-4\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <div class=\"blog-posts\">\r\n\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-4"" itemprop=""blogPosts"" itemscope itemtype=""http://schema.org/BlogPosting"">
                                    <article class=""post post-medium border-0 pb-0 mb-5"">
                                        <div class=""post-image"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 1265, "\"", 1286, 2);
            WriteAttributeValue("", 1272, "/Blog/", 1272, 6, true);
#nullable restore
#line 31 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1278, item.Id, 1278, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 1342, "\"", 1387, 1);
#nullable restore
#line 32 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1348, StaticDetails.GetImage(item.ImagePath), 1348, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid img-thumbnail img-thumbnail-no-borders rounded-0\"");
            BeginWriteAttribute("alt", " alt=\"", 1455, "\"", 1472, 1);
#nullable restore
#line 32 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1461, item.Title, 1461, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                        </div>

                                        <div class=""post-content"">

                                            <h2 class=""font-weight-semibold text-5 line-height-6 mt-3 mb-2""><a");
            BeginWriteAttribute("href", " href=\"", 1756, "\"", 1777, 2);
            WriteAttributeValue("", 1763, "/Blog/", 1763, 6, true);
#nullable restore
#line 38 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1769, item.Id, 1769, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                                                                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                            <p>");
#nullable restore
#line 39 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                                          Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                            <div class=\"post-meta\">\r\n                                                <span>\r\n                                                    <i class=\"far fa-folder\"></i>\r\n");
#nullable restore
#line 44 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                                                      
                                                        string tags = string.Join("/", item.TagNames);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a>");
#nullable restore
#line 46 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                                                      Write(tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("\r\n\r\n                                                </span>\r\n                                                <span class=\"d-block mt-2\"><a");
            BeginWriteAttribute("href", " href=\"", 2502, "\"", 2523, 2);
            WriteAttributeValue("", 2509, "/Blog/", 2509, 6, true);
#nullable restore
#line 51 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 2515, item.Id, 2515, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-light text-1 text-uppercase"">Oku</a></span>
                                            </div>

                                        </div>
                                    </article>
                                </div>
");
#nullable restore
#line 57 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
