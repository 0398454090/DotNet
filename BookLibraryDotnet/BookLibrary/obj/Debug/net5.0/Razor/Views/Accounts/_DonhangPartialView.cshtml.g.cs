#pragma checksum "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "69a9afc9de324d931e1b86aea8a1ffeb0b9ea785ec8dca39c848930f6429edbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts__DonhangPartialView), @"mvc.1.0.view", @"/Views/Accounts/_DonhangPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"69a9afc9de324d931e1b86aea8a1ffeb0b9ea785ec8dca39c848930f6429edbd", @"/Views/Accounts/_DonhangPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d0dc3c95b8b6db658e44ef9b1991bcbb916f8a2b8e2dbbe78e29acff423a5900", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts__DonhangPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
 if(Model!=null && Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered table-hover"">
            <tbody>
                <tr>
                    <th>ID</th>
                    <th>Ngày mua hàng</th>
                    <th>Ngày ship hàng</th>
                    <th>Trạng thái</th>
                    <th>Tổng tiền<  /th>
                </tr>
");
#nullable restore
#line 15 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a href=\"#\">#");
#nullable restore
#line 17 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                                    Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 18 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 19 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 20 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.TransactStatus.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 871, "\"", 878, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary btn-primary-hover\"><span>Xem đơn hàng</span></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 32 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Chưa có đơn hàng</p>\r\n");
#nullable restore
#line 36 "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Accounts\_DonhangPartialView.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
