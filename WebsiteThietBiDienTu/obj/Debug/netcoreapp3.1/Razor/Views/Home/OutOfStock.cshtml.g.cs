#pragma checksum "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcaca1bc759691f3af3a28e4d3d6919f57bcb408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OutOfStock), @"mvc.1.0.view", @"/Views/Home/OutOfStock.cshtml")]
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
#line 1 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\_ViewImports.cshtml"
using WebsiteThietBiDienTu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\_ViewImports.cshtml"
using WebsiteThietBiDienTu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcaca1bc759691f3af3a28e4d3d6919f57bcb408", @"/Views/Home/OutOfStock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c381ca5c5e27b96ff0706d2527711e7b5d8e408c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OutOfStock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteThietBiDienTu.Models.Sanpham>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container px-4 px-lg-5 my-5\">\r\n    <div class=\"row gx-4 gx-lg-5 align-items-center\">\r\n        <div class=\"col-md-4\">\r\n            <img class=\"card-img-top mb-5 mb-md-0 img-thumbnail\" height=\"150px\"");
            BeginWriteAttribute("src", " src=\"", 258, "\"", 295, 2);
            WriteAttributeValue("", 264, "/images/products/", 264, 17, true);
#nullable restore
#line 7 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
WriteAttributeValue("", 281, Model.HinhAnh, 281, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" />\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"small mb-1 fw-bold fs-2\">Danh mục sản phẩm: ");
#nullable restore
#line 10 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                                                               Write(Model.MaDmNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <h1 class=\"display-5 fw-bolder\">");
#nullable restore
#line 11 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                                       Write(Html.Raw(@Model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"fs-5 mb-2\">\r\n");
#nullable restore
#line 13 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                 if (Model.GiaBan != Model.GiaGoc)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-muted text-decoration-line-through\">");
#nullable restore
#line 16 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                                                                     Write(Model.GiaGoc.ToString("n0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n                    <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 17 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                                                   Write(Model.GiaBan.ToString("n0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n");
#nullable restore
#line 18 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-danger fw-bolder\">Giá: ");
#nullable restore
#line 21 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                                                        Write(Model.GiaBan.ToString("n0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n");
#nullable restore
#line 22 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"text-danger fw-bold\">HẾT HÀNG</div>\r\n            <p class=\"lead\">");
#nullable restore
#line 25 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\OutOfStock.cshtml"
                       Write(Html.Raw(Model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div class=""d-flex"">

                <div class=""text-center"">
                    <a class=""btn btn-outline-primary bg-primary text-white mt-auto"">
                        <i class=""bi-cart-fill me-1""></i>
                        Chọn Mua
                    </a>
                </div>

            </div>
        </div>
        <div class=""col-md-2""></div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteThietBiDienTu.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591
