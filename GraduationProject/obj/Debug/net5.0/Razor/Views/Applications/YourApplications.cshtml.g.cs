#pragma checksum "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a39494c634c0ec791eef1db2ae37661522b19d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_YourApplications), @"mvc.1.0.view", @"/Views/Applications/YourApplications.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\_ViewImports.cshtml"
using GraduationProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\_ViewImports.cshtml"
using GraduationProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\_ViewImports.cshtml"
using GraduationProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a39494c634c0ec791eef1db2ae37661522b19d7", @"/Views/Applications/YourApplications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72128e21e5c3afd9628c3367c16f42e30478d26a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Applications_YourApplications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChooseApplication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteApplication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
  
    ViewData["Title"] = "YourApplications";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<span class=\"text-danger\">");
#nullable restore
#line 6 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                     Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
 if (@ViewBag.ApplyingStatus != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""warning-box-big animate__animated animate__fadeIn animate__faster"">
        <div class=""warning-box animate__animated animate__fadeInDown animate__faster"">
            <h4 style=""color: var(--bs-success);""> You Have Made The Application Succesfully</h4>
            <button class=""btn btn-outline-success application-button""> OK </button>
        </div>
    </div>
");
#nullable restore
#line 16 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 22 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
 if (Model.Any())
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h1 class=""text-center"" style=""margin-bottom:30px;color: var(--bs-gray);"">Your Applications</h1>
    <table class=""table"" style=""margin: 0px auto 40px auto;width: 80%;background: white;border-radius: 10px;"">
        <thead>
            <tr class=""first-row"">
                <th>
                    ");
#nullable restore
#line 30 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
               Write(Html.DisplayNameFor(model => model.Training.Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
               Write(Html.DisplayNameFor(model => model.Training.TrainingTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th> Confirm/Delete </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div class=\"td-parent\">\r\n\r\n                            <img class=\"td-child\"");
            BeginWriteAttribute("src", " src=\"", 1543, "\"", 1590, 1);
#nullable restore
#line 49 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
WriteAttributeValue("", 1549, Url.Content(item.Training.Company.Image), 1549, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" style=\"border-radius: 10%;\">\r\n\r\n                            <div class=\"td-child\">\r\n                                <p style=\"padding-left: 10px; font-weight:700\"> ");
#nullable restore
#line 52 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                                                           Write(item.Training.Company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p style=\"padding-left: 10px; padding-left: 10px;font-size: 10px;color: #AAA;margin-top: -10px;\"> ");
#nullable restore
#line 53 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                                                                                                             Write(item.Training.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                   Write(item.Training.TrainingTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"position:relative\">\r\n");
#nullable restore
#line 69 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                         if (item.Status == Application.status.Accepted)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <a onclick=""showConfirmation()"">
                                <span class=""material-symbols-outlined check-accepted"">
                                    check_circle
                                </span>
                            </a>
                            <div id=""confirmationPopup"" class=""warning-box-big animate__animated animate__fadeIn animate__faster"">
                                <div class=""warning-box animate__animated animate__fadeInDown animate__faster"">
                                    <h4 style=""color: var(--bs-primary);""> Are you sure you want to choose ");
#nullable restore
#line 78 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                                                                                      Write(item.Training.TrainingTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Training?   </h4>
                                    <h6 style=""color:var(--bs-danger);""> * Please note that this action cannot be undone. </h6>
                                    <div style=""display: flex;gap: 50px;"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a39494c634c0ec791eef1db2ae37661522b19d713031", async() => {
                WriteLiteral(" Confirm ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-trainingId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                                                                                              WriteLiteral(item.TrainingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["trainingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-trainingId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["trainingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <a class=\"btn btn-outline-primary cancel-button\" onclick=\"hideConfirmation()\"> Cancel </a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 86 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"material-symbols-outlined check-pending\">\r\n                                check_circle\r\n                            </span>\r\n");
#nullable restore
#line 92 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <a onclick=""showDelete()"">
                            <span class=""material-symbols-outlined cancel-icon"">
                                cancel
                            </span>
                        </a>
                        <div id=""deletePopup"" class=""warning-box-big animate__animated animate__fadeIn animate__faster"">
                            <div class=""warning-box animate__animated animate__fadeInDown animate__faster"">
                                <h4 style=""color: var(--bs-danger);""> Are you sure you want to delete ");
#nullable restore
#line 101 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                                                                                 Write(item.Training.TrainingTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Application?   </h4>\r\n                                <div style=\"display: flex;gap: 50px;\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a39494c634c0ec791eef1db2ae37661522b19d717723", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-trainingId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                                                                                              WriteLiteral(item.TrainingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["trainingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-trainingId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["trainingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <a class=""btn btn-outline-primary cancel-button"" onclick=""hideDelete()""> Cancel </a>
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
");
#nullable restore
#line 110 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 114 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"

}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"search-not-found\">\r\n        <span class=\"material-symbols-outlined\" style=\"font-size: 70px;color: #437ece;\">\r\n            library_books\r\n        </span>\r\n        <h3 style=\"color: var(--bs-gray);\">");
#nullable restore
#line 123 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
                                      Write(ViewBag.NoResultsFound);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 125 "C:\Users\user\OneDrive\Desktop\Intern.Jo - Copy\Intern.Jo\GraduationProject\Views\Applications\YourApplications.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    var button = document.querySelector('.application-button');
    button.addEventListener('click', function () {
        var warningBoxBig = document.querySelector('.warning-box-big');
        var warningBox = document.querySelector('.warning-box');
        warningBoxBig.style.display = 'none';
        warningBox.style.display = 'none';
    });


    var warningBoxBig = document.querySelector('.warning-box-big');
    var warningBox = document.querySelector('.warning-box');

    document.body.addEventListener('click', function (event) {
        var target = event.target;

        var isWithinWarningBox = warningBox.contains(target);
        var isWithinWarningBoxBig = warningBoxBig.contains(target);

        if (!isWithinWarningBox && isWithinWarningBoxBig) {
            warningBoxBig.style.display = 'none';
            warningBox.style.display = 'none';
        }
    });


    function showConfirmation() {
        var confirmationPopup = document.getElementById(""confirm");
            WriteLiteral(@"ationPopup"");
        confirmationPopup.style.display = ""block"";
    }

    function hideConfirmation() {
        var confirmationPopup = document.getElementById(""confirmationPopup"");
        confirmationPopup.style.display = ""none"";

    }    function showDelete() {
        var confirmationPopup = document.getElementById(""deletePopup"");
        confirmationPopup.style.display = ""block"";
    }

    function hideDelete() {
        var confirmationPopup = document.getElementById(""deletePopup"");
        confirmationPopup.style.display = ""none"";
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
