#pragma checksum "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9bafa90c2fdb29175fb2b928aa454d3bee8fd88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9bafa90c2fdb29175fb2b928aa454d3bee8fd88", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4acd0e4fa1abd1ebc57070b130750caaf55f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicalStoreManagement.Web.ViewModels.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Billing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 52, true);
            WriteLiteral("\r\n<h1 style=\"color: darkred\">Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(205, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2edbeae2e2ee4445b95f1f2d4a908d2c", async() => {
                BeginContext(232, 18, true);
                WriteLiteral("Create New Product");
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
            BeginContext(254, 162, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                #\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(417, 48, false);
#line 20 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Name));

#line default
#line hidden
            EndContext();
            BeginContext(465, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(521, 40, false);
#line 23 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(561, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(617, 48, false);
#line 26 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(665, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(721, 46, false);
#line 29 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FurnitorID));

#line default
#line hidden
            EndContext();
            BeginContext(767, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(823, 47, false);
#line 32 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(870, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(926, 46, false);
#line 35 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(972, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1028, 55, false);
#line 38 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Description));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
 foreach (var item in Model.Products) {

#line default
#line hidden
            BeginContext(1210, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1259, 37, false);
#line 47 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1351, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3ffe8d24bbc4a83b54bbe0b2a4e66b8", async() => {
                BeginContext(1411, 47, false);
#line 50 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Product_Name));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1518, 39, false);
#line 53 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1613, 47, false);
#line 56 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1716, 62, false);
#line 59 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnitor.Furnitor_FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1834, 46, false);
#line 62 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1936, 57, false);
#line 65 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Category_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2049, 54, false);
#line 68 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Description));

#line default
#line hidden
            EndContext();
            BeginContext(2103, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2159, 67, false);
#line 71 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Edit", "EditProduct", new { productId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2226, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2247, 66, false);
#line 72 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { productId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2334, 71, false);
#line 73 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteProduct", new { productId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2405, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "C:\Users\CC-PC\source\repos\MedicalStoreManagement\001_src\MedicalStoreManagement\MedicalStoreManagement.Web\Views\Product\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2444, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalStoreManagement.Web.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591