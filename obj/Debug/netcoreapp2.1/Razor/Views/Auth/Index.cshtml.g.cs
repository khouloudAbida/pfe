#pragma checksum "D:\App_PFE\EmployeeApplication\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d154a84c7a40f92f0115476a7fcb6e391e3845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Index.cshtml", typeof(AspNetCore.Views_Auth_Index))]
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
#line 1 "D:\App_PFE\EmployeeApplication\Views\_ViewImports.cshtml"
using EmployeeApplication;

#line default
#line hidden
#line 2 "D:\App_PFE\EmployeeApplication\Views\_ViewImports.cshtml"
using EmployeeApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d154a84c7a40f92f0115476a7fcb6e391e3845", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2165c8d65abd77cd3c444fd0a9d96fe9df05df9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeApplication.Models.SignInDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\App_PFE\EmployeeApplication\Views\Auth\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = null;

#line default
#line hidden
            BeginContext(107, 511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d154a84c7a40f92f0115476a7fcb6e391e38455541", async() => {
                BeginContext(113, 498, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta content=""width=device-width, initial-scale=1"" name=""viewport"" />
    <title>lOGIN</title>
    <!-- Favicon-->
    <link rel=""icon"" href=""../../assets/images/favicon.ico"" type=""image/x-icon"">
    <!-- Plugins Core Css -->
    <link href=""../../assets/css/app.min.css"" rel=""stylesheet"">
    <!-- Custom Css -->
    <link href=""../../assets/css/style.css"" rel=""stylesheet"" />
    <link href=""../../assets/css/pages/extra_pages.css"" rel=""stylesheet"" />
");
                EndContext();
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
            EndContext();
            BeginContext(618, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(620, 2964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d154a84c7a40f92f0115476a7fcb6e391e38457244", async() => {
                BeginContext(626, 128, true);
                WriteLiteral("\r\n    <div class=\"limiter\">\r\n        <div class=\"container-login100\">\r\n            <div class=\"wrap-login100\">\r\n                ");
                EndContext();
                BeginContext(754, 2456, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d154a84c7a40f92f0115476a7fcb6e391e38457767", async() => {
                    BeginContext(815, 214, true);
                    WriteLiteral("\r\n                    <span class=\"login100-form-title p-b-45\">\r\n                        Login\r\n                    </span>\r\n                    <div class=\"wrap-input100 validate-input\" >\r\n                        ");
                    EndContext();
                    BeginContext(1029, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4d154a84c7a40f92f0115476a7fcb6e391e38458395", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "D:\App_PFE\EmployeeApplication\Views\Auth\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Identify);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1086, 247, true);
                    WriteLiteral("\r\n                        <span class=\"focus-input100\"></span>\r\n                        <span class=\"label-input100\">Email</span>\r\n                    </div>\r\n                    <div class=\"wrap-input100 validate-input\">\r\n                        ");
                    EndContext();
                    BeginContext(1333, 60, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4d154a84c7a40f92f0115476a7fcb6e391e384510624", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "D:\App_PFE\EmployeeApplication\Views\Auth\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1393, 419, true);
                    WriteLiteral(@"
                        <span class=""focus-input100""></span>
                        <span class=""label-input100"">Password</span>
                    </div>
                    <div class=""flex-sb-m w-full p-t-15 p-b-20"">
                        <div class=""form-check"">
                            <label class=""form-check-label"">
                                <input class=""form-check-input"" type=""checkbox""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1812, "\"", 1820, 0);
                    EndWriteAttribute();
                    BeginContext(1821, 1382, true);
                    WriteLiteral(@"> Remember me
                                <span class=""form-check-sign"">
                                    <span class=""check""></span>
                                </span>
                            </label>
                        </div>
                        <div>
                            <a href=""#"" class=""txt1"">
                                Forgot Password?
                            </a>
                        </div>
                    </div>
                    <div class=""container-login100-form-btn"">
                        <input type=""submit"" class=""login100-form-btn"" value=""Login"" />
                            
                    </div>
                    <div class=""text-center p-t-45 p-b-20"">
                        <span class=""txt2"">
                            or sign up using
                        </span>
                    </div>
                    <div class=""login100-form-social flex-c-m"">
                        <a href=""#"" class=""login100");
                    WriteLiteral(@"-form-social-item flex-c-m bg1 m-r-5"">
                            <i class=""fab fa-facebook-f""></i>
                        </a>
                        <a href=""#"" class=""login100-form-social-item flex-c-m bg2 m-r-5"">
                            <i class=""fab fa-twitter""></i>
                        </a>
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3210, 367, true);
                WriteLiteral(@"
                <div class=""login100-more"" style=""background-image: url('../../assets/images/pages/bg-01.png');"">
                </div>
            </div>
        </div>
    </div>
    <!-- Plugins Js -->
    <script src=""../../assets/js/app.min.js""></script>
    <!-- Extra page Js -->
    <script src=""../../assets/js/pages/examples/pages.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(3584, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3608, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 83 "D:\App_PFE\EmployeeApplication\Views\Auth\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(3681, 250, true);
            WriteLiteral("<script src=\"../../assets/js/app.min.js\"></script>\r\n<script src=\"../../assets/js/table.min.js\"></script>\r\n<!-- Custom Js -->\r\n<script src=\"../../assets/js/admin.js\"></script>\r\n<script src=\"../../assets/js/pages/tables/jquery-datatable.js\"></script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeApplication.Models.SignInDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
