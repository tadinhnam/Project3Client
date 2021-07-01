#pragma checksum "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241ff5190794fb3cad2d095ceae77f1135d399ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Question_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Question/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241ff5190794fb3cad2d095ceae77f1135d399ba", @"/Areas/Admin/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15729dad4f120ac162070835fcba54b52c541dbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Question Table</h4>

            <table class=""table"" id=""tableQuestion"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Quesntion</th>
                        <th>Updated</th>
                        <th>Status</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody id=""bodyQuestion"">
");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                     if (ViewBag.listQuestion != null)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                         foreach (var item in ViewBag.listQuestion)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                               Write(item.Question1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                               Write(item.Updated.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                                 if (item.Status)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><label class=\"badge badge-success\">enable</label></td>\r\n");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><label class=\"badge badge-danger\">disnable</label></td>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <td>
                                    <button class=""btn btn-gradient-danger delQuestion"" type=""button""><i class=""mdi mdi-delete""></i></button>
                                
                                    <button class=""btn btn-gradient-warning"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1807, "\"", 1856, 2);
            WriteAttributeValue("", 1814, "/admin/question/detailQues?idQues=", 1814, 34, true);
#nullable restore
#line 42 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
WriteAttributeValue("", 1848, item.Id, 1848, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
                                        </a>
                                    </button>
                                </td>
                            </tr>
");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Question\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n    \r\n");
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
