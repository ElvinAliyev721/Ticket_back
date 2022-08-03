#pragma checksum "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d35b9152e4f3d01112ceaa1c5c4adbccd766256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Blogs), @"mvc.1.0.view", @"/Views/Blog/Blogs.cshtml")]
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
#line 1 "C:\visual\Ticket_back\Views\_ViewImports.cshtml"
using Ticket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\visual\Ticket_back\Views\_ViewImports.cshtml"
using Ticket.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\visual\Ticket_back\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\visual\Ticket_back\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\visual\Ticket_back\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d35b9152e4f3d01112ceaa1c5c4adbccd766256", @"/Views/Blog/Blogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063e00a1cd1de13d4928e7dd251d49ef9b4743bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Blogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<BlogsVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
  
    ViewData["Title"] = "Blogs";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!--page-title area-->
    <section class=""page-title-area"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-inner"">
                        <h2 class=""page-title"">OUR BLOGS</h2>
                        <ul class=""page-list"">
                            <li><a href=""/Home/Index"">Home</a></li>
                            <li>Blog</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--page-title area end-->  

    <!-- blog area Start -->
    <div class=""blog-area pd-top-150 pd-bottom-120"">
        <div class=""container"">
            <div class=""row justify-content-center"" id=""blogs-container"">

");
#nullable restore
#line 32 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
             foreach (BlogsVM item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-sm-6\">\r\n                    <div class=\"single-blog-inner\">\r\n                        <div class=\"thumb\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1213, "\"", 1276, 2);
            WriteAttributeValue("", 1219, "data:image/jpg;base64,", 1219, 22, true);
#nullable restore
#line 37 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
WriteAttributeValue("", 1241, Convert.ToBase64String(item.Image), 1241, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\">\r\n                        </div>\r\n                        <div class=\"details\">\r\n                            <div class=\"date\">");
#nullable restore
#line 40 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
                                         Write(item.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <h5><a");
            BeginWriteAttribute("href", " href=\"", 1491, "\"", 1524, 2);
            WriteAttributeValue("", 1498, "/Blog/BlogDetails/", 1498, 18, true);
#nullable restore
#line 41 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
WriteAttributeValue("", 1516, item.Id, 1516, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            <p>");
#nullable restore
#line 42 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
                          Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
            }    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- blog area End -->\r\n\r\n");
#nullable restore
#line 53 "C:\visual\Ticket_back\Views\Blog\Blogs.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Blogs", "Blog", new { page }), new PagedListRenderOptions
{
    PageClasses = new string[] { "pagination, pagination-custom" },
    LiElementClasses = new string[] { "page-item" },
    DisplayLinkToLastPage = PagedListDisplayMode.Always,
    DisplayLinkToFirstPage = PagedListDisplayMode.Always,
    ContainerDivClasses = new string[] { "col-lg-12, text-center, pagination-cont-custom" },
    ActiveLiElementClass = "active"
}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<BlogsVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
