#pragma checksum "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c4825240d8e6f80adf4e046aa3537672990071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_University_Views_Students_AllStudents), @"mvc.1.0.view", @"/Areas/University/Views/Students/AllStudents.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\_ViewImports.cshtml"
using GraduationProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\_ViewImports.cshtml"
using GraduationProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\_ViewImports.cshtml"
using GraduationProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\_ViewImports.cshtml"
using GraduationProject.Areas.University.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c4825240d8e6f80adf4e046aa3537672990071", @"/Areas/University/Views/Students/AllStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf00cff539bb70baeaf5a1e4b5c4c3cceb6cba5", @"/Areas/University/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_University_Views_Students_AllStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllStudentsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-header-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button small green --jb-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("sample-modal-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
  
    ViewData["Title"] = "AllStudents";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"is-hero-bar\">\r\n    <div class=\"flex flex-col md:flex-row items-center justify-between space-y-6 md:space-y-0\">\r\n        <h1 class=\"title\">\r\n            All Students\r\n        </h1>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 12 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
 if (Model.Active.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card has-table"" style=""margin-top:20px"">
        <header class=""card-header"">
            <p class=""card-header-title"">
                <span class=""icon""><i class=""mdi mdi-account-multiple""></i></span>
                Active Students
            </p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65c4825240d8e6f80adf4e046aa35376729900717749", async() => {
                WriteLiteral("\r\n                <span class=\"icon\"><i class=\"mdi mdi-reload\"></i></span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </header>
        <div class=""card-content"">
            <table>
                <thead>
                    <tr>
                        <th></th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Address</th>
                        <th>Under Training</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 37 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                     foreach (var item in Model.Active)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"image-cell\">\r\n                                <div class=\"image\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1460, "\"", 1490, 1);
#nullable restore
#line 42 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
WriteAttributeValue("", 1466, Url.Content(item.Image), 1466, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-full\">\r\n                                </div>\r\n                            </td>\r\n                            <td data-label=\"Name\">");
#nullable restore
#line 45 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                             Write(item.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td data-label=\"Email\">");
#nullable restore
#line 46 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                              Write(item.StudentEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td data-label=\"Address\">");
#nullable restore
#line 47 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                                Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td data-label=\"TrainingStatus\">\r\n                                <label class=\"checkbox\">\r\n");
#nullable restore
#line 50 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                     if (item.isTrainee)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input type=\"checkbox\" checked disabled>\r\n");
#nullable restore
#line 53 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input type=\"checkbox\" disabled>\r\n");
#nullable restore
#line 57 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <span class=""check is-primary""></span>

                                </label>
                            </td>
                            <td class=""actions-cell"">
                                <div class=""buttons right nowrap"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65c4825240d8e6f80adf4e046aa353767299007113261", async() => {
                WriteLiteral("\r\n                                        <span style=\"font-size:25px\" class=\"icon\"><i class=\"mdi mdi-account-circle\"></i></span>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                                                                               WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                                                                                                                     WriteLiteral(item.isTrainee);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isTrainee"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isTrainee", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isTrainee"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 71 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 76 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card empty"" style=""margin-top:20px"">
        <div class=""card-content"">
            <div>
                <span class=""icon large""><i class=""mdi mdi-emoticon-sad mdi-48px""></i></span>
            </div>
            <p>No Active students found</p>
        </div>
    </div>
");
#nullable restore
#line 87 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 91 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
 if (Model.NonActive.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card has-table"" style=""margin-top:20px"">
    <header class=""card-header"">
        <p class=""card-header-title"">
            <span class=""icon""><i class=""mdi mdi-account-multiple""></i></span>
            Not Active Students
        </p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65c4825240d8e6f80adf4e046aa353767299007118838", async() => {
                WriteLiteral("\r\n            <span class=\"icon\"><i class=\"mdi mdi-reload\"></i></span>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </header>
    <div class=""card-content"">
        <table>
            <thead>
                <tr>
                    <th></th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Address</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 115 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                 foreach (var item in Model.NonActive)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"image-cell\">\r\n                            <div class=\"image\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 4586, "\"", 4616, 1);
#nullable restore
#line 120 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
WriteAttributeValue("", 4592, Url.Content(item.Image), 4592, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-full\">\r\n                            </div>\r\n                        </td>\r\n                        <td data-label=\"Name\">");
#nullable restore
#line 123 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                         Write(item.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td data-label=\"Company\">");
#nullable restore
#line 124 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                            Write(item.StudentEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td data-label=\"City\">");
#nullable restore
#line 125 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                         Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"actions-cell\">\r\n                            <div class=\"buttons right nowrap\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65c4825240d8e6f80adf4e046aa353767299007122759", async() => {
                WriteLiteral("\r\n                                    <span class=\"icon\"><i class=\"mdi mdi-eye\"></i></span>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                                                                           WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                                                                                                                                 WriteLiteral(item.isTrainee);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isTrainee"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isTrainee", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isTrainee"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 134 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 139 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"

}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card empty"" style=""margin-top:20px"">
        <div class=""card-content"">
            <div>
                <span class=""icon large""><i class=""mdi mdi-emoticon-sad mdi-48px""></i></span>
            </div>
            <p>No Non Active students found</p>
        </div>
    </div>
");
#nullable restore
#line 150 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Areas\University\Views\Students\AllStudents.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllStudentsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
