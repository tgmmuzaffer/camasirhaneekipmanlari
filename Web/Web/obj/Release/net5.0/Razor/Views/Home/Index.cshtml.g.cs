#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299ad517f05e14d150a74b47dd8441abc0501959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299ad517f05e14d150a74b47dd8441abc0501959", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
  
    var categories = ViewBag.Categories as List<Category>;
    var slider = ViewBag.Slider as List<Slider>;
    var blogs = ViewBag.ThreeBlog as List<Blog>;
    var refrences = ViewBag.Refrences as List<Referance>;
    TempData["Title"] = "Anasayfa";
    string url = string.Empty;
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div role=""main"" class=""main"">
    <div class=""owl-carousel-wrapper position-relative"" style=""height: 670px"">
        <div class=""owl-carousel-loader"">
            <div class=""bounce-loader"">
                <div class=""bounce1""></div>
                <div class=""bounce2""></div>
                <div class=""bounce3""></div>
            </div>
        </div>
        <div class=""owl-carousel dots-inside dots-horizontal-center show-dots-hover nav-inside nav-inside-plus nav-dark nav-md nav-font-size-md show-nav-hover mb-0"" data-plugin-options=""{'responsive': {'0': {'items': 1}, '479': {'items': 1}, '768': {'items': 1}, '979': {'items': 1}, '1199': {'items': 1}}, 'loop': false, 'autoHeight': false, 'margin': 0, 'dots': true, 'dotsVerticalOffset': '-75px', 'nav': true, 'animateIn': 'fadeIn', 'animateOut': 'fadeOut', 'mouseDrag': false, 'touchDrag': false, 'pullDrag': false, 'autoplay': true, 'autoplayTimeout': 9000, 'autoplayHoverPause': true, 'rewind': true}"">
");
#nullable restore
#line 22 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
             foreach (var itemS in slider)
            {
                var imag = StaticDetails.GetImage(itemS.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"position-relative lazy\" data-dynamic-height=\"[\'670px\',\'670px\',\'670px\',\'550px\',\'500px\']\"");
            BeginWriteAttribute("style", " style=\"", 1558, "\"", 1663, 10);
            WriteAttributeValue("", 1566, "background-image:", 1566, 17, true);
            WriteAttributeValue(" ", 1583, "url(", 1584, 5, true);
#nullable restore
#line 25 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1588, imag, 1588, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1593, ");", 1593, 2, true);
            WriteAttributeValue(" ", 1595, "background-size:", 1596, 17, true);
            WriteAttributeValue(" ", 1612, "cover;", 1613, 7, true);
            WriteAttributeValue(" ", 1619, "background-position:", 1620, 21, true);
            WriteAttributeValue(" ", 1640, "center;", 1641, 8, true);
            WriteAttributeValue(" ", 1648, "height:", 1649, 8, true);
            WriteAttributeValue(" ", 1656, "670px;", 1657, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""container position-relative z-index-1 h-100"">
                        <div class=""d-flex flex-column align-items-center justify-content-center h-100"">
                            <h3 class=""position-relative text-color-light text-5 line-height-5 font-weight-medium px-4 mb-2 appear-animation"" data-appear-animation=""fadeInDownShorter"" data-plugin-options=""{'minWindowWidth': 0}"">
                                <span class=""position-absolute right-100pct top-50pct transform3dy-n50 opacity-3"">
                                </span>
                                ");
#nullable restore
#line 31 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                           Write(itemS.SliderName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 31 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                    Write(itemS.Content1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <span class=\"position-relative\">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                               Write(itemS.Content2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </span>

                            </h3>
                            <h1 class=""text-color-light font-weight-extra-bold text-12 mb-3 appear-animation"" data-appear-animation=""blurIn"" data-appear-animation-delay=""300"" data-plugin-options=""{'minWindowWidth': 0}"">
                                ");
#nullable restore
#line 39 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                           Write(itemS.Content3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h1>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2847, "\"", 2865, 1);
#nullable restore
#line 41 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2854, itemS.Link, 2854, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-4 text-color-light font-weight-light opacity-7 mb-0 btn btn-outline btn-info mb-2\" data-plugin-animated-letters data-plugin-options=\"{\'startDelay\': 500, \'minWindowWidth\': 0}\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                           Write(itemS.ButtonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 47 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div class=\"container\" style=\"z-index:9999;\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 53 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
             foreach (var item in categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4 mb-5 mb-lg-0\">\r\n                    <div class=\"card flip-card flip-card-3d bg-transparent text-center rounded-0\"");
            BeginWriteAttribute("itemscope", " itemscope=\"", 3569, "\"", 3581, 0);
            EndWriteAttribute();
            WriteLiteral(" itemtype=\"https://schema.org/WebPage\">\r\n                        <div class=\"flip-front p-5\">\r\n                            <div class=\"flip-content my-4\">\r\n                                <img class=\"lazy\"");
            BeginWriteAttribute("src", " src=\"", 3787, "\"", 3832, 1);
#nullable restore
#line 59 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3793, StaticDetails.GetImage(item.ImagePath), 3793, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3833, "\"", 3849, 1);
#nullable restore
#line 59 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3839, item.Name, 3839, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" height:90px;\" />\r\n                                <h4 class=\"font-weight-bold text-color-primary text-4\" itemprop=\"name\">");
#nullable restore
#line 60 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                                                  Write(item.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"flip-back d-flex align-items-center p-5\"");
            BeginWriteAttribute("style", " style=\"", 4151, "\"", 4302, 10);
            WriteAttributeValue("", 4159, "background-image:", 4159, 17, true);
            WriteAttributeValue(" ", 4176, "url(", 4177, 5, true);
#nullable restore
#line 63 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4181, StaticDetails.GetImage(item.ImagePath), 4181, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4220, ")", 4220, 1, true);
            WriteAttributeValue(" ", 4221, ";", 4222, 2, true);
            WriteAttributeValue(" ", 4223, "background-size:", 4224, 17, true);
            WriteAttributeValue(" ", 4240, "cover;", 4241, 7, true);
            WriteAttributeValue(" ", 4247, "background-position:", 4248, 21, true);
            WriteAttributeValue(" ", 4268, "center;", 4269, 8, true);
            WriteAttributeValue(" ", 4276, "background-color:#1C658C;", 4277, 26, true);
            EndWriteAttribute();
            WriteLiteral(" data-original=\"\">\r\n                            <div class=\"flip-content my-4\">\r\n                                <h4 class=\"font-weight-bold text-color-light\">");
#nullable restore
#line 65 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                         Write(item.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"font-weight-light text-color-light\" itemprop=\"description\">");
#nullable restore
#line 66 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                                                Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4645, "\"", 4703, 4);
            WriteAttributeValue("", 4652, "/Urunler/", 4652, 9, true);
#nullable restore
#line 67 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4661, StringProcess.GetPath(item.Name), 4661, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4694, "/", 4694, 1, true);
#nullable restore
#line 67 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4695, item.Id, 4695, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light btn-modern text-color-dark font-weight-bold\">Ürünlere Git</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 72 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>




    <section class=""section section-custom-map appear-animation lazyload"" data-appear-animation=""fadeInUpShorter"" data-src-bg=""~/map.webp"" style=""background-color: transparent; background-position: center 0; background-repeat: no-repeat;"">
        <section class=""section section-default section-footer"">
            <div class=""container"">
");
#nullable restore
#line 82 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                 if (refrences != null && refrences.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col"">
                            <h4 class=""text-center"">Referanslarımız</h4>
                            <div class=""owl-carousel owl-theme stage-margin nav-style-1 owl-loaded owl-drag owl-carousel-init"" data-plugin-options=""{'items': 6, 'margin': 10, 'loop': false, 'nav': true, 'dots': false, 'stagePadding': 40}"" style=""height: auto;"">
                                <div class=""owl-stage-outer"">
                                    <div class=""owl-stage"" style=""transform: translate3d(-348px, 0px, 0px); transition: all 0.25s ease 0s; width: 1824px; padding-left: 40px; padding-right: 40px;"">
");
#nullable restore
#line 91 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                         for (var j = 0; j < 7; j++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""owl-item"" style=""width: 164.333px; margin-right: 10px;"">
                                                <div>
                                                    <img alt=""dummylogoref.webp"" class=""img-fluid rounded lozad"" src=""/dummylogoref.webp"">
                                                </div>
                                            </div>
");
#nullable restore
#line 98 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""owl-nav"">
                                    <button type=""button"" role=""presentation"" class=""owl-prev""></button>
                                    <button type=""button"" role=""presentation"" class=""owl-next""></button>
                                </div>
                                <div class=""owl-dots disabled"">
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 110 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n    </section>\r\n");
#nullable restore
#line 114 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
     if (blogs != null && blogs.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""row mt-4"">
                <div class=""col-lg-12 text-center appear-animation animated fadeInUpShorter appear-animation-visible"" data-appear-animation=""fadeInUpShorter"" data-appear-animation-delay=""400"" style=""animation-delay: 400ms;margin-top:50px;"">
                    <h2 class=""font-weight-normal text-6 mt-3 mb-5"">Yeni <strong class=""font-weight-extra-bold"">Bloglar</strong></h2>
                </div>
            </div>
            <div class=""row recent-posts pb-4 mb-5 appear-animation animated fadeInRightShorter appear-animation-visible"" data-appear-animation=""fadeInRightShorter"" data-appear-animation-delay=""200"" style=""animation-delay: 200ms;"">
");
#nullable restore
#line 123 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                 foreach (var itemblog in blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-3"">
                        <article>
                            <div class=""row"">
                                <div class=""col-auto pe-0"">
                                    <div class=""date"">
                                        <span class=""day text-color-dark font-weight-extra-bold"">");
#nullable restore
#line 130 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                                            Write(itemblog.CreateDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"month bg-color-primary font-weight-semibold text-color-light text-1\">");
#nullable restore
#line 131 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                                                                     Write(itemblog.CreateDate.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col ps-1\">\r\n                                    <h4 class=\"line-height-3 text-4\"><a");
            BeginWriteAttribute("href", " href=\"", 8982, "\"", 9007, 2);
            WriteAttributeValue("", 8989, "/Blog/", 8989, 6, true);
#nullable restore
#line 135 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8995, itemblog.Id, 8995, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark\">");
#nullable restore
#line 135 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                                                               Write(itemblog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <p class=\"line-height-5 pe-3 mb-1\">");
#nullable restore
#line 136 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                                                                  Write(itemblog.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a class=\"btn btn-light text-uppercase text-primary text-1 py-2 px-3 mb-1 mt-2\"");
            BeginWriteAttribute("href", " href=\"", 9264, "\"", 9289, 2);
            WriteAttributeValue("", 9271, "/Blog/", 9271, 6, true);
#nullable restore
#line 137 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 9277, itemblog.Id, 9277, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>OKU</strong><i class=\"fas fa-chevron-right text-2 ps-2\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                        </article>\r\n                    </div>\r\n");
#nullable restore
#line 142 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 145 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"















<div id=""examples"" class=""container py-2 mb-3-5"">
    <div class=""row"">

        <div class=""col-lg-12 mb-5 mb-lg-0"">
            <h4 style=""text-align: center"">Centered</h4>

            <div data-plugin-readmore="""" data-plugin-options=""{
                 'buttonOpenLabel' : 'Read More <i class=\' fas fa-chevron-down text-2 ms-1\'>
                </i>',
                'buttonCloseLabel': 'Read Less <i class=\'fas fa-chevron-up text-2 ms-1\'></i>',
                'align': 'center'
                }"" class=""position-relative"" style=""height: 110px; overflow-y: hidden;"">
               

");
#nullable restore
#line 176 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
   
                    for (var k = 0; k < 20; k++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <p style=""color:#525252"">Lorem ipsum dolor, sit amet consectetur adipisicing, elit. Totam placeat dolores, minima voluptas quo eos, repellat delectus inventore velit. Nulla placeat eius in, alias architecto magnam aliquid debitis adipisci voluptate. Lorem ipsum, dolor, sit amet consectetur adipisicing elit. Voluptate, aut. Aspernatur sapiente ad quod perspiciatis pariatur necessitatibus, omnis, labore dolore minus expedita, suscipit rerum vitae repellendus quia at aperiam laborum!</p>
                        <p style=""color:#525252"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis iusto odit quidem commodi voluptates vitae dolores temporibus itaque labore cumque nobis animi facilis, quod, nisi laboriosam sit. Veritatis tenetur, commodi.</p>
");
#nullable restore
#line 181 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""readmore-button-wrapper text-center"" style=""position: absolute; bottom: 0px; left: 0px; width: 100%; z-index: 2;"">
                    <a href=""#"" class=""text-decoration-none"">Read More <i class=""fas fa-chevron-down text-2 ms-1""></i></a>
                </div>
                <div class=""readmore-overlay"" style=""background: linear-gradient(rgba(2, 0, 36, 0) 0%, rgb(255, 255, 255) 100%); position: absolute; bottom: 0px; left: 0px; width: 100%; height: 100px; z-index: 1;""></div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
