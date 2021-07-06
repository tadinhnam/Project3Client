#pragma checksum "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "389f7890b011cbd3aff931a6bdc5010516e991fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Survey_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Survey/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389f7890b011cbd3aff931a6bdc5010516e991fc", @"/Areas/Admin/Views/Survey/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c1f8bec51aa3a6382909f1df9302c1ff216f83", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Survey_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""form-group"">
                <h6><label for=""Name"">Name</label></h6>
                <input type=""text"" class=""form-control"" id=""questionOld""");
            BeginWriteAttribute("value", " value=\"", 379, "\"", 404, 1);
#nullable restore
#line 12 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
WriteAttributeValue("", 387, ViewBag.sur.Name, 387, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <h6><label for=\"Updated\">Updated</label></h6>\r\n                <input type=\"text\" class=\"form-control\" id=\"Updated\"");
            BeginWriteAttribute("value", " value=\"", 606, "\"", 659, 1);
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
WriteAttributeValue("", 614, ViewBag.sur.Updated.ToString("dd/MM/yyyy"), 614, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <h6><label for=\"object\">Object</label></h6>\r\n                <input type=\"text\" class=\"form-control\" id=\"object\"");
            BeginWriteAttribute("value", " value=\"", 858, "\"", 911, 1);
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
WriteAttributeValue("", 866, ViewBag.sur.Active ? "Teacher" : "Student", 866, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <h6><label for=\"desc\">Description</label></h6>\r\n                <textarea class=\"form-control\" id=\"desc\"  rows=\"4\" disabled>");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
                                                                       Write(ViewBag.sur.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
            </div>
            <h4 class=""card-title"">Answer Table</h4>

            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Question</th>
                    </tr>
                </thead>
                <tbody id=""bodyAnswer"">

");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
                     if (ViewBag.sur.QuestionSurveys != null)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
                         foreach (var item in ViewBag.sur.QuestionSurveys)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
                               Write(item.IdQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
                               Write(item.IdQuestionNavigation.Question1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Survey\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
