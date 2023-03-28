#pragma checksum "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Account\DetailAccountGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f7370404e8c8dd16f7d93d2985aaf5dd3b3d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_DetailAccountGet), @"mvc.1.0.view", @"/Views/Account/DetailAccountGet.cshtml")]
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
#line 1 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\_ViewImports.cshtml"
using ManagerCakeOk;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f7370404e8c8dd16f7d93d2985aaf5dd3b3d83", @"/Views/Account/DetailAccountGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e41b834cc73be4ac7e30458e72fc32c507d5d63", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_DetailAccountGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/assets/js/jquery.twbsPagination.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/assets/js/Accounts/DetailAccountJS.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Account\DetailAccountGet.cshtml"
  
    ViewData["Title"] = "Chi Tiết Tài Khoản";
    Layout = "~/Views/Shared/Page_Home.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"" class=""main"">

    <div class=""pagetitle"">
        <h1>Chi Tiết Thông Tin Tài Khoản</h1>
        <nav>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Trang Chủ</a></li>
                <li class=""breadcrumb-item""><a href=""index.html"">Danh Sách Tài Khoản</a></li>
                <li class=""breadcrumb-item active"">Chi Tiết Tài Khoản: <span style=""color: green;"">");
#nullable restore
#line 13 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Account\DetailAccountGet.cshtml"
                                                                                              Write(ViewBag.IdAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class=""section dashboard"">
        <div class=""row"">
            <!-- Left side columns -->
            <div class=""col-lg-12"">
                <div class=""row"">
                    <div class=""mb-3"">
                        <label class=""form-label"">Email</label>
                        <input type=""email"" class=""form-control"" id=""Txt_Email"" disabled />
                    </div>
                    <div class=""mb-3"">
                        <label class=""form-label"">Khách Hàng Hay Nhân Viên</label>
                        <input type=""text"" class=""form-control"" id=""Txt_CustomerOrStaff"" disabled />
                    </div>
                    <div class=""mb-3"">
                        <label class=""form-label"">Ngày Tạo</label>
                        <input type=""text"" class=""form-control"" id=""Txt_DateCreate"" disabled />
                    </div>
                    <div class=""mb-3"">
     ");
            WriteLiteral(@"                   <label class=""form-label"">Giờ Tạo</label>
                        <input type=""text"" class=""form-control"" id=""Txt_TimeCreate"" disabled />
                    </div>
                    <div class=""mb-3"">
                        <label class=""form-label"">Nhân Viên Hay Đầu Bếp</label>
                        <input type=""text"" class=""form-control"" id=""Txt_StaffOrChef"" disabled />
                    </div>
                    <div class=""mb-3"">
                        <p style=""text-align: right;"">Tài Khoản Đã Hoạt Động <b style=""color: green; font-weight:600""></b> ngày</p>
                    </div>
                    <div class=""mb-3"">
                        <input type=""hidden"" class=""form-control"" id=""Txt_IdStaff"" disabled />
                    </div>
                    <hr />
                    <h4><i class=""fas fa-sign-in-alt""></i> Thông Tin Đăng Nhập</h4>

                    <p style=""text-align: right"">
                        Tổng Số Lần Đăng Nhập:
           ");
            WriteLiteral(@"             <b style=""color:red; font-weight:600"">100</b>
                    </p>

                    <p>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <span style=""font-size: 12px; font-weight: 600;"">Bắt Đầu</span>
                                <input type=""date"" class=""form-control"" />
                            </div>
                            <div class=""col-md-4"">
                                <span style=""font-size: 12px; font-weight: 600;"">Kết Thúc</span>
                                <input type=""date"" class=""form-control"" />
                            </div>
                            <div class=""col-md-4"">
                                <span style=""font-size: 12px; font-weight: 600;"">Tìm Kiếm</span><br />
                                <button type=""button"" class=""btn btn-primary""><i class=""fas fa-search-plus""></i></button>
                            </div>
                        </div>");
            WriteLiteral(@"
                    </p>

                    <br />
                    <br />
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Ngày Đăng Nhập</th>
                                <th scope=""col"">Thời Gian Đăng Nhập</th>
                                <th scope=""col"">Ngày Thoát</th>
                                <th scope=""col"">Thời Gian Thoát</th>
                                <th scope=""col"">Tổng Giờ Hoạt Động</th>

                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope=""row"">1</th>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>mdo</td>
                            </tr>
                        </tbody>
                  ");
            WriteLiteral(@"  </table>
                    <p>
                        <button class=""btn btn-primary""><i class=""fas fa-key""></i> Thay Đổi Mật Khẩu</button>
                    </p>
                </div>
            </div><!-- End Left side columns -->

        </div><!-- End Right side columns -->
    </section>

    <!-- Modal loading create Music -->
    <div class=""modal"" tabindex=""-1"" style=""background-color: #000000a6;"" id=""Modal_Loading"">
        <div class=""modal-dialog"">
            <div class=""modal-content"" style=""background:none; border:none;"">
                <div class=""modal-body"">
                    <div class=""row"" style=""margin-top:200px;"">
                        <div class=""col-md-4""></div>
                        <div class=""col-md-4"">
                            <div class=""spinner-grow text-primary"" role=""status"">
                                <span class=""visually-hidden""></span>
                            </div>
                            <div class=""spinner-grow text-s");
            WriteLiteral(@"econdary"" role=""status"">
                                <span class=""visually-hidden""></span>
                            </div>
                            <div class=""spinner-grow text-success"" role=""status"">
                                <span class=""visually-hidden""></span>
                            </div>
                        </div>
                        <div class=""col-md-4""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 6214, "\"", 6240, 1);
#nullable restore
#line 130 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Account\DetailAccountGet.cshtml"
WriteAttributeValue("", 6222, ViewBag.IdAccount, 6222, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdAccount\" />\r\n</main><!-- End #main -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f7370404e8c8dd16f7d93d2985aaf5dd3b3d8311536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 133 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Account\DetailAccountGet.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f7370404e8c8dd16f7d93d2985aaf5dd3b3d8313548", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 134 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Account\DetailAccountGet.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
