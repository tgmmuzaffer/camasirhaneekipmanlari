#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a26ff2b465b6fb8eeaab31705152b3b636c4a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProductByBrandId), @"mvc.1.0.view", @"/Views/Product/GetProductByBrandId.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a26ff2b465b6fb8eeaab31705152b3b636c4a7a", @"/Views/Product/GetProductByBrandId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_GetProductByBrandId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
  
    Model.FilterUrl = "/Urunler/filter";

    var breadcrumbdata = TempData["BreadCrumb"];
    var page = TempData["Page"];
    TempData["Title"] = page;
    string _page = page.ToString();
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
#line 19 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .filtericon {\r\n        display: none;\r\n    }\r\n</style>\r\n<div class=\"container\"");
            BeginWriteAttribute("itemscope", " itemscope=\"", 621, "\"", 633, 0);
            EndWriteAttribute();
            WriteLiteral(" itemtype=\"https://schema.org/WebPage\">\r\n    <span style=\"display:none;\">");
#nullable restore
#line 26 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
                           Write(_page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 order-1 order-lg-1\">\r\n            ");
#nullable restore
#line 29 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
       Write(await Component.InvokeAsync("ProductFilter", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
         if (Model.Products != null && Model.Products.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-9 order-2 order-lg-2"">

                <div class=""masonry-loader masonry-loader-loaded"">
                    <div id=""dynamicDiv"" class=""row products product-thumb-info-list"" data-plugin-masonry="""" data-plugin-options=""{'layoutMode': 'fitRows'}"" style=""position: relative; height: 1064.39px;"">
");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
                         foreach (var item in Model.Products)
                        {
                             var brandname = item.ProductSeos.Where(a => a.Feature == "Marka").Select(b => b.FeatureDescription).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-6 col-lg-4 card\" style=\"position: absolute; left: 569.968px; top: 0px;\" itemtype=\"https://schema.org/Product\" itemscope>\r\n                                <meta itemprop=\"name\"");
            BeginWriteAttribute("content", " content=\"", 1746, "\"", 1766, 1);
#nullable restore
#line 41 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 1756, item.Name, 1756, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <link itemprop=\"image\"");
            BeginWriteAttribute("href", " href=\"", 1826, "\"", 1872, 1);
#nullable restore
#line 42 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 1833, StaticDetails.GetImage(item.ImagePath), 1833, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <meta itemprop=\"description\"");
            BeginWriteAttribute("content", " content=\"", 1938, "\"", 1963, 1);
#nullable restore
#line 43 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 1948, item.ShortDesc, 1948, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <div class=\"product mb-0\" itemprop=\"offers\" itemtype=\"https://schema.org/Offer\" itemscope>\r\n                                    <link itemprop=\"url\"");
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2208, 4);
            WriteAttributeValue("", 2156, "/Urun/", 2156, 6, true);
#nullable restore
#line 45 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 2162, StringProcess.ClearString(item.Name), 2162, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2199, "/", 2199, 1, true);
#nullable restore
#line 45 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 2200, item.Id, 2200, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                    <meta itemprop=""availability"" content=""https://schema.org/InStock"" />
                                    <meta itemprop=""priceCurrency"" content=""TL"" />
                                    <div class=""product-thumb-info border-0 mb-3"">

                                        <div class=""addtocart-btn-wrapper"">
                                            <a href=""/"" class=""text-decoration-none addtocart-btn"" title=""Teklif Al"">
                                                <i class=""icon-briefcase icons""></i>
                                            </a>
                                        </div>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2913, "\"", 2972, 4);
            WriteAttributeValue("", 2920, "/Urun/", 2920, 6, true);
#nullable restore
#line 55 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 2926, StringProcess.ClearString(item.Name), 2926, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2963, "/", 2963, 1, true);
#nullable restore
#line 55 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 2964, item.Id, 2964, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-thumb-info-image\">\r\n                                                <img");
            BeginWriteAttribute("alt", " alt=\"", 3112, "\"", 3128, 1);
#nullable restore
#line 57 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 3118, item.Name, 3118, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 3147, "\"", 3192, 1);
#nullable restore
#line 57 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 3153, StaticDetails.GetImage(item.ImagePath), 3153, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                                            </div>
                                        </a>
                                    </div>
                                    <div class=""d-flex justify-content-between mb-3"" itemprop=""brand"" itemtype=""https://schema.org/Brand"" itemscope>
                                         <meta itemprop=""name""");
            BeginWriteAttribute("content", " content=\"", 3552, "\"", 3572, 1);
#nullable restore
#line 63 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 3562, brandname, 3562, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <div>\r\n");
#nullable restore
#line 65 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
                                             foreach (var itemF in item.FeatureDescriptions)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"d-block text-uppercase text-decoration-none text-color-default text-color-hover-primary line-height-1 text-0 mb-1\">");
#nullable restore
#line 67 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
                                                                                                                                                                        Write(itemF.FeatureDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 68 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3 class=\"text-3-5 font-weight-medium font-alternative text-transform-none line-height-3 mb-0\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4202, "\"", 4261, 4);
            WriteAttributeValue("", 4209, "/Urun/", 4209, 6, true);
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 4215, StringProcess.ClearString(item.Name), 4215, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4252, "/", 4252, 1, true);
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
WriteAttributeValue("", 4253, item.Id, 4253, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-color-dark text-color-hover-primary\">");
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
                                                                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </h3>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 77 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"bounce-loader\"><div class=\"bounce1\"></div><div class=\"bounce2\"></div><div class=\"bounce3\"></div></div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 84 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-9 order-2 order-lg-2 card card-border card-border-top bg-color-light mt-4-5"">
                <div class=""card-body"">
                    <h4 class=""card-title mb-1 text-4 font-weight-bold"">Ürün Bulunamadı</h4>
                    <p class=""card-text"">Henüz aradığınız kriterlere sahip ürünümüz bulunmamaktadır.</p>
                </div>
            </div>
");
#nullable restore
#line 93 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a26ff2b465b6fb8eeaab31705152b3b636c4a7a17181", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var mainUrl = ");
#nullable restore
#line 98 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductByBrandId.cshtml"
             Write(StaticDetails.currentsiteUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var screenwidht = $(window).width();
    if (992 > screenwidht) {
        $('#filtericon').css('display', 'block');
        var filtertitle = document.getElementById('filtertitle');
        filtertitle.className = ""accordion-toggle"";
        filtertitle.setAttribute('data-bs-toggle', 'collapse');
        filtertitle.setAttribute('data-bs-target', '#collapse1One');
        filtertitle.setAttribute('aria-expanded', 'false');
        filtertitle.setAttribute('aria-controls', 'collapse1One');
        var colapsediv = document.getElementById('collapse1One');
        colapsediv.className = ""collapse"";
    }

    function checkBoxProcess() {
        var checkedVals = [];
        var chekedFaetureIds = [];
        var resetvals = [];
        $('input:checkbox[name=filterinput]:checked').each(function (e) {
            var chekedval = $(this).val();
            var chekedFaetureId = $(this).attr('data-fetureval');
            checkedVals.push(parseInt(chekedval));
            chekedFaetur");
            WriteLiteral(@"eIds.push(parseInt(chekedFaetureId));
        });
        if (checkedVals.length > 0) {
            $('#filterbutton').css('display', 'block');
            $(""#SelectedFilterfeatureDescItems"").val(resetvals);
            $(""#SelectedFilterfeatureItems"").val(resetvals);
            $(""#SelectedFilterfeatureDescItems"").val(checkedVals);
            $(""#SelectedFilterfeatureItems"").val(chekedFaetureIds);
        }
        else {
            $(""#SelectedFilterfeatureDescItems"").val(resetvals);
            $(""#SelectedFilterfeatureItems"").val(resetvals);
            $('#filterbutton').css('display', 'none');
        }
    }

    checkBoxProcess();

    $('#filterform input[name=""filterinput""]').change('input', function () {
        checkBoxProcess();
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
