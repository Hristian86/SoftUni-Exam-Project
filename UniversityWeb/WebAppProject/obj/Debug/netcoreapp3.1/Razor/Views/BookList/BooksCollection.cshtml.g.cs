#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52f39840898ba88503284a04ee496757dd00eb2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookList_BooksCollection), @"mvc.1.0.view", @"/Views/BookList/BooksCollection.cshtml")]
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
#line 1 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using WebAppProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using WebAppProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f39840898ba88503284a04ee496757dd00eb2b", @"/Views/BookList/BooksCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82fb965db7b01b80b6c0dfaf0185b4a457e1dd7", @"/Views/_ViewImports.cshtml")]
    public class Views_BookList_BooksCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessLogic.OutputModels.Bookses>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovieList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
  
    ViewData["Title"] = "BooksCollection";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BookCollection</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f39840898ba88503284a04ee496757dd00eb2b4581", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f39840898ba88503284a04ee496757dd00eb2b5759", async() => {
                WriteLiteral("Movie collection");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"tabul\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 2047, "\"", 2066, 1);
#nullable restore
#line 72 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
WriteAttributeValue("", 2053, item.Picture, 2053, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 76 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 77 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\Views\BookList\BooksCollection.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessLogic.OutputModels.Bookses>> Html { get; private set; }
    }
}
#pragma warning restore 1591