#pragma checksum "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17ab6cc26f75bab3d8f436db80745f8633a9f46452522b725cec1d6747c0e06e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestArticles__LatestArticles), @"mvc.1.0.view", @"/Views/Shared/Components/LatestArticles/_LatestArticles.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\my project\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\my project\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"17ab6cc26f75bab3d8f436db80745f8633a9f46452522b725cec1d6747c0e06e", @"/Views/Shared/Components/LatestArticles/_LatestArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"beedc743e2dd9606cc09a0c6dca169c83680b94a31a7fb1c3e7232e34f5080f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_LatestArticles__LatestArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"latest-blog-section p-3 p-lg-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"section-title font-weight-bold mb-5\">آخرین مقالات</h2>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 7 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
             foreach (var article in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-5\">\r\n                    <div class=\"card blog-post-card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "17ab6cc26f75bab3d8f436db80745f8633a9f46452522b725cec1d6747c0e06e4351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 420, "~/assets/images/blog/", 420, 21, true);
#nullable restore
#line 11 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
AddHtmlAttributeValue("", 441, article.Image, 441, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
AddHtmlAttributeValue("", 462, article.Title, 462, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
AddHtmlAttributeValue("", 485, article.Description, 485, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">\r\n                                <a class=\"theme-link\" href=\"blog-post.html\">\r\n                                    ");
#nullable restore
#line 15 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
                               Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 19 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
                           Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <p class=""mb-0"">
                                <a class=""more-link"" href=""#"">ادامه مطلب</a>
                            </p>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 27 "D:\my project\DevCard\DevCard_MVC\Views\Shared\Components\LatestArticles\_LatestArticles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
