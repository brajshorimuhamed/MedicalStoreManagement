#pragma checksum "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149de8407cf6a27bb61634921334e5b781c8188e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_Details), @"mvc.1.0.view", @"/Views/Purchase/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchase/Details.cshtml", typeof(AspNetCore.Views_Purchase_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149de8407cf6a27bb61634921334e5b781c8188e", @"/Views/Purchase/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4acd0e4fa1abd1ebc57070b130750caaf55f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicalStoreManagement.Web.ViewModels.PurchaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(156, 110, true);
            WriteLiteral("\r\n<h1 style=\"color: darkred\">Details</h1>\r\n\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(267, 38, false);
#line 13 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(305, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(349, 34, false);
#line 16 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 45, false);
#line 19 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(516, 41, false);
#line 22 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(601, 44, false);
#line 25 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(689, 40, false);
#line 28 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(729, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(773, 41, false);
#line 31 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(858, 37, false);
#line 34 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(895, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(939, 46, false);
#line 37 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FurnitorID));

#line default
#line hidden
            EndContext();
            BeginContext(985, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1029, 42, false);
#line 40 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Purchase\Details.cshtml"
       Write(Html.DisplayFor(model => model.FurnitorID));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1118, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fece8957e80405f9aed4a67fdcbe9dd", async() => {
                BeginContext(1140, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1156, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalStoreManagement.Web.ViewModels.PurchaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
