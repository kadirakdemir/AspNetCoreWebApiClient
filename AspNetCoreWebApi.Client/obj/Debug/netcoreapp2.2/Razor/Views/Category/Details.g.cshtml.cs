#pragma checksum "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f986efa40a5b23fa31b2975aada4cb5f9c4cc56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Details), @"mvc.1.0.view", @"/Views/Category/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Details.cshtml", typeof(AspNetCore.Views_Category_Details))]
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
#line 1 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\_ViewImports.cshtml"
using AspNetCoreWebApi.Client;

#line default
#line hidden
#line 2 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\_ViewImports.cshtml"
using AspNetCoreWebApi.Client.Models;

#line default
#line hidden
#line 1 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml"
using AspNetCoreWebApi.Client.Components.CategoryComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f986efa40a5b23fa31b2975aada4cb5f9c4cc56", @"/Views/Category/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7811b9b9ad2d081a7ba423cf1dc4bde6eafb665d", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreWebApi.Client.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(155, 39, true);
            WriteLiteral("\r\n\r\n<div class=\"contentBody\">\r\n    <h3>");
            EndContext();
            BeginContext(195, 18, false);
#line 10 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml"
   Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(213, 280, true);
            WriteLiteral(@"</h3>
    <br />
    <br />
    <h4>Kategori Bilgileri</h4>
    <hr />
    <div class=""row col-md 12"">
        <div class=""col-md-6"">
            <div id=""açıklama"">
                <div class=""col-md-8""><h5>Kategori İsmi</h5></div>
                <div class=""col-md-8"">");
            EndContext();
            BeginContext(494, 18, false);
#line 19 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml"
                                 Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(512, 134, true);
            WriteLiteral("</div>\r\n                <br />\r\n                <div class=\"col-md-8\"><h5>Açıklama</h5></div>\r\n                <div class=\"col-md-11\">");
            EndContext();
            BeginContext(647, 17, false);
#line 22 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml"
                                  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(664, 97, true);
            WriteLiteral("</div>\r\n            </div>            \r\n        </div>\r\n        <div class=\" col-md-6\">\r\n        ");
            EndContext();
            BeginContext(762, 67, false);
#line 26 "C:\Users\MK\Documents\GitHub\AspNetCoreWebApiClient\AspNetCoreWebApi.Client\Views\Category\Details.cshtml"
   Write(await Component.InvokeAsync("CategoryProducts", new { id=Model.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(829, 49, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n   \r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreWebApi.Client.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591