#pragma checksum "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75fa770c11015ff0acca524c7422898861553dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Preview), @"mvc.1.0.view", @"/Views/Orders/Preview.cshtml")]
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
#line 1 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\_ViewImports.cshtml"
using Car2Go.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\_ViewImports.cshtml"
using Car2Go.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75fa770c11015ff0acca524c7422898861553dca", @"/Views/Orders/Preview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f53317874c6a6812e4ab1d2d4aa5aa7b053128", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Preview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car2Go.Web.ViewModels.Orders.OrderPreviewInputModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Available", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
   ViewData["Title"] = "Preview"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Hello</h1>\n\n\n<div class=\"container-fluid col-md-10 border-danger\" style=\"margin-top: 4%\">\n\n    <h3><strong>Dear, ");
#nullable restore
#line 10 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                 Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\n    <h2><strong>Your order preview:</strong></h2>\n    <hr />\n    <div class=\"mx-auto\">\n        <div class=\"receipt-id-handler d-flex justify-content-between\">\n            <h3>Car Model:</h3>\n            <h3>");
#nullable restore
#line 16 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
           Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n        <hr />\n        <div class=\"d-flex justify-content-between\">\n            <h4>Rent start:</h4>\n            <h4>");
#nullable restore
#line 21 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
           Write(Model.RentStart.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        </div>\n        <div class=\"d-flex justify-content-between\">\n            <h4>Rent end:</h4>\n            <h4>");
#nullable restore
#line 25 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
           Write(Model.RentEnd.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        </div>\n        <hr />\n        <div class=\"d-flex justify-content-between\">\n            <h4>Price per day:</h4>\n            <h4>");
#nullable restore
#line 30 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
           Write(Model.PricePerDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UZS</h4>\n        </div>\n");
#nullable restore
#line 32 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
         if (@Model.DiscountPercent > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex justify-content-between\">\n                <h4>Price for ");
#nullable restore
#line 35 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                         Write(Model.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days:</h4>\n                <h4>$");
#nullable restore
#line 36 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                Write(Model.PriceWithoutDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            </div>\n            <div class=\"d-flex justify-content-between\" style=\"color:red\">\n                <h4>Discount:</h4>\n                <h4>- ");
#nullable restore
#line 40 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                 Write(Model.DiscountSum.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" UZS</h4>\n            </div>");
#nullable restore
#line 41 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"d-flex justify-content-between\">\n            <h4>Total Price:</h4>\n            <h4>");
#nullable restore
#line 45 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
           Write(Model.TotalPrice.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" UZS</h4>\n        </div>\n        <hr />\n        <div class=\"d-flex justify-content-between\">\n            <h4>You can pick up your car from <strong>");
#nullable restore
#line 49 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                                                 Write(Model.PickUpPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>, and return it to <strong>");
#nullable restore
#line 49 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                                                                                                       Write(Model.ReturnPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>, until the end of <strong>");
#nullable restore
#line 49 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
                                                                                                                                                             Write(Model.RentEnd.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.</h4>\n        </div>\n\n\n\n     \n\n    </div>\n</div>\n\n<center>\n    <div class=\"d-flex justify-content-around\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75fa770c11015ff0acca524c7422898861553dca10461", async() => {
                WriteLiteral("\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2055, "\"", 2081, 1);
#nullable restore
#line 62 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2063, Model.ReturnPlace, 2063, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ReturnPlace\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2137, "\"", 2163, 1);
#nullable restore
#line 63 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2145, Model.PickUpPlace, 2145, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PickupPlace\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2219, "\"", 2243, 1);
#nullable restore
#line 64 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2227, Model.RentStart, 2227, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Pickup\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2294, "\"", 2316, 1);
#nullable restore
#line 65 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2302, Model.RentEnd, 2302, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Return\" />\n            <br />\n            <button type=\"submit\" class=\"btn btn-danger\">Cancel</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75fa770c11015ff0acca524c7422898861553dca14211", async() => {
                WriteLiteral("\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2547, "\"", 2573, 1);
#nullable restore
#line 70 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2555, Model.ReturnPlace, 2555, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ReturnPlace\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2629, "\"", 2655, 1);
#nullable restore
#line 71 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2637, Model.PickUpPlace, 2637, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PickupPlace\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2711, "\"", 2735, 1);
#nullable restore
#line 72 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2719, Model.RentStart, 2719, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Pickup\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2786, "\"", 2808, 1);
#nullable restore
#line 73 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2794, Model.RentEnd, 2794, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Return\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2859, "\"", 2876, 1);
#nullable restore
#line 74 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2867, Model.Id, 2867, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2923, "\"", 2948, 1);
#nullable restore
#line 75 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\Preview.cshtml"
WriteAttributeValue("", 2931, Model.TotalPrice, 2931, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Price\" />\n            <br />\n            <button type=\"submit\" class=\"btn btn-success\">Confirm</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car2Go.Web.ViewModels.Orders.OrderPreviewInputModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
