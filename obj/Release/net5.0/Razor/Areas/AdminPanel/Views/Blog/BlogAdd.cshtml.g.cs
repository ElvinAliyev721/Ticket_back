#pragma checksum "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62179b18fe7adbabd9397ffeb94f17ee4c859dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Blog/BlogAdd.cshtml")]
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
#line 1 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using Ticket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using Ticket.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using Ticket.Areas.AdminPanel.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62179b18fe7adbabd9397ffeb94f17ee4c859dcf", @"/Areas/AdminPanel/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8628f29a36cb492eff7a5a6701731886ddd4de44", @"/Areas/AdminPanel/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogsVMA>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Common/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger font-weight-bold ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62179b18fe7adbabd9397ffeb94f17ee4c859dcf5083", async() => {
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
<div class=""container p-4"">
    <div class=""bg-light white-card"">
        <div>
            <div class=""text-center p-3"">
                <h1>Yeni Bloq yarat</h1>
            </div>
            <div class=""pt-4"">
                <div>
                    <div class=""profile-img-input"">
                        <input type=""file"" class=""form-control"" id=""pp-img"">
                    </div>
                    <div class=""text-center mt-3"">
                        <p class=""text-danger"">");
#nullable restore
#line 20 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\Views\Blog\BlogAdd.cshtml"
                                          Write(TempData["ImageError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""text-center mt-5"">
                        <div class=""profile d-flex justify-content-center align-items-center m-auto"">
                            <img class=""profile-img"" id=""img-viewer"">
                            <label for=""pp-img"" class=""camera-icon""><i class='bx bxs-camera-plus' ></i></label>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62179b18fe7adbabd9397ffeb94f17ee4c859dcf7348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 27 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\Views\Blog\BlogAdd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Image);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"p-3\">\r\n                        <label for=\"tb-title\">Bloq başlığı</label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62179b18fe7adbabd9397ffeb94f17ee4c859dcf9102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 31 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\Views\Blog\BlogAdd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <input id=""tb-title"" class=""form-control"" type=""text"" placeholder=""Bloq başlığı..."" required />
                    </div>
                    <div class=""p-3"">
                        <label for=""tb-content"">Bloqun məzmunu</label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62179b18fe7adbabd9397ffeb94f17ee4c859dcf10982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 36 "C:\Users\vusal\Desktop\Ticket_back\Areas\AdminPanel\Views\Blog\BlogAdd.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <textarea id=""tb-content"" class=""form-control"" rows=""20"" placeholder=""Bloqun məzmunu..."" required></textarea>
                    </div>
                    <div class=""text-center p-3"">
                        <button type=""button"" onclick=""window.location.href='/AdminPanel/Blog/Index'"" class=""custom-admin-cancel"">Ləğv et</button>
                        <button type=""button"" id=""btn-save"" class=""custom-admin-button"">Yarat</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(""#pp-img"").change(function(event) {
        let files = event.target.files;
        $(""#img-viewer"").attr(""src"", window.URL.createObjectURL(files[0]));
    });

    $(""#btn-save"").click(function() {
        let files = $(""#pp-img"").prop(""files"");
        let formData = new FormData();
        for (let i = 0; i < files.length; i++) {
            formData.append(""file"", files[i]);
        }
        let oBlog = {
    ");
            WriteLiteral(@"        title: $(""#tb-title"").val(),
            content: $(""#tb-content"").val()
        };
        formData.append(""Blog"", JSON.stringify(oBlog));
        console.log(formData);
        $.ajax({
            type: ""POST"",
            url: ""/AdminPanel/Blog/BlogAdd"",
            data: formData,
            processData: false,
            contentType: false,
            success: function(data) {
                window.location.href = '/AdminPanel/Blog/Index';
            },
            error: function(data) {
                alert('Error:', data);
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogsVMA> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591