#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac8611ae50ed8b043e790bdc29a1035559acb10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProductsBySubCategoryId), @"mvc.1.0.view", @"/Views/Product/GetProductsBySubCategoryId.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac8611ae50ed8b043e790bdc29a1035559acb10", @"/Views/Product/GetProductsBySubCategoryId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_GetProductsBySubCategoryId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDto>
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
#line 3 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
  
    var catName = Model.Products.Select(a => a.Category.Name).FirstOrDefault();
    var catId = Model.Products.Select(a => a.Category.Id).FirstOrDefault();
    Model.FilterUrl = $"/Urunler/{catName}/filter/{catId}";

    var breadcrumbdata = TempData["BreadCrumb"];
    var page = TempData["Page"];
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
#line 18 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .filtericon {\r\n        display: none;\r\n    }\r\n</style>\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 order-1 order-lg-1\">\r\n            ");
#nullable restore
#line 28 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
       Write(await Component.InvokeAsync("ProductFilter", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
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
#line 36 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
                         foreach (var item in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-sm-6 col-lg-4 card"" style=""position: absolute; left: 569.968px; top: 0px;"">
                                <div class=""product mb-0"">
                                    <div class=""product-thumb-info border-0 mb-3"">

                                        <div class=""addtocart-btn-wrapper"">
                                            <a href=""/"" class=""text-decoration-none addtocart-btn"" title=""Teklif Al"">
                                                <i class=""icon-briefcase icons""></i>
                                            </a>
                                        </div>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2083, "\"", 2142, 4);
            WriteAttributeValue("", 2090, "/Urun/", 2090, 6, true);
#nullable restore
#line 47 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
WriteAttributeValue("", 2096, StringProcess.ClearString(item.Name), 2096, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2133, "/", 2133, 1, true);
#nullable restore
#line 47 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
WriteAttributeValue("", 2134, item.Id, 2134, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-thumb-info-image\">\r\n                                                <img");
            BeginWriteAttribute("alt", " alt=\"", 2282, "\"", 2298, 1);
#nullable restore
#line 49 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
WriteAttributeValue("", 2288, item.Name, 2288, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2317, "\"", 2362, 1);
#nullable restore
#line 49 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
WriteAttributeValue("", 2323, StaticDetails.GetImage(item.ImagePath), 2323, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                                            </div>
                                        </a>
                                    </div>
                                    <div class=""d-flex justify-content-between mb-3"">
                                        <div>
");
#nullable restore
#line 56 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
                                             foreach (var itemF in item.FeatureDescriptions)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"d-block text-uppercase text-decoration-none text-color-default text-color-hover-primary line-height-1 text-0 mb-1\">");
#nullable restore
#line 58 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
                                                                                                                                                                        Write(itemF.FeatureDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 59 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3 class=\"text-3-5 font-weight-medium font-alternative text-transform-none line-height-3 mb-0\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3221, "\"", 3280, 4);
            WriteAttributeValue("", 3228, "/Urun/", 3228, 6, true);
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
WriteAttributeValue("", 3234, StringProcess.ClearString(item.Name), 3234, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3271, "/", 3271, 1, true);
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
WriteAttributeValue("", 3272, item.Id, 3272, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-color-dark text-color-hover-primary\">");
#nullable restore
#line 61 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
                                                                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </h3>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 68 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"bounce-loader\"><div class=\"bounce1\"></div><div class=\"bounce2\"></div><div class=\"bounce3\"></div></div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 73 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
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
#line 82 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Product\GetProductsBySubCategoryId.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac8611ae50ed8b043e790bdc29a1035559acb1013557", async() => {
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
            WriteLiteral(@"
<script>
    $('#filterbutton').css('display', 'none');
    var mainUrl = ""https://localhost:44396/"";
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
            var chekedFaetureId = $(this).");
            WriteLiteral(@"attr('data-fetureval');
            checkedVals.push(parseInt(chekedval));
            chekedFaetureIds.push(parseInt(chekedFaetureId));
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
