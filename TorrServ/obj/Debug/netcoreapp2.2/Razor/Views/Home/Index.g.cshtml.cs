#pragma checksum "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c215cf9154cb862c3395dc69786285fe16a7dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\_ViewImports.cshtml"
using TorrServ;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\_ViewImports.cshtml"
using TorrServ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c215cf9154cb862c3395dc69786285fe16a7dd5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d676cbe9e16bed9ab7e091a789be73b1a2e3375e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TorrServData.Models.TorrentMovie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/homeindex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(99, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(136, 501, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c215cf9154cb862c3395dc69786285fe16a7dd54035", async() => {
                BeginContext(142, 443, true);
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    ");
                EndContext();
                BeginContext(585, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c215cf9154cb862c3395dc69786285fe16a7dd54872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(626, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(637, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(639, 1380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c215cf9154cb862c3395dc69786285fe16a7dd56926", async() => {
                BeginContext(645, 531, true);
                WriteLiteral(@"

   
    <div class=""container"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Title</th>
                    <th>Genre</th>
                    <th>Country</th>
                    <th>EarOfIssue</th>
                    <th>VideoQuality</th>
                    <th>Size</th>
                    <th>CommIndex</th>
                    <th>Downloads</th>
                    <th>PathDowLoad</th>
                </tr>
            </thead>
            <tbody>

");
                EndContext();
#line 38 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                 foreach (var mov in Model)
                {


#line default
#line hidden
                BeginContext(1242, 69, true);
                WriteLiteral("                    <tr class=\"StrTab\">\r\n                        <td>");
                EndContext();
                BeginContext(1312, 9, false);
#line 42 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.title);

#line default
#line hidden
                EndContext();
                BeginContext(1321, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1357, 9, false);
#line 43 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.genre);

#line default
#line hidden
                EndContext();
                BeginContext(1366, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1402, 11, false);
#line 44 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.country);

#line default
#line hidden
                EndContext();
                BeginContext(1413, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1449, 14, false);
#line 45 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.earOfIssue);

#line default
#line hidden
                EndContext();
                BeginContext(1463, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1499, 16, false);
#line 46 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.videoQuality);

#line default
#line hidden
                EndContext();
                BeginContext(1515, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1551, 8, false);
#line 47 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.size);

#line default
#line hidden
                EndContext();
                BeginContext(1559, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1595, 16, false);
#line 48 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.commentIndex);

#line default
#line hidden
                EndContext();
                BeginContext(1611, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1647, 13, false);
#line 49 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
                       Write(mov.downloads);

#line default
#line hidden
                EndContext();
                BeginContext(1660, 37, true);
                WriteLiteral("</td>\r\n                        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1697, "\"", 1721, 1);
#line 50 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"
WriteAttributeValue("", 1704, mov.pathDownLoad, 1704, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1722, 209, true);
                WriteLiteral(" >Download</a></td>\r\n                    </tr>\r\n                    <script>\r\n                        counter(); //changing the color of a row in a table                       \r\n                    </script>\r\n");
                EndContext();
#line 55 "C:\Users\User\Desktop\RepVS\TorrServ\TorrServ\Views\Home\Index.cshtml"

                }

#line default
#line hidden
                BeginContext(1952, 60, true);
                WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    \r\n");
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
            BeginContext(2019, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TorrServData.Models.TorrentMovie>> Html { get; private set; }
    }
}
#pragma warning restore 1591