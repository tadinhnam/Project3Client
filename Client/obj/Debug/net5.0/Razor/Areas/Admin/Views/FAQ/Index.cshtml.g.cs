#pragma checksum "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa670109ee3b57ebff7f626b96037f0f6b485c4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_FAQ_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/FAQ/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa670109ee3b57ebff7f626b96037f0f6b485c4a", @"/Areas/Admin/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15729dad4f120ac162070835fcba54b52c541dbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
 if (ViewBag.msg != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>alert(");
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
             Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</script>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">List Account</h4>
            <button class=""btn btn-lg btn-gradient-primary "" data-toggle=""modal"" data-target=""#addFAQModal"">
                + Add F.A.Q
            </button>
            <div class=""table-responsive"">
                <table class=""table table-striped a"" id=""tableFAQ"">
                    <thead>
                        <tr>
                            <th>F.A.Q</th>
                            <th> Answer </th>
                            <th> Action </th>
                        </tr>
                    </thead>
                    <tbody id=""tbodyFAQ"">
");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
                         if (ViewBag.listFaq != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
                             foreach (var faq in ViewBag.listFaq)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td hidden>");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
                                          Write(faq.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
                                   Write(faq.Faq1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-break\">");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
                                                      Write(faq.AnSwer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <button class=""btn btn-gradient-warning btnUpdateFAQ""><i class=""mdi mdi-grease-pencil""></i></button>
                                        <button class=""btn btn-gradient-danger btnDelFAQ""><i class=""mdi mdi-delete-forever""></i></button>
                                    </td>
                                </tr>
");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\FAQ\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<div class=""modal"" id=""addFAQModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Add F.A.Q</h4>

            </div>
            <div class=""modal-body"">
                <div class=""col-lg-12"">
                    <div class=""card-body card-block"">
                        <div class=""row form-group"">
                            <div class=""col col-md-3"">
                                <label for=""inputName"" class="" form-control-label"">F.A.Q</label>
                            </div>

                        </div>
                        <div class=""row form-group"">
                            <div class=""col-12 col-md-12"">
                                <textarea id=""textAfq"" placeholder=""..."" class=""form-control"" required></textarea>
                            </div>
        ");
            WriteLiteral(@"                </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline-success"" id=""next"">Next</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal"" id=""AnswerModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Answer</h4>
            </div>
            <div class=""modal-body"">
                <div class=""col-lg-12"">
                    <div class=""card-body card-block"">
                        <div class=""row form-group"">
                            <div class=""col col-md-3"">
                                <label for=""inputName"" class="" form-control-label"">Answer</label>
                            </div>

                        </div>
                        <div class=""row form-group"">
                            <div clas");
            WriteLiteral(@"s=""col-12 col-md-12"">
                                <textarea id=""answer"" placeholder=""..."" class=""form-control"" required></textarea>
                            </div>
                        </div>
                    </div>
                </div>
                <input hidden id=""faq"" />
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline-primary"" data-dismiss=""modal"" id=""cancle"">Cancle</button>
                    <button type=""button"" class=""btn btn-outline-success"" data-dismiss=""modal"" id=""save"">Save</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal"" id=""updateFAQModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Update F.A.Q</h4>

            </div>
            <div class=""modal-body"">
                <div class=""col-lg-12"">
                    <div class=""card-body car");
            WriteLiteral(@"d-block"">
                        <div class=""row form-group"">
                            <div class=""col col-md-3"">
                                <label for=""inputName"" class="" form-control-label"">F.A.Q</label>
                            </div>

                        </div>
                        <div class=""row form-group"">
                            <div class=""col-12 col-md-12"">
                                <textarea id=""afqUpdate"" placeholder=""..."" class=""form-control"" required></textarea>
                                <input hidden id=""idUpdate"" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline-success"" id=""nextUpdate"">Next</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal"" id=""AnswerUpdate"">
    <div class=""modal-dialog"">
        <div class=");
            WriteLiteral(@"""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Answer</h4>
            </div>
            <div class=""modal-body"">
                <div class=""col-lg-12"">
                    <div class=""card-body card-block"">
                        <div class=""row form-group"">
                            <div class=""col col-md-3"">
                                <label for=""inputName"" class="" form-control-label"">Answer</label>
                            </div>

                        </div>
                        <div class=""row form-group"">
                            <div class=""col-12 col-md-12"">
                                <textarea id=""answerUpdate"" placeholder=""..."" class=""form-control"" required></textarea>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline-primary"" data-d");
            WriteLiteral("ismiss=\"modal\" id=\"cancleUpdate\">Cancle</button>\r\n                    <button type=\"button\" class=\"btn btn-outline-success\" data-dismiss=\"modal\" id=\"update\">Save</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
