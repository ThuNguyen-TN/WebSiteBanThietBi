#pragma checksum "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d25ad9169ae762928099ceaea90182f709c44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoryName), @"mvc.1.0.view", @"/Views/Home/CategoryName.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d25ad9169ae762928099ceaea90182f709c44e", @"/Views/Home/CategoryName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c381ca5c5e27b96ff0706d2527711e7b5d8e408c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoryName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebsiteThietBiDienTu.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary bg-primary text-white mt-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
  
    ViewData["Title"] = "HomePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center\">\r\n");
#nullable restore
#line 9 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col mb-5\">\r\n            <div class=\"card h-100\">\r\n                <!-- Sale badge-->\r\n");
#nullable restore
#line 14 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                 if (item.GiaGoc > item.GiaBan)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge bg-danger text-white position-absolute\" style=\"top: 0.5rem; right: 0.5rem\">GIẢM GIÁ</div>\r\n");
#nullable restore
#line 17 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d25ad9169ae762928099ceaea90182f709c44e6266", async() => {
                WriteLiteral("\r\n                    <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 699, "\"", 735, 2);
                WriteAttributeValue("", 705, "/images/products/", 705, 17, true);
#nullable restore
#line 19 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
WriteAttributeValue("", 722, item.HinhAnh, 722, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"...\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                                                WriteLiteral(item.MaMh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <!-- Product image-->\r\n                <!-- Product details-->\r\n                <div class=\"card-body p-4\">\r\n                    <div class=\"text-center\">\r\n                        <!-- Product name-->\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d25ad9169ae762928099ceaea90182f709c44e9485", async() => {
                WriteLiteral("\r\n                            <h5 class=\"fw-bolder\">");
#nullable restore
#line 28 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                             Write(Html.Raw(@item.Ten));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                                                        WriteLiteral(item.MaMh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <!-- Product reviews-->\r\n                        \r\n                        <!-- Product price-->\r\n");
#nullable restore
#line 33 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                         if (item.GiaBan != item.GiaGoc)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-muted text-decoration-line-through\">");
#nullable restore
#line 36 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                                                             Write(item.GiaGoc.ToString("n0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                            <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 37 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                                           Write(item.GiaBan.ToString("n0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n");
#nullable restore
#line 38 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 41 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                                           Write(item.GiaBan.ToString("n0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n");
#nullable restore
#line 42 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!-- Product actions-->\r\n                <div class=\"card-footer p-4 pt-0 border-top-0 bg-transparent\">\r\n                    <div class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d25ad9169ae762928099ceaea90182f709c44e14841", async() => {
                WriteLiteral("\r\n                            <i class=\"bi-cart-fill me-1\"></i>\r\n                            Chọn Mua\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
                                                                                                                                        WriteLiteral(item.MaMh);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 56 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\CategoryName.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebsiteThietBiDienTu.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
