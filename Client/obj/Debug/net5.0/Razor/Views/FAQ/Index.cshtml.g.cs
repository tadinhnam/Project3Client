#pragma checksum "C:\Users\Admin\Desktop\Project3Client\Client\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d8d64aa998db66f6be1f8ea9aa9a21b201c6cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Project3Client\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Project3Client\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d8d64aa998db66f6be1f8ea9aa9a21b201c6cb", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Project3Client\Client\Views\FAQ\Index.cshtml"
  
    ViewData["Title"] = "Speakers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""faq"" class=""wow fadeInUp"">
    <div class=""container"">
        <div class=""section-header"">
            <h2>F.A.Q </h2>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-lg-9"">
                <ul id=""faq-list"">
");
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Project3Client\Client\Views\FAQ\Index.cshtml"
                     foreach (var faqs in ViewBag.faq)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <a data-toggle=\"collapse\" class=\"collapsed\" href=\"#faq1\">");
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Project3Client\Client\Views\FAQ\Index.cshtml"
                                                                                Write(faqs.Faq1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-minus-circle\"></i></a>\r\n                            <div id=\"faq1\" class=\"collapse\" data-parent=\"#faq-list\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Project3Client\Client\Views\FAQ\Index.cshtml"
                               Write(faqs.AnSwer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Project3Client\Client\Views\FAQ\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
