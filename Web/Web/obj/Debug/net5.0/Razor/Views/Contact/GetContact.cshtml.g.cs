#pragma checksum "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce7d586cd8b12709e69b92c768e77400d3801792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_GetContact), @"mvc.1.0.view", @"/Views/Contact/GetContact.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
using Web.Models.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7d586cd8b12709e69b92c768e77400d3801792", @"/Views/Contact/GetContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f086613b28cfe21d51b1d61e33cdc538b8ee563", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_GetContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
  
    var breadcrumbdata = TempData["BreadCrumb"];
    var page = TempData["Page"];
    TempData["Title"] = page;
    var errorMessage = TempData["ErrorMail"];
    var successMessage = TempData["SuccessMail"];
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
#line 16 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
Write(await Component.InvokeAsync("BreadCrumb", breadcrumb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
 if (errorMessage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"err\" class=\"alert alert-danger\"  style=\"text-align:center;\">\r\n        ");
#nullable restore
#line 20 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
   Write(errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
 if (successMessage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"succ\" class=\"alert alert-success\"  style=\"text-align:center;\">\r\n        ");
#nullable restore
#line 26 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
   Write(errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"googlemaps\" class=\"google-map mt-0\" style=\"height: 475px; position: relative; overflow: hidden;\">\r\n");
            WriteLiteral("</div>\r\n<div class=\"container\">\r\n\r\n    <div class=\"row py-4\">\r\n\r\n        ");
#nullable restore
#line 36 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
   Write(await Component.InvokeAsync("ContactForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "C:\Users\MONSTER\source\repos\camasirhaneekipmanlari\Web\Web\Views\Contact\GetContact.cshtml"
   Write(await Component.InvokeAsync("GetInTouch", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce7d586cd8b12709e69b92c768e77400d38017927119", async() => {
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
    var error = document.getElementById(""err"");
    var success = document.getElementById(""succ"");

    if (error != null) {
        function GFG_Fun() {
            setTimeout(function () {
                $('#err').hide();
            }, 3000);
        };
        GFG_Fun();
    }
    if (success != null) {
        function GFG_Fun() {
            setTimeout(function () {
                $('#succ').hide();
            }, 6000);
        };
        GFG_Fun();
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
