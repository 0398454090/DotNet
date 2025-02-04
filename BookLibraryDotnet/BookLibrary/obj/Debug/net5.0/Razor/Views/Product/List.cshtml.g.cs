#pragma checksum "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "653b48df34b95c5b2d10e5e9b83f113c2cffe4644b4daff1ae14b8cf15651fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#nullable restore
#line 2 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"653b48df34b95c5b2d10e5e9b83f113c2cffe4644b4daff1ae14b8cf15651fa3", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d0dc3c95b8b6db658e44ef9b1991bcbb916f8a2b8e2dbbe78e29acff423a5900", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<BookLibrary.Models.Product>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
  
    var category = ViewBag.CurrentCat;
    ViewData["Title"] = category.Title + " " + ViewBag.CurrentPage; 
    Layout = "~/Views/Shared/_Layout.cshtml"; 
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "653b48df34b95c5b2d10e5e9b83f113c2cffe4644b4daff1ae14b8cf15651fa33856", async() => {
                WriteLiteral(@"
    <div class=""breadcrumb-area breadcrumb-height"" style=""background-image: url('~/assets/images/breadcrumb/bg/1-1-1920x.jpg');"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"" style=""text-align: center; padding: 20px 0;"">
                        <h1 class=""breadcrumb-heading"" style=""font-size: 2em; margin-bottom: 10px;"">");
#nullable restore
#line 18 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                               Write(category.CatName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                        <ul style=""list-style-type: none; padding: 0; display: inline;"">
                            <li style=""display: inline;"">
                                <a href=""javascript:history.back()"" style=""text-decoration: none; color: #000;"">
                                    <i class=""fa fa-arrow-left"" style=""color: #007bff;""></i> Quay lại <i class=""pe-7s-angle-right""></i>
                                </a>
                            </li>
                            <li style=""display: inline; padding: 0 10px;"">
                                <a href=""/"" style=""text-decoration: none; color: #000;"">
                                    <i class=""fa fa-home"" style=""color: #28a745;""></i> Home <i class=""pe-7s-angle-right""></i>
                                </a>
                            </li>
                            <li style=""display: inline; padding: 0 10px;"">");
#nullable restore
#line 30 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                     Write(category.CatName);

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

    <div id=""tg-wrapper"" class=""tg-wrapper tg-haslayout"">
        <main id=""tg-main"" class=""tg-main tg-haslayout"">
            <div class=""tg-sectionspace tg-haslayout"">
                <div class=""container"">
                    <div class=""row"">
                        <div id=""tg-twocolumns"" class=""tg-twocolumns"">
                            <div class=""col-xs-12 col-sm-8 col-md-8 col-lg-9 pull-right"">
                                <div id=""tg-content"" class=""tg-content"">
                                    <div class=""tg-products"">
                                        <div class=""tg-productgrid"">
                                            <div class=""tg-refinesearch"">
                                                <span>Hiện ");
#nullable restore
#line 50 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                      Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(" trong tổng số ");
#nullable restore
#line 50 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                   Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" sản phẩm</span>\r\n                                            </div>\r\n\r\n                                            <div class=\"row\">\r\n");
#nullable restore
#line 54 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                 if (Model != null && Model.Count() > 0)
                                                {
                                                    foreach (var item in Model)
                                                    {
                                                        string url = $"/{item.Alias}--{item.ProductId}.html"; 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                        <div class=""col-xs-6 col-sm-6 col-md-4 col-lg-3"">
                                                            <div class=""tg-postbook"">
                                                                <figure class=""tg-featureimg"">
                                                                    <a");
                BeginWriteAttribute("href", " href=\"", 3601, "\"", 3612, 1);
#nullable restore
#line 62 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 3608, url, 3608, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                                        <div class=""tg-bookimg"">
                                                                            <div class=""tg-frontcover"">
                                                                                <img");
                BeginWriteAttribute("src", " src=\"", 3903, "\"", 3920, 1);
#nullable restore
#line 65 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 3909, item.Thumb, 3909, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3921, "\"", 3944, 1);
#nullable restore
#line 65 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 3927, item.ProductName, 3927, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"">
                                                                            </div>
                                                                        </div>
                                                                    </a>
                                                                </figure>

                                                                <div class=""tg-postbookcontent"">
                                                                    <ul class=""tg-bookscategories"">
                                                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 4563, "\"", 4574, 1);
#nullable restore
#line 73 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 4570, url, 4570, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 73 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                      Write(item.Cat);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a></li>
                                                                    </ul>
                                                                    <div class=""tg-themetagbox""><span class=""tg-themetag"">sale</span></div>
                                                                    <div class=""tg-booktitle"" style=""margin-bottom: 10px"">
                                                                        <h3><a");
                BeginWriteAttribute("href", " href=\"", 5014, "\"", 5025, 1);
#nullable restore
#line 77 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 5021, url, 5021, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 77 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                      Write(Truncate(item.ProductName, 30));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h3>\r\n                                                                    </div>\r\n                                                                    <span class=\"tg-bookwriter\">Tác giả: <a");
                BeginWriteAttribute("href", " href=\"", 5252, "\"", 5263, 1);
#nullable restore
#line 79 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 5259, url, 5259, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 79 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                                                   Write(Truncate(item.AuthorName, 20));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a></span>
                                                                    <span class=""tg-stars"" style=""margin-bottom: 10px""><span></span></span>
                                                                    <span class=""tg-bookprice"" style=""margin-bottom: 10px;"">
                                                                        <ins>
                                                                            <span id=""productPrice"" style=""color: #ff5722; font-size: 26px;"">
                                                                                ");
#nullable restore
#line 84 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                            Write(item.Price.HasValue ? item.Price.Value.ToString("N0") : "Không có dữ liệu");

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VND
                                                                            </span>
                                                                        </ins>
                                                                    </span>
                                                                    <a class=""tg-btn tg-btnstyletwo add-to-cart"" data-product-id=""");
#nullable restore
#line 88 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                                                             Write(item.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                                        <span class=""btn-content"">
                                                                            <i class=""fa fa-shopping-basket""></i>
                                                                            <em>Thêm giỏ hàng</em>
                                                                        </span>
                                                                    </a>
                                                                </div>
                                                            </div>
                                                        </div>
");
#nullable restore
#line 97 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                    <div class=""pagination-area pt-10"">
                                        <ul class=""pagination"">
");
#nullable restore
#line 104 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                             if (Model.HasPreviousPage)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 7677, "\"", 7775, 1);
#nullable restore
#line 107 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 7684, Url.Action("List", "Product", new { Alias = category.Alias, page = Model.PageNumber - 1 }), 7684, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"Previous\">\r\n                                                        <span aria-hidden=\"true\">&laquo;</span>\r\n                                                    </a>\r\n                                                </li>\r\n");
#nullable restore
#line 111 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 113 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                             for (int i = 1; i <= Model.PageCount; i++)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <li");
                BeginWriteAttribute("class", " class=\"", 8247, "\"", 8305, 2);
                WriteAttributeValue("", 8255, "page-item", 8255, 9, true);
#nullable restore
#line 115 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue(" ", 8264, i == Model.PageNumber ? "active" : "", 8265, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 8381, "\"", 8460, 1);
#nullable restore
#line 116 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 8388, Url.Action("List", "Product", new { Alias = category.Alias, page = i }), 8388, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 116 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 118 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 120 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                             if (Model.HasNextPage)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 8834, "\"", 8932, 1);
#nullable restore
#line 123 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 8841, Url.Action("List", "Product", new { Alias = category.Alias, page = Model.PageNumber + 1 }), 8841, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"Next\">\r\n                                                        <span aria-hidden=\"true\">&raquo;</span>\r\n                                                    </a>\r\n                                                </li>\r\n");
#nullable restore
#line 127 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </ul>
                                    </div>


                                </div>
                            </div>

                            <div class=""col-xs-12 col-sm-4 col-md-4 col-lg-3 pull-left"">
                                <aside id=""tg-sidebar"" class=""tg-sidebar"">
                                    <div class=""tg-widget tg-widgettrending"">
                                        <div class=""tg-widgettitle"">
                                            <h3>Sản phẩm thịnh hành</h3>
                                        </div>
                                        <div class=""tg-widgetcontent"">
                                            <ul>
");
#nullable restore
#line 143 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                 if (Model != null && Model.Count() > 0)
                                                {
                                                    foreach (var item in Model)
                                                    {
                                                        string url = $"/{item.Alias}--{item.ProductId}.html"; 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <li>\r\n                                                            <article class=\"tg-post\">\r\n                                                                <figure><a");
                BeginWriteAttribute("href", " href=\"", 10555, "\"", 10566, 1);
#nullable restore
#line 150 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 10562, url, 10562, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 10572, "\"", 10589, 1);
#nullable restore
#line 150 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 10578, item.Thumb, 10578, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 10590, "\"", 10613, 1);
#nullable restore
#line 150 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 10596, item.ProductName, 10596, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive""></a></figure>
                                                                <div class=""tg-postcontent"">
                                                                    <div class=""tg-posttitle"">
                                                                        <h3><a");
                BeginWriteAttribute("href", " href=\"", 10921, "\"", 10932, 1);
#nullable restore
#line 153 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 10928, url, 10928, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 153 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h3>\r\n                                                                    </div>\r\n                                                                    <span class=\"tg-bookwriter\">Tác giả: <a");
                BeginWriteAttribute("href", " href=\"", 11145, "\"", 11156, 1);
#nullable restore
#line 155 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
WriteAttributeValue("", 11152, url, 11152, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 155 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                                                                                   Write(item.AuthorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></span>\r\n                                                                </div>\r\n                                                            </article>\r\n                                                        </li>\r\n");
#nullable restore
#line 159 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                </aside>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
<style>
    .tg-postbook {
        border-radius: 4px;
        overflow: hidden;
        margin: 10px 0;
        background-color: white;
        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
    }

    .tg-featureimg {
        max-width: 100%;
        height: 200px;
    }

    .tg-bookimg {
        width: 100%; 
        height: 200px; 
    }

    .tg-featureimg img {
        width: 100%;
        height: 200px; 
        object-fit: contain;
    }

    .tg-postbookcontent {
        padding: 10px;
    }

    .tg-booktitle h3,
    .tg-bookwriter {
        white-space: nowrap;
        overflow: hidden;
        text-overflow: ellipsis;
    }


    .tg-pagination {
        display: flex;
        justify-content: center;
        margin: 20px 0; 
    }



</style>

<script>
    $(document).ready(function () {
     
        $("".add-to-cart"").on(""click"", function (e) {
            e.preventDefault();  

            var productId = $(this).data(""product-id"");  

     ");
            WriteLiteral(@"       $.ajax({
                url: '/api/cart/add',  
                type: 'POST',
                data: {
                    productID: productId,  
                    amount: 1 
                },
                success: function (response) {
                    if (response.success) {
                    
                        alert(""Sản phẩm đã được thêm vào giỏ hàng!"");
                    } else {
                        alert(""Có lỗi xảy ra khi thêm sản phẩm vào giỏ hàng."");
                    }
                },
                error: function () {
                    alert(""Có lỗi xảy ra. Vui lòng thử lại."");
                }
            });
        });
    });

</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Product\List.cshtml"
            
    public string Truncate(string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value) || value.Length <= maxLength)
        {
            return value; 
        }
        return value.Substring(0, maxLength) + "...";
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<BookLibrary.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
