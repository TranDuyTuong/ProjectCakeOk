#pragma checksum "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Roles\PageDetailRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc159655952657bcebe62fd37790d9488bdc281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_PageDetailRole), @"mvc.1.0.view", @"/Views/Roles/PageDetailRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc159655952657bcebe62fd37790d9488bdc281", @"/Views/Roles/PageDetailRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e41b834cc73be4ac7e30458e72fc32c507d5d63", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_PageDetailRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PageRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/assets/js/jquery.twbsPagination.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/assets/js/Role/DetailRoleJS.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Roles\PageDetailRole.cshtml"
  
    ViewData["Title"] = "Chi Tiết Quyền";
    Layout = "~/Views/Shared/Page_Home.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"" class=""main"">

    <div class=""pagetitle"">
        <h1>Chi Tiết Quyền</h1>
        <nav>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Trang Chủ</a></li>
                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cc159655952657bcebe62fd37790d9488bdc2815181", async() => {
                WriteLiteral("Danh Sách Quyền");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item active"">Chi Tiết Quyền</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class=""section dashboard"">
        <div class=""row"">

            <!-- Left side columns -->
            <div class=""col-lg-12"">
                <div class=""row"">
                    <div class=""mb-3"">
                        <label class=""form-label"">Tên Quyền</label>
                        <input type=""text"" class=""form-control"" id=""TxtNameRole"" disabled />
                    </div>
                    <div class=""mb-3"">
                        <label class=""form-label"">Ký Hiệu</label>
                        <input type=""text"" class=""form-control"" id=""TxtSymbolRole"" disabled />
                    </div>

                    <div class=""table-responsive"">
                        <p style=""text-align: center; font-family: initial; font-size:17px; font-weight: 600;"">
                            Bảng Danh Sách Các Nhân Viên Thuộc");
            WriteLiteral(@" Quyền
                        </p>
                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th scope=""col"">STT</th>
                                    <th scope=""col"">Tên Nhân Viên</th>
                                    <th scope=""col"">Trạng Thái</th>
                                    <th scope=""col"">Hình Ảnh</th>
                                    <th scope=""col"">Ngày Phân Quyền</th>
                                    <th scope=""col"">Lựa Chọn</th>
                                </tr>
                            </thead>
                            <tbody id=""BodyData"">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div><!-- End Left side columns -->
            <!-- Right side columns -->


        </div><!-- End Right side columns -->
    </section>

    <!--Modal Edit City-->
 ");
            WriteLiteral(@"   <div class=""modal"" tabindex=""-1"" id=""M_EditCity"" style=""background-color: #000000a6;"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Cập Nhật Tỉnh/Tp</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" id=""BtnClose""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""mb-3"">
                        <label for=""exampleInputEmail1"" class=""form-label"">Mã Tỉnh/Tp</label>
                        <input type=""text"" class=""form-control"" id=""TxtEditIDCity"" disabled />
                    </div>
                    <div class=""mb-3"">
                        <label for=""exampleInputEmail1"" class=""form-label"">Tên Tỉnh/Tp</label>
                        <input type=""text"" class=""form-control"" id=""TxtEditCity"" />
                        <div id=""ErrorHelp"" class=""form-text"" style=""co");
            WriteLiteral(@"lor: red;""></div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" id=""Btn_Update""><i class=""fas fa-edit""></i> Thay Đổi</button>
                </div>
            </div>
        </div>
    </div>

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
                            <div class=""spinner-grow tex");
            WriteLiteral(@"t-secondary"" role=""status"">
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

</main><!-- End #main -->
<input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 5103, "\"", 5126, 1);
#nullable restore
#line 114 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Roles\PageDetailRole.cshtml"
WriteAttributeValue("", 5111, ViewBag.IdRole, 5111, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdRole\" />\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cc159655952657bcebe62fd37790d9488bdc28112033", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 116 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Roles\PageDetailRole.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cc159655952657bcebe62fd37790d9488bdc28114041", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 117 "D:\Development_Project\Dev_CareOk\ProjectStock_BackEnd\CakeOk_Web\ProjectCakeOk\ManagerCakeOk\Views\Roles\PageDetailRole.cshtml"
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