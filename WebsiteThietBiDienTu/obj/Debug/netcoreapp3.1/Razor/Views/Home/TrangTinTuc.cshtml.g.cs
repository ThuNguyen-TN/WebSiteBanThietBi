#pragma checksum "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad8aba08c6100f9f0ef637bb23d8adb01e4de0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrangTinTuc), @"mvc.1.0.view", @"/Views/Home/TrangTinTuc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad8aba08c6100f9f0ef637bb23d8adb01e4de0e", @"/Views/Home/TrangTinTuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c381ca5c5e27b96ff0706d2527711e7b5d8e408c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrangTinTuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TinTuc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h3 class=\"text-center\">Tin tức nổi bật</h3>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 5 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
         foreach (var news in (List<Tintuc>)ViewBag.tintuc)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"card mb-3\">\r\n                    <div class=\"d-flex\">\r\n                        <div class=\"col-md-4\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 375, "\"", 407, 2);
            WriteAttributeValue("", 381, "/images/news/", 381, 13, true);
#nullable restore
#line 12 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
WriteAttributeValue("", 394, news.HinhAnh, 394, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" alt=\"...\">\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            <div class=\"card-body justify-content-center\">\r\n                                <h5 class=\"card-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bad8aba08c6100f9f0ef637bb23d8adb01e4de0e4785", async() => {
#nullable restore
#line 16 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
                                                                                                    Write(news.TieuDe);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
                                                                                WriteLiteral(news.MaTin);

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
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">Tom tat tin: ");
#nullable restore
#line 17 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
                                                             Write(news.TomTat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 18 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
                                                Write(news.NgayDang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-2\">\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\TrangTinTuc.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591