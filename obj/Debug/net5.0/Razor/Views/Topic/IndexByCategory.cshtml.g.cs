#pragma checksum "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7610a0272067464d28143a236469a94c0b9147e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_IndexByCategory), @"mvc.1.0.view", @"/Views/Topic/IndexByCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7610a0272067464d28143a236469a94c0b9147e", @"/Views/Topic/IndexByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f14e3609ad9a607a34f3a8d0de6bee00c1cd30b", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_IndexByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Topic>>
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
#line 4 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7610a0272067464d28143a236469a94c0b9147e4087", async() => {
                WriteLiteral("\n    <div style=\"box-shadow:-1em 0 0.4em lightgrey; background-color: white;margin-top: 20%; margin-left: 10%; margin-right: 10%; height: 80%\">\n");
#nullable restore
#line 11 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
         foreach (var p in @Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\" style=\"margin-top: 5%; margin-left: 2%;width: 96%; border: solid lightgrey;\">\n                <div class=\"col-4\">\n                    <center>\n                        <h2>\n");
#nullable restore
#line 17 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
                             using (Html.BeginForm("Index", "Post", new {categoryId = @p.Id}, FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a><button type=\"submit\" style=\"border:none; background:transparent; width: 100%; height: 100% display: block\"><p>");
#nullable restore
#line 19 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
                                                                                                                                             Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></button></a>\n                                <i class=\"icon-user-md\" ></i>\n");
#nullable restore
#line 21 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </h2>                        
                    </center>
                </div>
                <div class=""col-8"">
                    <center>
                        <small>
                           data
                        </small>                        
                    </center> <br><br>
                        content
                </div>
            </div>            
");
#nullable restore
#line 34 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"footer\">\n            <p><center>\n                Page ");
#nullable restore
#line 37 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
                 Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" of ");
#nullable restore
#line 37 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
                                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <pageNav style = \"float: right\">\n                    ");
#nullable restore
#line 39 "/home/marcin/Pulpit/Github/ForumApp/Views/Topic/IndexByCategory.cshtml"
               Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </pageNav>\n            </center> </p>       \n    </div>\n    </div>\n\n    \n\n");
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
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Topic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
