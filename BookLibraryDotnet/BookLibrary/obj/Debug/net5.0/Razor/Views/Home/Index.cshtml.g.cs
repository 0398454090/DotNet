#pragma checksum "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "585f47693ec60d0b94a96f6a958eb4d23c3c52c799ac37ae83287e57577b15c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"585f47693ec60d0b94a96f6a958eb4d23c3c52c799ac37ae83287e57577b15c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d0dc3c95b8b6db658e44ef9b1991bcbb916f8a2b8e2dbbe78e29acff423a5900", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookLibrary.ModelViews.HomeViewVM>
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
#nullable restore
#line 2 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Thư viện bán sách";
	Layout = "~/Views/Shared/_Layout.cshtml";
	List<Product> allProduct = ViewBag.AllProducts;


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "585f47693ec60d0b94a96f6a958eb4d23c3c52c799ac37ae83287e57577b15c93481", async() => {
                WriteLiteral(@"
	<div id=""tg-wrapper"" class=""tg-parallax tg-haslayout"">
		<!-- Inner Banner Start -->
		<div class=""tg-innerbanner tg-haslayout tg-parallax tg-bginnerbanner""
			 data-z-index=""-20""
			 data-appear-top-offset=""600""
			 data-parallax=""scroll""
			 style=""background-image: url('https://nhadepso.com/wp-content/uploads/2023/03/101-hinh-nen-sach-dep-an-tuong-cho-may-tinh-hoac-dien-thoai_4.jpg');
                background-size: cover;
                background-position: center;
                min-height: 400px;
                display: flex;
                justify-content: center;
                align-items: center;"">

			<div class=""container"">
				<div class=""row"">
					<div class=""col-12"">
						<div class=""tg-innerbannercontent"">
							<h1>Trang chủ</h1>
							<ol class=""tg-breadcrumb"">
								<li class=""tg-active"">Trang chủ</li>
								<li><a href=""/BookList.html"">Cửa hàng</a></li>
								
							</ol>
						</div>
					</div>
				</div>
			</div>
		</div>

		<!-- Main C");
                WriteLiteral(@"ontent Start -->
		<main id=""tg-main"" class=""tg-main tg-haslayout"">
			<div class=""container mt-4"">
				<h4 class=""text-center btn-outline"" style=""margin-bottom: 20px; margin-top: 20px; font-size: 16px; color: #28a745; border: 2px solid #28a745; border-radius: 5px; padding: 10px; background-color: white;"">
					Các thể loại sách
				</h4>

				<!-- Navigation Tabs for Product Categories -->
				<ul class=""nav nav-tabs"" role=""tablist"" style=""display: flex; flex-wrap: wrap; justify-content: center; gap: 0px;"">
");
#nullable restore
#line 48 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
      foreach (var item in Model.Products)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<li class=\"nav-item\" role=\"presentation\" style=\"flex: 1 1\">\r\n\t\t\t\t\t\t\t<a");
                BeginWriteAttribute("id", " id=\"", 1869, "\"", 1898, 2);
                WriteAttributeValue("", 1874, "tab-", 1874, 4, true);
#nullable restore
#line 51 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 1878, item.category.Alias, 1878, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-bs-toggle=\"tab\"");
                BeginWriteAttribute("href", " href=\"", 1920, "\"", 1947, 1);
#nullable restore
#line 51 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 1927, item.category.Alias, 1927, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" role=""tab""
							   class=""nav-link custom-tab""
							   style=""padding: 10px; border-radius: 10px; background-color: #ffffff; border: 1px solid #28a745; color: #28a745; display: flex; align-items: center; justify-content: center; flex-direction: column; height: 100%; transition: background-color 0.3s, transform 0.3s; box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1); min-height: 100px;"">
								<img");
                BeginWriteAttribute("src", " src=\"", 2350, "\"", 2389, 1);
#nullable restore
#line 54 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 2356, Url.Content(item.category.Thumb), 2356, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2390, "\"", 2418, 1);
#nullable restore
#line 54 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 2396, item.category.CatName, 2396, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t style=\"width: 40px; height: 40px; margin-bottom: 8px; border-radius: 50%;\" />\r\n\t\t\t\t\t\t\t\t<span style=\"font-weight: bold; font-size: 14px;\">");
#nullable restore
#line 56 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
                                                     Write(item.category.CatName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 59 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				</ul>


				<!-- Product List Section -->
				<div class=""tg-sectionspace tg-haslayout py-5 bg-light"">
					<div class=""container"">
						<div class=""row justify-content-center"">
							<!-- Product Content -->
							<div class=""col-16"">
								<div id=""tg-content"" class=""tg-content"">
									<div class=""tg-products"">
										<div class=""text-center mb-4"">
											<h4 class=""title-border"">Những cuốn sách hay bạn có thể đọc</h4>
										</div>
										<!-- Render danh sách tất cả sản phẩm -->
										");
#nullable restore
#line 75 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Home\Index.cshtml"
     Write(await Html.PartialAsync("_ListProductPartialView", allProduct));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>


		</main>
		<!-- Main Content End -->
	</div>

	<section class=""tg-parallax tg-bgcollectioncount tg-haslayout""
			 data-z-index=""-100""
			 data-appear-top-offset=""600""
			 data-parallax=""scroll""
			 style=""background-image: url('https://png.pngtree.com/thumb_back/fh260/background/20230424/pngtree-book-and-glasses-next-to-a-cup-of-coffee-image_2558408.jpg');
                background-size: cover;
                background-position: center;
                background-attachment: fixed;
                min-height: 400px;
                display: flex;
                justify-content: center;
                align-items: center;"">



		<div class=""tg-sectionspace tg-collectioncount tg-haslayout"">
			<div class=""container"">
				<div class=""row"">
					<div id=""tg-collectioncounters"" class=""tg-collectioncounters"">
						<div class=""tg-collectioncounter tg-drama"">
							<div class=""tg-collectioncoun");
                WriteLiteral(@"tericon"">
								<i class=""icon-bubble""></i>
							</div>
							<div class=""tg-titlepluscounter"">
								<h2>Explore the Unknown</h2>

							</div>
						</div>
						<div class=""tg-collectioncounter tg-horror"">
							<div class=""tg-collectioncountericon"">
								<i class=""icon-heart-pulse""></i>
							</div>
							<div class=""tg-titlepluscounter"">
								<h2>Expand Your Horizons</h2>

							</div>
						</div>
						<div class=""tg-collectioncounter tg-romance"">
							<div class=""tg-collectioncountericon"">
								<i class=""icon-heart""></i>
							</div>
							<div class=""tg-titlepluscounter"">
								<h2>Knowledge is Power</h2>

							</div>
						</div>
						<div class=""tg-collectioncounter tg-fashion"">
							<div class=""tg-collectioncountericon"">
								<i class=""icon-star""></i>
							</div>
							<div class=""tg-titlepluscounter"">
								<h2>Ignite Your Curiosity</h2>

							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>");
                WriteLiteral(@"

	<style>
		.tg-parallax {
			position: relative;
			overflow: hidden;
			background-attachment: fixed;
		}

		.tg-bgcollectioncount {

			padding: 50px 0; 
		}
		.nav-link {
			overflow: hidden;
			text-align: center;
			transition: background-color 0.3s, transform 0.3s;
			height: 100%;
			display: flex;
			align-items: center;
			justify-content: center;
		}

			.nav-link:hover {
				background-color: #e7f1ff;
				transform: translateY(-3px);
				box-shadow: 0 4px 20px rgba(0, 0, 0, 0.2);
			}

		.nav-item {
			height: 96px;
			min-width: 160px;
		}

		.tg-parallax {
			position: relative;
			overflow: hidden;
		}
	</style>




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
            WriteLiteral("\r\n\r\n\t\t\t\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.ModelViews.HomeViewVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
