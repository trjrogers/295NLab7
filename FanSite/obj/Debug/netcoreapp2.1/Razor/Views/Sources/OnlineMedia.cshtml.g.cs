#pragma checksum "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9185ebf616e0b4b54b12a79fb33d8bcfe12eb260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sources_OnlineMedia), @"mvc.1.0.view", @"/Views/Sources/OnlineMedia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sources/OnlineMedia.cshtml", typeof(AspNetCore.Views_Sources_OnlineMedia))]
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
#line 1 "C:\Dev\F19\295N\Lab\FanSite\Views\_ViewImports.cshtml"
using FanSite;

#line default
#line hidden
#line 2 "C:\Dev\F19\295N\Lab\FanSite\Views\_ViewImports.cshtml"
using FanSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9185ebf616e0b4b54b12a79fb33d8bcfe12eb260", @"/Views/Sources/OnlineMedia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a9be94e162a62c38949182d60f507c4aa060fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Sources_OnlineMedia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMediaModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
  
    Layout = "_sources";
    ViewBag.Title = "More sites about the Joker";

#line default
#line hidden
            BeginContext(125, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(150, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8379becf35a043e49b4258d2600cdb84", async() => {
                BeginContext(156, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(229, 13, false);
#line 11 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(242, 10, true);
                WriteLiteral("</title>\r\n");
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
            BeginContext(259, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(261, 717, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d756897191463890385956f8c69c9b", async() => {
                BeginContext(267, 432, true);
                WriteLiteral(@"
    <div id=""mainDiv"">
        <h1>Online Media</h1>
        <ul>
            <li><h1><a href=""/"">Home</a></h1></li>
            <li><h1><a href=""/Sources/Index"">Sources</a></h1></li>
            <li><h1><a href=""/Sources/PhysicalMedia"">Books and print media</a></h1></li>
            <li><h1><a href=""/Sources/OnlineMedia"">Links to online media</a></h1></li>
        </ul>
        <div>
            <p>Online media</p>
");
                EndContext();
#line 24 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
             foreach (OnlineMediaModel o in Model)
            {

#line default
#line hidden
                BeginContext(766, 43, true);
                WriteLiteral("                <div>\r\n                    ");
                EndContext();
                BeginContext(810, 7, false);
#line 27 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
               Write(o.Title);

#line default
#line hidden
                EndContext();
                BeginContext(817, 31, true);
                WriteLiteral(" <br />\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 848, "\"", 862, 1);
#line 28 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
WriteAttributeValue("", 855, o.Link, 855, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(863, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(865, 13, false);
#line 28 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
                                 Write(o.Description);

#line default
#line hidden
                EndContext();
                BeginContext(878, 62, true);
                WriteLiteral("</a><br />\r\n                    <br />\r\n                </div>");
                EndContext();
#line 30 "C:\Dev\F19\295N\Lab\FanSite\Views\Sources\OnlineMedia.cshtml"
                      }

#line default
#line hidden
                BeginContext(943, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
            BeginContext(978, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineMediaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
