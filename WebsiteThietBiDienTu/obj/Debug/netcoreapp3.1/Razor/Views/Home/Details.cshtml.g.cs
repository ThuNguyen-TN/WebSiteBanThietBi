#pragma checksum "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "168a50b41ba71e5551c52119ac396c9ee98d7087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168a50b41ba71e5551c52119ac396c9ee98d7087", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c381ca5c5e27b96ff0706d2527711e7b5d8e408c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteThietBiDienTu.Models.Sanpham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OutOfStock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info mt-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
 if (Model.SoLuong > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-3\">\r\n\r\n\r\n                <!-- End Product slider -->\r\n            </div>\r\n            <div class=\"col-3\">\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 335, "\"", 398, 2);
            WriteAttributeValue("", 341, "/images/products/", 341, 17, true);
#nullable restore
#line 19 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
WriteAttributeValue("", 358, Html.DisplayFor(model => model.HinhAnh), 358, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <div class=\"quickview-content\">\r\n                    <h2>");
#nullable restore
#line 23 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                    <div>Luot mua: ");
#nullable restore
#line 25 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                              Write(Html.DisplayFor(model => model.LuotMua));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>Luot xem: ");
#nullable restore
#line 26 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                              Write(Html.DisplayFor(model => model.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>Số lượng còn lại: ");
#nullable restore
#line 27 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                    <div class=\"quickview-stock\">\r\n                        <span><i class=\"fa fa-check-circle-o\"></i> in stock</span>\r\n                    </div>\r\n                    <h3>");
#nullable restore
#line 32 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                   Write(Html.DisplayFor(model => model.GiaBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"quickview-peragraph\">\r\n                        <p>");
#nullable restore
#line 34 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                      Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"add-to-cart\">\r\n                        <a href=\"#\" class=\"btn\">Add to cart</a>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 46 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "168a50b41ba71e5551c52119ac396c9ee98d70878765", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3 class=""text-center"">SAN PHAM CO LIEN QUAN</h3>
<div class=""row"">
    <div class=""col-12"">
        <div class=""product-info"">
            <div class=""tab-content"" id=""myTabContent"">
                <!-- Start Single Tab -->
                <div class=""tab-pane fade show active"" id=""man"" role=""tabpanel"">
                    <div class=""tab-single"">

                        <div class=""row"">
");
#nullable restore
#line 61 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                             foreach (var item in ViewBag.sanphamcolienquan)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-xl-3 col-lg-4 col-md-4 col-12"">

                                    <div class=""single-product"">
                                        <div class=""product-img"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "168a50b41ba71e5551c52119ac396c9ee98d708711311", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                 if (item.GiaBan != item.GiaGoc)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <span class=\"price-dec\">Giam gia</span>\r\n");
#nullable restore
#line 71 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"

                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 2713, "\"", 2749, 2);
                WriteAttributeValue("", 2719, "/images/products/", 2719, 17, true);
#nullable restore
#line 73 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
WriteAttributeValue("", 2736, item.HinhAnh, 2736, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"#\">\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
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
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"product-content\">\r\n                                            <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "168a50b41ba71e5551c52119ac396c9ee98d708715229", async() => {
#nullable restore
#line 77 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                                                                                   Write(item.Ten);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
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
            WriteLiteral("</h3>\r\n                                            <div class=\"product-price\">\r\n\r\n");
#nullable restore
#line 80 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                 if (item.GiaBan != item.GiaGoc)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"text-muted text-decoration-line-through\">");
#nullable restore
#line 83 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                                                                     Write(item.GiaGoc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n                                                    <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 84 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                                                   Write(item.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n");
#nullable restore
#line 85 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>Gia: </span>\r\n                                                    <span class=\"text-danger fw-bolder\">");
#nullable restore
#line 89 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                                                   Write(item.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n");
#nullable restore
#line 90 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </div>
                                        </div>
                                        <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                                            <div class=""text-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "168a50b41ba71e5551c52119ac396c9ee98d708720632", async() => {
                WriteLiteral("Chọn mua");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
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
            WriteLiteral("</div>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 101 "D:\CV_ThucTap\ThietBiDienThu\WebsiteThietBiDienTu\WebsiteThietBiDienTu\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n                <!--/ End Single Tab -->\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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