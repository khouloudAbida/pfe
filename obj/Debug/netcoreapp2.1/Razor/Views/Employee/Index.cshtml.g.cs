#pragma checksum "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5153da34abefa63c4db9a21336d9e7969f7b0be4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5153da34abefa63c4db9a21336d9e7969f7b0be4", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2165c8d65abd77cd3c444fd0a9d96fe9df05df9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeApplication.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-tbl-Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-tbl-Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-tbl-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 47, true);
            WriteLiteral("\r\n<h4> Registre des employ??s </h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5153da34abefa63c4db9a21336d9e7969f7b0be45831", async() => {
                BeginContext(170, 17, true);
                WriteLiteral("Ajouter Employee ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(191, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(3146, 1081, true);
            WriteLiteral(@"<section class=""content"">
    <div class=""container-fluid"">
        <div class=""block-header"">
            <div class=""row"">
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                    <ul class=""breadcrumb breadcrumb-style "">
                        <li class=""breadcrumb-item"">
                            <h4 class=""page-title"">liste des employ??es </h4>
                        </li>
                  
                        <li class=""breadcrumb-item bcrumb-2"">
                            <a href=""#"" onClick=""return false;"">Employees</a>
                        </li>
                        <li class=""breadcrumb-item active"">liste des employ??es </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""card"">
                    <div class=""header"">
                        <h2>
                            <strong>Tous");
            WriteLiteral(" les employ??es</strong> \r\n                        </h2>\r\n");
            EndContext();
            BeginContext(5424, 1331, true);
            WriteLiteral(@"                    </div>
                    <div class=""body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover js-basic-example contact_list"">
                                <thead>
                                    <tr>
                                        <th class=""center"">Image</th>
                                        <th class=""center"">Cin</th>
                                        <th class=""center""> Nom </th>
                                        <th class=""center""> Prenom </th>
                                        <th class=""center""> Telephone </th>
                                        <th class=""center""> Date De Naissance </th>
                                        <th class=""center""> Sexe </th>
                                        <th class=""center""> Adresse</th>

                                        <th class=""center""> Email </th>
                                        <th class=""cente");
            WriteLiteral(@"r""> Date Embauche </th>
                                        <th class=""center""> Solde Cong??s </th>

                                        <th class=""center""> Action </th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 162 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(6860, 230, true);
            WriteLiteral("                                        <tr class=\"odd gradeX\">\r\n                                            <td class=\"table-img center\">\r\n                                                <img src=\"/assets/images/user/khawkha.jpg\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 7090, "\"", 7096, 0);
            EndWriteAttribute();
            BeginContext(7097, 119, true);
            WriteLiteral(">\r\n                                            </td>\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(7217, 38, false);
#line 168 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Cin));

#line default
#line hidden
            EndContext();
            BeginContext(7255, 72, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(7328, 38, false);
#line 169 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(7366, 72, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(7439, 41, false);
#line 170 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(7480, 71, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\"> ");
            EndContext();
            BeginContext(7552, 44, false);
#line 171 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(7596, 72, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(7669, 48, false);
#line 172 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(7717, 74, true);
            WriteLiteral("</td>\r\n\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(7792, 39, false);
#line 174 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Sexe));

#line default
#line hidden
            EndContext();
            BeginContext(7831, 74, true);
            WriteLiteral(" </td>\r\n\r\n                                            <td class=\"center\"> ");
            EndContext();
            BeginContext(7906, 42, false);
#line 176 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Adresse));

#line default
#line hidden
            EndContext();
            BeginContext(7948, 72, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(8021, 40, false);
#line 177 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(8061, 72, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\">  ");
            EndContext();
            BeginContext(8134, 47, false);
#line 178 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.DateEmbauch??));

#line default
#line hidden
            EndContext();
            BeginContext(8181, 120, true);
            WriteLiteral("</td>\r\n                                            <td class=\"center\">\r\n                                                ");
            EndContext();
            BeginContext(8302, 45, false);
#line 180 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.SoldeCong??));

#line default
#line hidden
            EndContext();
            BeginContext(8347, 166, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"center\">\r\n                                                ");
            EndContext();
            BeginContext(8513, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5153da34abefa63c4db9a21336d9e7969f7b0be415625", async() => {
                BeginContext(8591, 140, true);
                WriteLiteral("\r\n                                                    <i class=\"material-icons\">create</i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 183 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                                       WriteLiteral(item.IdEmployee);

#line default
#line hidden
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
            EndContext();
            BeginContext(8735, 106, true);
            WriteLiteral("\r\n                                                <br />\r\n                                                ");
            EndContext();
            BeginContext(8841, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5153da34abefa63c4db9a21336d9e7969f7b0be418308", async() => {
                BeginContext(8925, 141, true);
                WriteLiteral("\r\n                                                    <i Icons=\"assignment_ind\">Details</i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 187 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                                          WriteLiteral(item.IdEmployee);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9070, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(9120, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5153da34abefa63c4db9a21336d9e7969f7b0be420936", async() => {
                BeginContext(9202, 148, true);
                WriteLiteral("\r\n                                                    <i class=\"material-icons\">delete_forever</i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 190 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"
                                                                         WriteLiteral(item.IdEmployee);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9354, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 195 "D:\App_PFE\EmployeeApplication\Views\Employee\Index.cshtml"

                                    }

#line default
#line hidden
            BeginContext(9495, 42, true);
            WriteLiteral("                                </tbody>\r\n");
            EndContext();
            BeginContext(10546, 180, true);
            WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeApplication.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
