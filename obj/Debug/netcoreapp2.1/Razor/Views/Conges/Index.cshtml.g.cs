#pragma checksum "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25a248eff121279fd9562173be6b099f31818584"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conges_Index), @"mvc.1.0.view", @"/Views/Conges/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conges/Index.cshtml", typeof(AspNetCore.Views_Conges_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a248eff121279fd9562173be6b099f31818584", @"/Views/Conges/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2165c8d65abd77cd3c444fd0a9d96fe9df05df9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Conges_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeApplication.Models.Conge>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-tbl-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-tbl-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 3408, true);
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""block-header"">
            <div class=""row"">
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                    <ul class=""breadcrumb breadcrumb-style "">
                        <li class=""breadcrumb-item"">
                            <h4 class=""page-title"">All Leave Request</h4>
                        </li>
                        <li class=""breadcrumb-item bcrumb-1"">
                            <a href=""../../index.html"">
                                <i class=""fas fa-home""></i> Home
                            </a>
                        </li>
                        <li class=""breadcrumb-item bcrumb-2"">
                            <a href=""#"" onClick=""return false;"">Leave</a>
                        </li>
                        <li class=""breadcrumb-item active"">All Leave Request</li>
                    </ul>
                </div>
            </div>
        </div>
        <");
            WriteLiteral(@"div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""card"">
                    <div class=""header"">
                        <h2>
                            <strong>All</strong> Leave Request
                        </h2>
                        <ul class=""header-dropdown m-r--5"">
                            <li class=""dropdown"">
                                <a href=""#"" onClick=""return false;"" class=""dropdown-toggle""
                                   data-bs-toggle=""dropdown"" role=""button"" aria-haspopup=""true""
                                   aria-expanded=""false"">
                                    <i class=""material-icons"">more_vert</i>
                                </a>
                                <ul class=""dropdown-menu float-end"">
                                    <li>
                                        <a href=""#"" onClick=""return false;"">Action</a>
                                    </li>
                           ");
            WriteLiteral(@"         <li>
                                        <a href=""#"" onClick=""return false;"">Another action</a>
                                    </li>
                                    <li>
                                        <a href=""#"" onClick=""return false;"">Something else here</a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <div class=""body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover js-basic-example contact_list"">
                                <thead>
                                    <tr>
                                       
                                        <th class=""center""> Date Début </th>
                                        <th class=""center""> Date Fin  </th>
                                        <th class=""center""> Notes </th>
          ");
            WriteLiteral(@"                              <th class=""center""> Type </th>
                                        <th class=""center""> Status </th>
                                        <th class=""center""> Action </th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 72 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                     foreach(Conge c in Model)
                                    {

#line default
#line hidden
            BeginContext(3606, 163, true);
            WriteLiteral("<tr class=\"odd gradeX\">\r\n                                   \r\n                                        \r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3770, 4, false);
#line 76 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                                      Write(c.DU);

#line default
#line hidden
            EndContext();
            BeginContext(3774, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3841, 4, false);
#line 77 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                                      Write(c.AU);

#line default
#line hidden
            EndContext();
            BeginContext(3845, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3912, 7, false);
#line 78 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                                      Write(c.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(3919, 66, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">");
            EndContext();
            BeginContext(3986, 16, false);
#line 79 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                                      Write(c.TypeConge.Type);

#line default
#line hidden
            EndContext();
            BeginContext(4002, 68, true);
            WriteLiteral("</td>\r\n                                        <td class=\"center\">\r\n");
            EndContext();
#line 81 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                             if (c.status == -1)
                                            {

#line default
#line hidden
            BeginContext(4181, 47, true);
            WriteLiteral("<div class=\"badge alert-warning\">Attend</div>\r\n");
            EndContext();
#line 83 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                            }

#line default
#line hidden
#line 84 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                             if (c.status == 0)
                                            {

#line default
#line hidden
            BeginContext(4385, 46, true);
            WriteLiteral("<div class=\"badge alert-danger\">Réfusé</div>\r\n");
            EndContext();
#line 86 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                            }

#line default
#line hidden
#line 87 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                             if (c.status == 1)
                                            {

#line default
#line hidden
            BeginContext(4588, 49, true);
            WriteLiteral("<div class=\"badge alert-success\">Accepter</div>\r\n");
            EndContext();
#line 89 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4684, 108, true);
            WriteLiteral("                                        </td>\r\n                                        <td class=\"center\">\r\n");
            EndContext();
#line 92 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                             if (c.status == -1)
                                            {

#line default
#line hidden
            BeginContext(4903, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(4905, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a248eff121279fd9562173be6b099f3181858412593", async() => {
                BeginContext(4972, 140, true);
                WriteLiteral("\r\n                                                    <i class=\"material-icons\">create</i>\r\n                                                ");
                EndContext();
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
#line 93 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                                                      WriteLiteral(c.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5116, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(5162, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a248eff121279fd9562173be6b099f3181858415198", async() => {
                BeginContext(5233, 140, true);
                WriteLiteral("\r\n                                                <i class=\"material-icons\">delete_forever</i>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                                                     WriteLiteral(c.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5377, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5426, 90, true);
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 102 "D:\App_PFE\EmployeeApplication\Views\Conges\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5555, 259, true);
            WriteLiteral(@"                                </tbody>
                               
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeApplication.Models.Conge>> Html { get; private set; }
    }
}
#pragma warning restore 1591