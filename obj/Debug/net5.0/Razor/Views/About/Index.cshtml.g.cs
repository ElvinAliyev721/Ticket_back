#pragma checksum "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035c9cecae6cd128a5b9fdc5155b5bbfbb53dc64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\vusal\Desktop\Ticket_back\Views\_ViewImports.cshtml"
using Ticket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vusal\Desktop\Ticket_back\Views\_ViewImports.cshtml"
using Ticket.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vusal\Desktop\Ticket_back\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vusal\Desktop\Ticket_back\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vusal\Desktop\Ticket_back\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035c9cecae6cd128a5b9fdc5155b5bbfbb53dc64", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063e00a1cd1de13d4928e7dd251d49ef9b4743bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/MainPageTemplate/assets/img/about/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/MainPageTemplate/assets/img/about/2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/MainPageTemplate/assets/img/about/3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--page-title area-->\r\n    <section class=\"page-title-area\"");
            BeginWriteAttribute("style", " style=\"", 174, "\"", 218, 3);
            WriteAttributeValue("", 182, "background-image:url(\'", 182, 22, true);
#nullable restore
#line 8 "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml"
WriteAttributeValue("", 204, Model.Image, 204, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 216, "\')", 216, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""breadcrumb-inner"">
                        <h2 class=""page-title"">About Us</h2>
                        <p class=""text-white""> ");
#nullable restore
#line 15 "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--page-title area end-->  

    <!-- About area Start -->
    <div class=""about-area"">
        <div class=""row no-gutters"">
            <div class=""col-lg-6 col-md-8"">
                <div class=""thumb"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "035c9cecae6cd128a5b9fdc5155b5bbfbb53dc646763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-xl-4 col-lg-6 offset-xl-1 mt-lg-0 mt-4 align-self-center"">
                <div class=""about-inner"">
                    <div class=""section-title m-0"">
                        <h2>About Us</h2>
                        <p>");
#nullable restore
#line 35 "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml"
                      Write(Model.Description_1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row no-gutters"">
            <div class=""col-lg-6 offset-xl-1 col-md-8  order-lg-last"">
                <div class=""thumb"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "035c9cecae6cd128a5b9fdc5155b5bbfbb53dc648671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-xl-4 col-lg-6 offset-xl-1 mt-lg-0 mt-4 align-self-center order-lg-first"">
                <div class=""about-inner"">
                    <div class=""section-title m-0"">
                        <h2>About Us</h2>
                        <p> ");
#nullable restore
#line 50 "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml"
                       Write(Model.Description_2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-lg-6 col-md-8\">\r\n                <div class=\"thumb\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "035c9cecae6cd128a5b9fdc5155b5bbfbb53dc6410585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-xl-4 col-lg-6 offset-xl-1 mt-lg-0 mt-4 align-self-center"">
                <div class=""about-inner"">
                    <div class=""section-title m-0"">
                        <h2>About Us</h2>
                        <p>");
#nullable restore
#line 65 "C:\Users\vusal\Desktop\Ticket_back\Views\About\Index.cshtml"
                      Write(Model.Description_3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- About area end -->

    <div class=""location-area main-map-location pd-top-120 pd-bottom-140"">
        <div class=""container"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3688.2434350836393!2d91.75780181427078!3d22.419861544211244!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x30acd7563e8565cf%3A0x2529424c9fcf58c7!2sChittagong%20Bricks%20%26%20Clay%20Works%20Ltd!5e0!3m2!1sen!2sbd!4v1594866827735!5m2!1sen!2sbd""></iframe>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
