#pragma checksum "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855be9a213a3c46c8d786d55d196348b3ab09cd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerPivot_Details), @"mvc.1.0.view", @"/Views/CustomerPivot/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerPivot/Details.cshtml", typeof(AspNetCore.Views_CustomerPivot_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855be9a213a3c46c8d786d55d196348b3ab09cd9", @"/Views/CustomerPivot/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4acd0e4fa1abd1ebc57070b130750caaf55f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerPivot_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicalStoreManagement.Web.ViewModels.CustomerPivotViewModel>
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 110, true);
            WriteLiteral("\r\n<h1 style=\"color: darkred\">Details</h1>\r\n\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(272, 38, false);
#line 13 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(354, 34, false);
#line 16 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 44, false);
#line 19 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Research));

#line default
#line hidden
            EndContext();
            BeginContext(476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(520, 40, false);
#line 22 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayFor(model => model.Research));

#line default
#line hidden
            EndContext();
            BeginContext(560, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(604, 45, false);
#line 25 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(649, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(693, 41, false);
#line 28 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(734, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(778, 49, false);
#line 31 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductStatus));

#line default
#line hidden
            EndContext();
            BeginContext(827, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(871, 45, false);
#line 34 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\CustomerPivot\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductStatus));

#line default
#line hidden
            EndContext();
            BeginContext(916, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(963, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb486a4416a440d291a1d6520bc8ee89", async() => {
                BeginContext(985, 12, true);
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
            BeginContext(1001, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalStoreManagement.Web.ViewModels.CustomerPivotViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
