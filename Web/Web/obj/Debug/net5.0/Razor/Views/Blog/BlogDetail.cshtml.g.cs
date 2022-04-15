#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deff4088aae688a7988efb71529191cafa50ce2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetail), @"mvc.1.0.view", @"/Views/Blog/BlogDetail.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deff4088aae688a7988efb71529191cafa50ce2d", @"/Views/Blog/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
  
    var day = Model.CreateDate.Day;
    var dayofweek = Model.CreateDate.DayOfWeek;
    string tgs = string.Empty;
    if (Model.TagNames != null && Model.TagNames.Count > 0)
    {
        tgs = string.Join(" / ", Model.TagNames);

    }
    var threeBlogs = ViewBag.ThreeBlog as List<Blog>;
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
#nullable restore
#line 25 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container py-4\"");
            BeginWriteAttribute("itemscope", " itemscope=\"", 803, "\"", 815, 0);
            EndWriteAttribute();
            WriteLiteral(" itemtype=\"https://schema.org/WebPage\">\r\n    <span itemprop=\"name\" style=\"display:none;\">");
#nullable restore
#line 28 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                           Write(_page);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

    <div class=""row"" itemprop=""blogPosts"" itemscope itemtype=""http://schema.org/BlogPosting"">
        <div class=""col"">
            <div class=""blog-posts single-post"">

                <article class=""post post-large blog-single-post border-0 m-0 p-0"">
");
            WriteLiteral("                    <div class=\"post-date ms-0\">\r\n                        <span class=\"day\">");
#nullable restore
#line 41 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                     Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"month\">");
#nullable restore
#line 42 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                       Write(dayofweek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"post-content ms-0\">\r\n                        <h1 class=\"font-weight-semi-bold\"><a>");
#nullable restore
#line 45 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n                        <h2 style=\"display:none;\" itemprop=\"headline\">");
#nullable restore
#line 46 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                                 Write(StringProcess.TruncateLongString(Model.Title, 110));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div tyle=\"display:none;\" itemprop=\"image\" itemscope itemtype=\"https://schema.org/ImageObject\">\r\n                            <img itemprop=\"url\"");
            BeginWriteAttribute("src", " src=\"", 2120, "\"", 2166, 1);
#nullable restore
#line 48 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 2126, StaticDetails.GetImage(Model.ImagePath), 2126, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                            <meta itemprop=""width"" content=""1920"" />
                            <meta itemprop=""height"" content=""670"" />
                        </div>
                    </div>
                    <div class=""post-content ms-0"" style=""display:inline-block; margin-top:3px;"">
                        <blockquote class=""blockquote-primary"">
                            <h2 class=""font-weight-semi-bold"">");
#nullable restore
#line 55 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                         Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </blockquote>\r\n                        <div class=\"post-meta\">\r\n                            <span><i class=\"far fa-user\"></i> Yazar: <a>Çamaşırhane Ekipmanları</a> </span>\r\n");
#nullable restore
#line 59 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                             if (!string.IsNullOrEmpty(tgs))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span><i class=\"far fa-folder\"></i> <a>");
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                                  Write(tgs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 62 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        ");
#nullable restore
#line 64 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                   Write(Html.Raw(HttpUtility.HtmlDecode(Model.Content)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </article>\r\n            </div>\r\n            <hr />\r\n");
#nullable restore
#line 69 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
             if (threeBlogs != null && threeBlogs.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"blog-posts\">\r\n                    <div class=\"row\">\r\n                        <h4 class=\"font-weight-semi-bold align-self-center text-center mb-5-5\">Okumak İsteyeceğibniz Diğer Bloglar</h4>\r\n");
#nullable restore
#line 74 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                         foreach (var item in threeBlogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4\">\r\n                                <article class=\"post post-medium border-0 pb-0 mb-5\">\r\n                                    <div class=\"post-image\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3856, "\"", 3877, 2);
            WriteAttributeValue("", 3863, "/Blog/", 3863, 6, true);
#nullable restore
#line 79 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 3869, item.Id, 3869, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3929, "\"", 3974, 1);
#nullable restore
#line 80 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 3935, StaticDetails.GetImage(item.ImagePath), 3935, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid img-thumbnail img-thumbnail-no-borders rounded-0\"");
            BeginWriteAttribute("alt", " alt=\"", 4042, "\"", 4059, 1);
#nullable restore
#line 80 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4048, item.Title, 4048, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </a>
                                    </div>
                                    <div class=""post-content"">
                                        <h2 class=""font-weight-semibold text-5 line-height-6 mt-3 mb-2""><a");
            BeginWriteAttribute("href", " href=\"", 4323, "\"", 4344, 2);
            WriteAttributeValue("", 4330, "/Blog/", 4330, 6, true);
#nullable restore
#line 84 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 4336, item.Id, 4336, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                                                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                        <p>");
#nullable restore
#line 85 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                      Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"post-meta\">\r\n                                            <span>\r\n                                                <i class=\"far fa-folder\"></i>\r\n");
#nullable restore
#line 89 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                  
                                                    string tags = string.Join("/", item.TagNames);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a>");
#nullable restore
#line 91 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                                                  Write(tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                                            </span>\r\n                                            <span class=\"d-block mt-2\"><a");
            BeginWriteAttribute("href", " href=\"", 5023, "\"", 5044, 2);
            WriteAttributeValue("", 5030, "/Blog/", 5030, 6, true);
#nullable restore
#line 94 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 5036, item.Id, 5036, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-light text-1 text-uppercase\">Oku</a></span>\r\n                                        </div>\r\n                                    </div>\r\n                                </article>\r\n                            </div>\r\n");
#nullable restore
#line 99 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 102 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Blog\BlogDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
