#pragma checksum "D:\LapTrinhMVC\BookLibrary\BookLibrary\Views\Checkout\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a7", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d0dc3c95b8b6db658e44ef9b1991bcbb916f8a2b8e2dbbe78e29acff423a5900", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a74454", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Thanh Toán</title>\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a75705", async() => {
                WriteLiteral("\r\n    <div class=\"container mt-5\">\r\n        <h2 class=\"text-center mb-4 \">Thanh Toán</h2>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a76092", async() => {
                    WriteLiteral(@"
            <!-- Thông Tin Người Dùng -->
            <fieldset class=""border p-3 mb-4"">
                <legend class=""w-auto px-3"">Thông Tin Người Nhận</legend>
                <div class=""mb-3"">
                    <label for=""FullName"" class=""form-label"">Họ và Tên</label>
                    <input type=""text"" class=""form-control"" id=""FullName"" name=""FullName"" placeholder=""Nhập họ và tên"" required>
                </div>
                <div class=""mb-3"">
                    <label for=""Email"" class=""form-label"">Email</label>
                    <input type=""email"" class=""form-control"" id=""Email"" name=""Email"" placeholder=""Nhập email"">
                </div>
                <div class=""mb-3"">
                    <label for=""Phone"" class=""form-label"">Số Điện Thoại</label>
                    <input type=""text"" class=""form-control"" id=""Phone"" name=""Phone"" placeholder=""Nhập số điện thoại"" required>
                </div>
                <div class=""mb-3"">
                    <label for=""Addr");
                    WriteLiteral(@"ess"" class=""form-label"">Địa Chỉ</label>
                    <input type=""text"" class=""form-control"" id=""Address"" name=""Address"" placeholder=""Nhập địa chỉ"" required>
                </div>
            </fieldset>

            <!-- Thông Tin Giao Hàng -->
            <fieldset class=""border p-3 mb-4"">
                <legend class=""w-auto px-3"">Thông Tin Giao Hàng</legend>
                <div class=""mb-3"">
                    <label for=""TinhThanh"" class=""form-label"">Tỉnh/Thành</label>
                    <select class=""form-select"" id=""TinhThanh"" name=""TinhThanh"" required>
                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a78142", async() => {
                        WriteLiteral("Chọn Tỉnh/Thành");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    </select>
                </div>
                <div class=""mb-3"">
                    <label for=""QuanHuyen"" class=""form-label"">Quận/Huyện</label>
                    <select class=""form-select"" id=""QuanHuyen"" name=""QuanHuyen"" required>
                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a79761", async() => {
                        WriteLiteral("Chọn Quận/Huyện");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    </select>
                </div>
                <div class=""mb-3"">
                    <label for=""PhuongXa"" class=""form-label"">Phường/Xã</label>
                    <select class=""form-select"" id=""PhuongXa"" name=""PhuongXa"" required>
                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa8a652bc2477b88bd445eb2f4cc6780200d99ad8d756d1d08ad3c9ba31c1a711376", async() => {
                        WriteLiteral("Chọn Phường/Xã");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    </select>
                </div>
            </fieldset>

            <!-- Phương Thức Thanh Toán -->
            <fieldset class=""border p-3 mb-4"">
                <legend class=""w-auto px-3"">Phương Thức Thanh Toán</legend>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""paymentMethod"" id=""cod"" value=""COD"" checked>
                    <label class=""form-check-label"" for=""cod"">Thanh toán khi nhận hàng (COD)</label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""paymentMethod"" id=""bankTransfer"" value=""BankTransfer"">
                    <label class=""form-check-label"" for=""bankTransfer"">Chuyển khoản ngân hàng</label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""paymentMethod"" id=""creditCard"" value=""CreditCard"">
                    <lab");
                    WriteLiteral(@"el class=""form-check-label"" for=""creditCard"">Thẻ tín dụng</label>
                </div>
            </fieldset>

            <!-- Ghi Chú -->
            <div class=""mb-3"">
                <label for=""Note"" class=""form-label"">Ghi Chú</label>
                <textarea class=""form-control"" id=""Note"" name=""Note"" rows=""3"" placeholder=""Nhập ghi chú""></textarea>
            </div>

            <!-- Nút Thanh Toán -->
            <button type=""button"" class=""btn btn-primary w-100"" id=""submitButton"">Thanh Toán</button>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

    <!-- Bootstrap JS -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js""></script>
    <script>
        // Xử lý sự kiện khi nhấn nút Thanh Toán
        document.getElementById(""submitButton"").addEventListener(""click"", function () {
            const form = document.getElementById(""checkoutForm"");
            const formData = new FormData(form);

            // Xuất thông tin ra một cửa sổ mới
            const content = `
                        <h3>Thông Tin Thanh Toán</h3>
                        <p><strong>Họ và Tên:</strong> ${formData.get(""FullName"")}</p>
                        <p><strong>Email:</strong> ${formData.get(""Email"")}</p>
                        <p><strong>Số Điện Thoại:</strong> ${formData.get(""Phone"")}</p>
                        <p><strong>Địa Chỉ:</strong> ${formData.get(""Address"")}</p>
                        <p><strong>Tỉnh/Thành:</strong> ${formData.get(""TinhThanh"")}</p>
                        <p><strong>");
                WriteLiteral(@"Quận/Huyện:</strong> ${formData.get(""QuanHuyen"")}</p>
                        <p><strong>Phường/Xã:</strong> ${formData.get(""PhuongXa"")}</p>
                        <p><strong>Phương Thức Thanh Toán:</strong> ${formData.get(""paymentMethod"")}</p>
                        <p><strong>Ghi Chú:</strong> ${formData.get(""Note"")}</p>
                    `;

            const newWindow = window.open("""", ""_blank"");
            newWindow.document.write(content);
            newWindow.document.close();
            newWindow.print();
        });

        // Tải danh sách tỉnh/thành và các cấp liên quan
        document.addEventListener(""DOMContentLoaded"", function () {
            const tinhThanhSelect = document.getElementById(""TinhThanh"");
            const quanHuyenSelect = document.getElementById(""QuanHuyen"");
            const phuongXaSelect = document.getElementById(""PhuongXa"");

            // Lấy danh sách tỉnh/thành
            fetch(""https://provinces.open-api.vn/api/"")
                .then(r");
                WriteLiteral(@"esponse => response.json())
                .then(data => {
                    data.forEach(tinh => {
                        let option = document.createElement(""option"");
                        option.value = tinh.code;
                        option.text = tinh.name;
                        tinhThanhSelect.add(option);
                    });
                });

            // Khi chọn tỉnh/thành, tải danh sách quận/huyện
            tinhThanhSelect.addEventListener(""change"", function () {
                const tinhCode = this.value;
                quanHuyenSelect.innerHTML = ""<option value=''>Chọn Quận/Huyện</option>"";
                phuongXaSelect.innerHTML = ""<option value=''>Chọn Phường/Xã</option>"";
                if (tinhCode) {
                    fetch(`https://provinces.open-api.vn/api/p/${tinhCode}?depth=2`)
                        .then(response => response.json())
                        .then(data => {
                            data.districts.forEach(huyen => {
    ");
                WriteLiteral(@"                            let option = document.createElement(""option"");
                                option.value = huyen.code;
                                option.text = huyen.name;
                                quanHuyenSelect.add(option);
                            });
                        });
                }
            });

            // Khi chọn quận/huyện, tải danh sách phường/xã
            quanHuyenSelect.addEventListener(""change"", function () {
                const huyenCode = this.value;
                phuongXaSelect.innerHTML = ""<option value=''>Chọn Phường/Xã</option>"";
                if (huyenCode) {
                    fetch(`https://provinces.open-api.vn/api/d/${huyenCode}?depth=2`)
                        .then(response => response.json())
                        .then(data => {
                            data.wards.forEach(xa => {
                                let option = document.createElement(""option"");
                                option.valu");
                WriteLiteral(@"e = xa.code;
                                option.text = xa.name;
                                phuongXaSelect.add(option);
                            });
                        });
                }
            });
        });
    </script>
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
