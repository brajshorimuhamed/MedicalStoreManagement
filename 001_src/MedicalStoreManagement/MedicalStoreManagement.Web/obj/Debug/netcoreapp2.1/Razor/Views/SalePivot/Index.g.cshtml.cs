#pragma checksum "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24cd1a9f55084cbf00f39badfc5ecd3fc1b831fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalePivot_Index), @"mvc.1.0.view", @"/Views/SalePivot/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalePivot/Index.cshtml", typeof(AspNetCore.Views_SalePivot_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24cd1a9f55084cbf00f39badfc5ecd3fc1b831fe", @"/Views/SalePivot/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4acd0e4fa1abd1ebc57070b130750caaf55f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalePivot_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicalStoreManagement.Web.ViewModels.SalePivotViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSalePivot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerPivot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(184, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5fb9029f6b347e49a4e0f226f354402", async() => {
                BeginContext(237, 20, true);
                WriteLiteral("Create New SalePivot");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(267, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff8983e21104346accdef6268ffa187", async() => {
                BeginContext(356, 24, true);
                WriteLiteral("Customer Without Recepts");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 148, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                #\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(533, 45, false);
#line 21 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(578, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(634, 44, false);
#line 24 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(678, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(734, 41, false);
#line 27 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(775, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(831, 47, false);
#line 30 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotaliSales));

#line default
#line hidden
            EndContext();
            BeginContext(878, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(934, 51, false);
#line 33 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerPivotID));

#line default
#line hidden
            EndContext();
            BeginContext(985, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
 foreach (var item in Model.SalePivots) {

#line default
#line hidden
            BeginContext(1114, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1163, 37, false);
#line 42 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1256, 55, false);
#line 45 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Product_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1367, 43, false);
#line 48 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1466, 40, false);
#line 51 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 53 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
               var totliSales = item.Quantity * item.Price;

#line default
#line hidden
            BeginContext(1589, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(1606, 10, false);
#line 54 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(totliSales);

#line default
#line hidden
            EndContext();
            BeginContext(1616, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1658, 57, false);
#line 56 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerPivot.Research));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1771, 71, false);
#line 59 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.ActionLink("Edit", "EditSalePivot", new { salePivotId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1863, 68, false);
#line 60 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { salePivotId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1931, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1952, 75, false);
#line 61 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteSalePivot", new { salePivotId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2027, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\SalePivot\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2066, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalStoreManagement.Web.ViewModels.SalePivotViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
