#pragma checksum "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c395dbc908f0f05ae38ba3f17aa486e8df8d84e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Blog/Index.cshtml")]
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
#line 1 "C:\visual\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using Ticket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\visual\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using Ticket.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\visual\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\visual\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\visual\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\visual\Ticket_back\Areas\AdminPanel\_ViewImports.cshtml"
using Ticket.Areas.AdminPanel.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c395dbc908f0f05ae38ba3f17aa486e8df8d84e", @"/Areas/AdminPanel/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8628f29a36cb492eff7a5a6701731886ddd4de44", @"/Areas/AdminPanel/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<BlogsVMA>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pt-3"">
    <div class=""table-bg"">
        <div class=""card-header-custom"">
            <h3>Bloqlar</h3>
            <a href=""/AdminPanel/Blog/BlogAdd"" class=""btn custom-admin-button""><span>Yeni Bloq</span> <i class='bx bxs-book-add'></i></a>
        </div>
        <div class=""card-body mt-2"">
            <div class=""table-responsive"">
                <table class=""table-custom"" style=""width: 100%;"">
                    <thead class=""thead-custom"">
                        <tr>
                            <td>#</td>
                            <td>Başlıq</td>
                            <td>Baxış sayı</td>
                            <td>Yaradılma tarixi</td>
                            <td>Əməliyyatlar</td>
                        </tr>
                    </thead>
                    <tbody class=""tbody-custom"">
");
#nullable restore
#line 27 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                         foreach(var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"my-table-data\">");
#nullable restore
#line 30 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"my-table-data\">");
#nullable restore
#line 31 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><i class=\'bx bxs-user\'></i> ");
#nullable restore
#line 32 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                                                           Write(item.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("id", " id=\"", 1361, "\"", 1385, 2);
            WriteAttributeValue("", 1366, "table-data-", 1366, 11, true);
#nullable restore
#line 33 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1377, item.Id, 1377, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 34 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status green\"></span><span> Aktiv</span>\r\n");
#nullable restore
#line 37 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status red\"></span>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1814, "\"", 1846, 3);
            WriteAttributeValue("", 1824, "activateBlog(", 1824, 13, true);
#nullable restore
#line 41 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1837, item.Id, 1837, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1845, ")", 1845, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Aktiv et</a>\r\n");
#nullable restore
#line 42 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td class=\"d-flex justify-content-between\">\r\n                                    <button class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2113, "\"", 2144, 3);
            WriteAttributeValue("", 2123, "BlogDetails(", 2123, 12, true);
#nullable restore
#line 45 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2135, item.Id, 2135, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2143, ")", 2143, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\'bx bxs-detail\'></i></button>\r\n                                    <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 2245, "\"", 2286, 2);
            WriteAttributeValue("", 2252, "/AdminPanel/Blog/BlogEdit/", 2252, 26, true);
#nullable restore
#line 46 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2278, item.Id, 2278, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\'bx bxs-edit\' ></i></a>\r\n                                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2379, "\"", 2406, 3);
            WriteAttributeValue("", 2389, "delBlog(", 2389, 8, true);
#nullable restore
#line 47 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2397, item.Id, 2397, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2405, ")", 2405, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\"><i class=\'bx bxs-trash\' ></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 50 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 58 "C:\visual\Ticket_back\Areas\AdminPanel\Views\Blog\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", "Blog", new { page }), new PagedListRenderOptions
{
    PageClasses = new string[] { "page-link bg-dark text-light border-dark" },
    LiElementClasses = new string[] { "page-item" },
    DisplayLinkToLastPage = PagedListDisplayMode.Always,
    DisplayLinkToFirstPage = PagedListDisplayMode.Always,
    ContainerDivClasses = new string[] { "p-1 pt-3" },
    ActiveLiElementClass = "active-page"
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function delBlog(blog_id) {
            const swalWithBootstrapButtons = Swal.mixin({
                customClass: {
                    confirmButton: 'btn btn-success',
                    cancelButton: 'btn btn-danger mr-3'
                },
                buttonsStyling: false
            })

            swalWithBootstrapButtons.fire({
                title: 'Əminsiniz?',
                text: ""İstədiyin vaxt bu Bloqu aktiv edə bilərsən!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonText: 'Bəli, bunu sil!',
                cancelButtonText: 'Xeyr, ləğv et!',
                reverseButtons: true
            }).then((result) => {
                if (result.isConfirmed) {
                    let timerInterval
                    Swal.fire({
                        title: 'Silinir...!',
                        html: 'Bunu <b></b> millisaniyələr ərzində siləcəm.',
                        timer: 1000,
   ");
                WriteLiteral(@"                     timerProgressBar: true,
                        didOpen: () => {
                            $.ajax({
                                type: 'POST',
                                url: '/AdminPanel/Blog/DeleteBlog/',
                                data: { id: blog_id }
                            });
                            Swal.showLoading()
                            const b = Swal.getHtmlContainer().querySelector('b')
                            timerInterval = setInterval(() => {
                                b.textContent = Swal.getTimerLeft()
                            }, 100)
                        },
                        willClose: () => {
                            clearInterval(timerInterval)
                        }
                    }).then((result) => {
                        Swal.fire({
                            icon: 'success',
                            title: 'Silindi!',
                            text: 'Bu bloq uğurla silindi!'
");
                WriteLiteral(@"                        });
                        document.getElementById(""table-data-"" + blog_id).innerHTML = `<span class=""status red""></span>
                                            <a onclick=""activateBlog(${blog_id})"" class=""btn btn-outline-success"">Aktiv et</a>`;
                    });
                } else if (
                    result.dismiss === Swal.DismissReason.cancel
                ) {
                    swalWithBootstrapButtons.fire(
                        'Ləğv edildi',
                        'Bloq qurtarıldı :)',
                        'error'
                    )
                }
            })
        }

        function activateBlog(blog_id) {
            let timerInterval
            Swal.fire({
                title: 'Aktiv edilir...!',
                html: 'Bunu <b></b> millisaniyələr ərzində aktiv edəcəm.',
                timer: 1000,
                timerProgressBar: true,
                didOpen: () => {
                    $.ajax({
        ");
                WriteLiteral(@"                type: 'POST',
                        url: '/AdminPanel/Blog/ActivateBlog/',
                        data: { id: blog_id }
                    });
                    Swal.showLoading()
                    const b = Swal.getHtmlContainer().querySelector('b')
                    timerInterval = setInterval(() => {
                        b.textContent = Swal.getTimerLeft()
                    }, 100)
                },
                willClose: () => {
                    clearInterval(timerInterval)
                }
            }).then((result) => {
                Swal.fire({
                    icon: 'success',
                    title: 'Aktiv edildi!',
                    text: 'Bloq uğurla aktiv edildi!'
                });
                document.getElementById(""table-data-"" + blog_id).innerHTML = `<span class=""status green""></span><span> Aktiv</span>`;
            });
        }

        function BlogDetails(blog_id) {
            $(function () {
             ");
                WriteLiteral(@"   $.ajax({
                    contentType: 'application/json',
                    dataType: 'json',
                    type: 'GET',
                    url: '/AdminPanel/Blog/BlogDetails/',
                    data: { id: blog_id },
                    success: function (myvalue) {
                        let data = jQuery.parseJSON(myvalue);
                        Swal.fire({
                            title: `<div class=""text-center"">Bloqun detalları</div>`, /*<div class=""text-center""><img class=""detail-img"" src=""/WriterImageFiles/${data}"" /></div><hr /><span>Details of </span><strong class=""text-info"">${data.UserName}</strong>*/
                            html:
                                `<h4 class=""text-info""><b>#${data.Id} - ${data.Title}</b></h4>
                                    <h6><span>${data.Content.substring(0,150)}</span></h6>
                                    <h6 class=""text-info""> Status : ${data.Status?'Aktiv':'DeAktiv'}</h6>
                                    <h");
                WriteLiteral(@"6 class=""text-muted""> Tarix : ${data.Date.replace('T',' ')}</h6>
                                    <br />
                                    <h5 class=""text-dark""><b>Baxış sayı : ${data.Views}</b></h5>`,
                            showCloseButton: true,
                            showCancelButton: true,
                            focusConfirm: false,
                            confirmButtonText:
                                `<a class=""text-white nav-link p-0"" href=""/AdminPanel/Blog/BlogEdit/${blog_id}""><i class='bx bxs-edit'></i> Bloqu düzənlə</a>`,
                            confirmButtonAriaLabel: 'Edit',
                            cancelButtonText:
                                '<span><i class=""bx bxs-left-arrow-circle"" ></i> Oldu</span>',
                            cancelButtonAriaLabel: 'Okay'
                        });
                    }
                })
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<BlogsVMA>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
