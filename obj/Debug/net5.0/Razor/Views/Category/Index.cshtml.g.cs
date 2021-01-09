#pragma checksum "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b2b30d1f9d5b52fe2554eaa2d8c3446f8344d91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "/home/marcin/Pulpit/Github/ForumApp/Views/_ViewImports.cshtml"
using ForumApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/marcin/Pulpit/Github/ForumApp/Views/_ViewImports.cshtml"
using ForumApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/marcin/Pulpit/Github/ForumApp/Views/_ViewImports.cshtml"
using ForumApp.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/marcin/Pulpit/Github/ForumApp/Views/_ViewImports.cshtml"
using ForumApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/marcin/Pulpit/Github/ForumApp/Views/_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2b30d1f9d5b52fe2554eaa2d8c3446f8344d91", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f14e3609ad9a607a34f3a8d0de6bee00c1cd30b", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b2b30d1f9d5b52fe2554eaa2d8c3446f8344d914035", async() => {
                WriteLiteral("\n    <div style=\"box-shadow:-1em 0 0.4em lightgrey; background-color: white;margin-top: 20%; margin-left: 10%; margin-right: 10%; height: 80%\">\n");
#nullable restore
#line 10 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
         foreach (var p in @Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\" style=\"margin-top: 5%; margin-left: 2%;width: 96%; border: solid lightgrey;\">\n                <div class=\"col-3\">\n                    <center>\n                        <h2>\n");
#nullable restore
#line 16 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                             using (Html.BeginForm("IndexByCategory", "Topic", new {categoryId = @p.Id}, FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a><button type=\"submit\" style=\"border:none; background:transparent; width: 100%; height: 100% display: block\"><p>");
#nullable restore
#line 18 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                                                                                                                                             Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></button></a>\n                                <i class=\"icon-user-md\" ></i>\n");
#nullable restore
#line 20 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </h2>   \n                        Forum główne a tematyką prowadzącą jest mx-5.                     \n                    </center>\n                </div>\n                <div class=\"col-9\">\n");
#nullable restore
#line 26 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                     if (@p.Posts.Count() != 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>                            \n                            <p style=\"position: relative; float: right;\">\n                                Ostatni wpis\n                                ");
#nullable restore
#line 31 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                           Write(p.Posts.Last().Author.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>\n");
                WriteLiteral("                                ");
#nullable restore
#line 33 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                           Write(p.Posts.Last().Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                            </p>\n                            <p style=\"position: relative; float: right; margin-right: 10%\">\n                                ilosc wpisów:\n                                ");
#nullable restore
#line 38 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                           Write(p.Posts.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </p>\n                        </div>\n");
#nullable restore
#line 41 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \n                </div>\n            </div>            \n");
#nullable restore
#line 46 "/home/marcin/Pulpit/Github/ForumApp/Views/Category/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        \n    </div>\n\n    \n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591