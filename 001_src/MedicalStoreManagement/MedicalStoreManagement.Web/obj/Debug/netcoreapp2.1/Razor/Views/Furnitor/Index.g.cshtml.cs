#pragma checksum "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "775b6ce2eac64f5d2fae5bc049ac939766df2074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Furnitor_Index), @"mvc.1.0.view", @"/Views/Furnitor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Furnitor/Index.cshtml", typeof(AspNetCore.Views_Furnitor_Index))]
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
#line 1 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\_ViewImports.cshtml"
using MedicalStoreManagement.Web;

#line default
#line hidden
#line 2 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\_ViewImports.cshtml"
using MedicalStoreManagement.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775b6ce2eac64f5d2fae5bc049ac939766df2074", @"/Views/Furnitor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4acd0e4fa1abd1ebc57070b130750caaf55f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Furnitor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicalStoreManagement.Web.ViewModels.FurnitorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFurnitor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 52, true);
            WriteLiteral("\r\n<h1 style=\"color: darkred\">Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(206, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3646a1241c334f26af4b7ca9fdc02cc3", async() => {
                BeginContext(234, 19, true);
                WriteLiteral("Create New Furnitor");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(257, 162, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                #\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(420, 54, false);
#line 20 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnitor_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(530, 53, false);
#line 23 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnitor_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(583, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(639, 52, false);
#line 26 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnitor_NrPhone));

#line default
#line hidden
            EndContext();
            BeginContext(691, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(747, 50, false);
#line 29 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnitor_Email));

#line default
#line hidden
            EndContext();
            BeginContext(797, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(853, 52, false);
#line 32 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnitor_Address));

#line default
#line hidden
            EndContext();
            BeginContext(905, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
 foreach (var item in Model.Furnitors) {

#line default
#line hidden
            BeginContext(1033, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1082, 37, false);
#line 41 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1175, 53, false);
#line 44 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnitor_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1284, 52, false);
#line 47 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnitor_LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1392, 51, false);
#line 50 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnitor_NrPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1499, 49, false);
#line 53 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnitor_Email));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1604, 51, false);
#line 56 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnitor_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1711, 69, false);
#line 59 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.ActionLink("Edit", "EditFurnitor", new { furnitorId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1801, 67, false);
#line 60 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { furnitorId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1889, 73, false);
#line 61 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteFurnitor", new { furnitorId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Furnitor\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2001, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalStoreManagement.Web.ViewModels.FurnitorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
