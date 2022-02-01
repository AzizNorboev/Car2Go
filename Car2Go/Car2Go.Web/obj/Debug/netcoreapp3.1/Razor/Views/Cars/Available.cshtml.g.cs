#pragma checksum "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e883c45cded36bc7358b3612de05c30b8bb31a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Available), @"mvc.1.0.view", @"/Views/Cars/Available.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e883c45cded36bc7358b3612de05c30b8bb31a6", @"/Views/Cars/Available.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f53317874c6a6812e4ab1d2d4aa5aa7b053128", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Available : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car2Go.Web.ViewModels.Cars.AvailableCarsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Preview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
  
    ViewData["Title"] = "Available cars";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 style=\"margin-top:2%\">Available cars for the period ");
#nullable restore
#line 6 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                   Write(Model.Start.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 6 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                                                           Write(Model.End.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<hr class=\"border-info\" />\n");
#nullable restore
#line 9 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
 if (Model.Cars.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Sorry, we dont have any available car in this location.</h1>\n");
#nullable restore
#line 12 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
}
else
{

    var counter = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("<div class=\"row justify-content-between\">\n");
#nullable restore
#line 19 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
         foreach (var item in Model.Cars)
        {
            counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-2 col-md-5 border-info \">\n                <h3 class=\"card-header\" style=\"background-color:transparent\">");
#nullable restore
#line 23 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                                        Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <img style=\"height: 280px; width: 440px; display: block;\"");
            BeginWriteAttribute("src", " src=\"", 749, "\"", 766, 1);
#nullable restore
#line 24 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 755, item.Image, 755, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 767, "\"", 784, 1);
#nullable restore
#line 24 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 773, item.Model, 773, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"card-body\">\n                    <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <ul class=\"list-group list-group-flush\">\n                    <li class=\"list-group-item\">Year: ");
#nullable restore
#line 29 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                 Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li class=\"list-group-item\">Gear Type: ");
#nullable restore
#line 30 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                      Write(item.GearType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li class=\"list-group-item\">Price pey day: ");
#nullable restore
#line 31 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                          Write(item.PricePerDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UZS</li>\n                    <li class=\"list-group-item\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1295, "\"", 1324, 2);
            WriteAttributeValue("", 1302, "/Cars/Details/", 1302, 14, true);
#nullable restore
#line 33 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 1316, item.Id, 1316, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details Page</a>\n                    </li>\n                </ul>\n                <div class=\"justify-content-center mx-2 mb-2 m-2\">\n");
#nullable restore
#line 37 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                       decimal price = (decimal)Model.Days * item.PricePerDay; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e883c45cded36bc7358b3612de05c30b8bb31a69761", async() => {
                WriteLiteral("\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1670, "\"", 1686, 1);
#nullable restore
#line 40 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 1678, item.Id, 1678, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1745, "\"", 1764, 1);
#nullable restore
#line 41 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 1753, item.Model, 1753, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Model\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1826, "\"", 1851, 1);
#nullable restore
#line 42 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 1834, item.PricePerDay, 1834, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PricePerDay\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1919, "\"", 1938, 1);
#nullable restore
#line 43 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 1927, Model.Days, 1927, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Days\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1999, "\"", 2019, 1);
#nullable restore
#line 44 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 2007, Model.Start, 2007, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"RentStart\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2085, "\"", 2103, 1);
#nullable restore
#line 45 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 2093, Model.End, 2093, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"RentEnd\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2167, "\"", 2186, 1);
#nullable restore
#line 46 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 2175, item.Image, 2175, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Image\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2248, "\"", 2274, 1);
#nullable restore
#line 47 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 2256, Model.PickUpPlace, 2256, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PickUpPlace\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2342, "\"", 2368, 1);
#nullable restore
#line 48 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
WriteAttributeValue("", 2350, Model.ReturnPlace, 2350, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ReturnPlace\" />\n                        <button type=\"submit\" class=\"btn btn-warning w-100 \">Rent this car for $");
#nullable restore
#line 49 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                                                           Write(price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n                    ");
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
            WriteLiteral("\n\n                </div>\n            </div>\n");
#nullable restore
#line 54 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
            if (counter % 2 == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
       Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
       Write(Html.Raw("<div class=\"row justify-content-between\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
                                                                    
        }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Available.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("       </div>\n    \n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car2Go.Web.ViewModels.Cars.AvailableCarsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
