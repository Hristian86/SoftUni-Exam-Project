#pragma checksum "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bddd2d6cba3e73eb75b64cd1cb1acd8101e512e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shops_Index), @"mvc.1.0.view", @"/Views/Shops/Index.cshtml")]
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
#line 1 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.WebConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.OutputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.StaticProperyes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models.ViewMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models.ViewBooks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bddd2d6cba3e73eb75b64cd1cb1acd8101e512e", @"/Views/Shops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149891f1b255974f767d45dfc172fd485e3e44cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MBshop.Models.Shops>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
Write(Environment.OSVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"    <div class=""container"">

        <h1>View shops</h1>

        <div class=""table-responsive-sm"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Purchased time
                        </th>
                        <th>
                            ");
#nullable restore
#line 21 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Books));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 24 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 27 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th></th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 33 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 37 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RentedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 40 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Books.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 41 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                 if (item.Books != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                               Write(item.Books.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>-</div>\n");
#nullable restore
#line 48 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n                                ");
#nullable restore
#line 51 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 52 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                 if (item.Movie != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                               Write(item.Movie.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>-</div>\n");
#nullable restore
#line 59 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n                                ");
#nullable restore
#line 62 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                           Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bddd2d6cba3e73eb75b64cd1cb1acd8101e512e10924", async() => {
                WriteLiteral("Delete");
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
#line 65 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 68 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\Shops\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MBshop.Models.Shops>> Html { get; private set; }
    }
}
#pragma warning restore 1591
