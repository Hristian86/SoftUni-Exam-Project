#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f882f48307248c27fa6417224e2417eb27936a6"
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
#line 1 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using MBshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using MBshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f882f48307248c27fa6417224e2417eb27936a6", @"/Views/UserShopedItems/UserMovieShops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f561337f3c5c860a6e37915e661ede1f9108dc", @"/Views/_ViewImports.cshtml")]
    public class Views_UserShopedItems_UserMovieShops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessLogic.OutputModels.OutputMovies>>
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
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
  
    ViewData["Title"] = "UserShops";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s shoped products</h1>\r\n\r\n\r\n<br />\r\n<p class=\"bookLink\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f882f48307248c27fa6417224e2417eb27936a65060", async() => {
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"tabul\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.RealeaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Product\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.RealeaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 76 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
                      
                        var sum = item.price + item.Discount;
                        string pricy = $"{sum:f2} $";
                        string disp = $"{item.price:f2} $";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    Origin Price: ");
#nullable restore
#line 81 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
                             Write(pricy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p>Promo: -");
#nullable restore
#line 82 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
                          Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                    Final Price: ");
#nullable restore
#line 83 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
                            Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <iframe width=\"420\" height=\"315\"");
            BeginWriteAttribute("src", "\r\n                            src=\"", 2810, "\"", 2874, 1);
#nullable restore
#line 88 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 2845, item.LinkForPurchasedContend, 2845, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </iframe>\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 3047, "\"", 3066, 1);
#nullable restore
#line 93 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 3053, item.Picture, 3053, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserMovieShops.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessLogic.OutputModels.OutputMovies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
