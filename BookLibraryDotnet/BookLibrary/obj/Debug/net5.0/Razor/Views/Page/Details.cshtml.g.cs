#pragma checksum "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cbf85e3d1c14d902b34559a60daf146d34eca13f05c2545920102b040467f60f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Details), @"mvc.1.0.view", @"/Views/Page/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cbf85e3d1c14d902b34559a60daf146d34eca13f05c2545920102b040467f60f", @"/Views/Page/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d0dc3c95b8b6db658e44ef9b1991bcbb916f8a2b8e2dbbe78e29acff423a5900", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Page_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookLibrary.Models.Page>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/page/{Model.Alias}";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Parallax Section --><div class=""tg-innerbanner tg-haslayout tg-parallax tg-bginnerbanner"" data-z-index=""-20"" data-appear-top-offset=""600"" data-parallax=""scroll"" style=""background-image: url('https://nhadepso.com/wp-content/uploads/2023/03/101-hinh-nen-sach-dep-an-tuong-cho-may-tinh-hoac-dien-thoai_4.jpg');
                background-size: cover;
                background-position: center;
                min-height: 400px;
                display: flex;
                justify-content: center;
                align-items: center;"">

    <div class=""container"">
        <div class=""row"">
            <!-- Breadcrumb Area -->
            <div class=""breadcrumb-area breadcrumb-height""");
            BeginWriteAttribute("style", " style=\"", 875, "\"", 954, 4);
            WriteAttributeValue("", 883, "background-image:", 883, 17, true);
            WriteAttributeValue(" ", 900, "url(\'", 901, 6, true);
#nullable restore
#line 20 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
WriteAttributeValue("", 906, Url.Content("~/images/pages/" + Model.Thumb), 906, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 951, "\');", 951, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""container h-100"">
                    <div class=""row h-100 justify-content-center align-items-center"">
                        <div class=""col-lg-12 text-center"">
                            <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 24 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
                                                      Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                            <ul class=""breadcrumb-links list-inline"">
                                <li class=""list-inline-item"">
                                    <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                                </li>
                                <li class=""list-inline-item"">");
#nullable restore
#line 29 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
                                                        Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Main Content Section -->
<div class=""main-content"">

  


    <!-- Blog Area -->
    <div class=""blog-area section-space-y-axis-100 py-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-img mb-4"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 2171, "\"", 2222, 1);
#nullable restore
#line 52 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
WriteAttributeValue("", 2177, Url.Content("~/images/pages/" + Model.Thumb), 2177, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2223, "\"", 2241, 1);
#nullable restore
#line 52 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
WriteAttributeValue("", 2229, Model.Title, 2229, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date"">
                                        <i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 58 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
                                                                        Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </li>
                                    <li>
                                        <span class=""comments me-3"">
                                            <a href=""javascript:void(0)"">2 Comments</a>
                                        </span>
                                        <span class=""link-share"">
                                            <a href=""javascript:void(0)"">Share</a>
                                        </span>
                                    </li>
                                </ul>
                            </div>
                            <h5 class=""title mb-4"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 3304, "\"", 3315, 1);
#nullable restore
#line 71 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
WriteAttributeValue("", 3311, url, 3311, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
                                          Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <div class=\"content\">\r\n                                ");
#nullable restore
#line 74 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Page\Details.cshtml"
                           Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.Models.Page> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
