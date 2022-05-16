#pragma checksum "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c5523aad45f9fc2fbd5b58000c4291eb0278ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Administration/Views/Orders/Details.cshtml")]
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
#line 1 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\_ViewImports.cshtml"
using Car2Go.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\_ViewImports.cshtml"
using Car2Go.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c5523aad45f9fc2fbd5b58000c4291eb0278ac", @"/Areas/Administration/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f53317874c6a6812e4ab1d2d4aa5aa7b053128", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car2Go.Web.ViewModels.Orders.OrdersDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
   ViewData["Title"] = "Order Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
 foreach (var order in Model.Cars)
{ 


#line default
#line hidden
#nullable disable
            WriteLiteral("<hr class=\"border-primary\" />\n<div class=\"container-fluid\">\n    <div class=\"d-flex justify-content-between\">\n        <h4>Customer Email:</h4>\n        <h4>");
#nullable restore
#line 39 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
       Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <hr class=\"border-primary\" />\n    <div class=\"d-flex justify-content-between\">\n        <h4>Pick Up Location:</h4>\n        <h4>");
#nullable restore
#line 44 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
       Write(order.PickUpLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"d-flex justify-content-between\">\n        <h4>Return Location:</h4>\n        <h4>");
#nullable restore
#line 48 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
       Write(order.ReturnLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <hr class=\"border-primary\" />\n    <div class=\"d-flex justify-content-between\">\n        <h4>Rent start:</h4>\n        <h4>");
#nullable restore
#line 53 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
       Write(order.RentStart.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"d-flex justify-content-between\">\n        <h4>Rent end:</h4>\n        <h4>");
#nullable restore
#line 57 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
       Write(order.RentEnd.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <hr class=\"border-primary\" />\n    <h2>Your Car:</h2>\n    <div class=\"d-flex justify-content-between\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 2503, "\"", 2521, 1);
#nullable restore
#line 62 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
WriteAttributeValue("", 2509, order.Image, 2509, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" width=\"150\"/>\n        <div>\n            <h4>Model: ");
#nullable restore
#line 64 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                  Write(order.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <h4>Gear Type: ");
#nullable restore
#line 65 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                      Write(order.CarGearType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <h4>Year: ");
#nullable restore
#line 66 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                 Write(order.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        </div>\n    </div>\n    <div>");
#nullable restore
#line 69 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
    Write(order.Description.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <hr class=\"border-primary\" />\n</div>\n<center>\n    <div class=\"text-success\" style=\"font-size:200%\">Price: ");
#nullable restore
#line 73 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                                                       Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UZS</div>\n</center>\n");
#nullable restore
#line 77 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
 if (order.Comment != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr class=\"border-primary\" />\n                <div class=\"justify-content-between\">\n                    <h3>Your Feedback:</h3>\n                    <h4>");
#nullable restore
#line 82 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                   Write(order.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong class=\"text-primary\">Rating: ");
#nullable restore
#line 82 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                                                                       Write(order.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\n                </div>");
#nullable restore
#line 83 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Areas\Administration\Views\Orders\Details.cshtml"
                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr class=\"border-primary\" />\n<script>\n    function myFunction() {\n        window.print();\n    }</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car2Go.Web.ViewModels.Orders.OrdersDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
