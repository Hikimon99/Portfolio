#pragma checksum "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7289efe3aaac46a164a26551b43c4431473be1d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kim_InHo_HW3.Views.Home.Views_Home_CateringTotals), @"mvc.1.0.view", @"/Views/Home/CateringTotals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CateringTotals.cshtml", typeof(Kim_InHo_HW3.Views.Home.Views_Home_CateringTotals))]
namespace Kim_InHo_HW3.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7289efe3aaac46a164a26551b43c4431473be1d7", @"/Views/Home/CateringTotals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b2c82936c7856a8ac3c6ecc8ae3a5820657df7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CateringTotals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kim_InHo_HW3.Models.CateringOrder>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(84, 139, true);
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<div>\r\n    <h4>Catering Order Totals</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(224, 48, false);
#line 14 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerCode));

#line default
#line hidden
            EndContext();
            BeginContext(272, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(334, 44, false);
#line 17 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.CustomerCode));

#line default
#line hidden
            EndContext();
            BeginContext(378, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(439, 48, false);
#line 20 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Customertype));

#line default
#line hidden
            EndContext();
            BeginContext(487, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(549, 44, false);
#line 23 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.Customertype));

#line default
#line hidden
            EndContext();
            BeginContext(593, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(654, 53, false);
#line 26 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.PreferredCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(707, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(769, 49, false);
#line 29 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.PreferredCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(818, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(879, 49, false);
#line 32 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfTacos));

#line default
#line hidden
            EndContext();
            BeginContext(928, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(990, 45, false);
#line 35 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfTacos));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1096, 54, false);
#line 38 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfSandwiches));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1212, 50, false);
#line 41 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfSandwiches));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1323, 46, false);
#line 44 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalItems));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1431, 42, false);
#line 47 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.TotalItems));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1534, 48, false);
#line 50 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.TacoSubtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1644, 44, false);
#line 53 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.TacoSubtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1749, 52, false);
#line 56 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.SandwichSubtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1863, 48, false);
#line 59 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.SandwichSubtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1972, 44, false);
#line 62 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2078, 40, false);
#line 65 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2179, 47, false);
#line 68 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliveryFee));

#line default
#line hidden
            EndContext();
            BeginContext(2226, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2288, 43, false);
#line 71 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.DeliveryFee));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2392, 41, false);
#line 74 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2433, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2495, 37, false);
#line 77 "C:\Users\InhoK\Documents\Notthistime\Kim_InHo_HW3\Views\Home\CateringTotals.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2532, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2579, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7289efe3aaac46a164a26551b43c4431473be1d713151", async() => {
                BeginContext(2601, 17, true);
                WriteLiteral("Start A New Order");
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
            BeginContext(2622, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kim_InHo_HW3.Models.CateringOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
