#pragma checksum "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "264805dc04336ca689446813511efcfae3e41b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserShopedItems_UserMovieShops), @"mvc.1.0.view", @"/Views/UserShopedItems/UserMovieShops.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264805dc04336ca689446813511efcfae3e41b3f", @"/Views/UserShopedItems/UserMovieShops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149891f1b255974f767d45dfc172fd485e3e44cb", @"/Views/_ViewImports.cshtml")]
    public class Views_UserShopedItems_UserMovieShops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OutputMovies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserShopedItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserBooksShops", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
  
    ViewData["Title"] = "UserShops";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n\r\n        <h1>");
#nullable restore
#line 8 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s shoped products</h1>\r\n\r\n\r\n        <br />\r\n        <p class=\"bookLink\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264805dc04336ca689446813511efcfae3e41b3f5836", async() => {
                WriteLiteral("Book collection");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n\r\n");
#nullable restore
#line 16 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
         if (Model != null)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
             if (Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"table-responsive-sm\">\r\n                    <table class=\"table\" id=\"tabul\">\r\n                        <thead>\r\n                            <tr>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 26 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                               Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </th>
                                <th>
                                    Product
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 35 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n");
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 1351, "\"", 1370, 1);
#nullable restore
#line 40 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 1357, item.Picture, 1357, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 41 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                                         using (Html.BeginForm("MovieDetail", "MovieList", new { id = item.Id }, FormMethod.Get))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <input class=\"form-control mr-sm-2\" type=\"hidden\" name=\"type\"");
            BeginWriteAttribute("value", " value=\"", 1691, "\"", 1710, 1);
#nullable restore
#line 43 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 1699, item.price, 1699, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <button type=\"submit\" class=\"btn btn-warning btn-lg\" id=\"shope-button\">Rate </button>\r\n");
#nullable restore
#line 45 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
            WriteLiteral("                                        <iframe id=\"product-frame\"");
            BeginWriteAttribute("src", " src=\"", 2144, "\"", 2179, 1);
#nullable restore
#line 49 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 2150, item.LinkForPurchasedContend, 2150, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </iframe>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    </div>\r\n");
#nullable restore
#line 58 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"wrapper bg-transparent mt-5\"><h3 class=\"text-center pt-3\">There are no products</h3></div>\r\n");
#nullable restore
#line 62 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                     

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OutputMovies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
