#pragma checksum "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a1c374feb4ec96548012ac24df717a9d122c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_MyOrders), @"mvc.1.0.view", @"/Views/Orders/MyOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a1c374feb4ec96548012ac24df717a9d122c05", @"/Views/Orders/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f53317874c6a6812e4ab1d2d4aa5aa7b053128", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car2Go.Web.ViewModels.Orders.AllOrderInputViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
   ViewData["Title"] = "My Orders"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center>
    <h1 style=""margin-top:2%"">
        My Orders
    </h1>
</center>
<hr class=""border-info"" />



<table class=""table table-hover border"" name=""allorders"" id=""allorders"">
    <thead>
        <tr class=""table-primary "">
            <th scope=""col"">Order Id</th>
            <th scope=""col"">Car Model</th>
            <th scope=""col"">Pick Up Location</th>
            <th scope=""col"">Return Location</th>
            <th scope=""col"">Start Date</th>
            <th scope=""col"">End Date</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Status</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 30 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
         foreach (var order in Model.Orders)
        {
            if (order.Status.ToString() == "Canceled")
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
Write(Html.Raw(" <tr class=\"table-danger\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                          }
else if (order.Status.ToString() == "Finished")
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
Write(Html.Raw(" <tr class=\"table-success\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                           }
else
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
Write(Html.Raw(" <tr class=\"table-warning\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n<th scope=\"row\"><a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1100, 2);
            WriteAttributeValue("", 1075, "/orders/details/", 1075, 16, true);
#nullable restore
#line 42 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
WriteAttributeValue("", 1091, order.Id, 1091, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                               Write(order.Id.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\n                                               <td>\n                                    ");
#nullable restore
#line 44 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                               Write(order.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>");
#nullable restore
#line 46 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                           Write(order.PickUpLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 47 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                           Write(order.ReturnLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                            <td>");
#nullable restore
#line 48 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                           Write(order.RentStart.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                            <td>");
#nullable restore
#line 49 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                                           Write(order.RentEnd.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                            <td>$");
#nullable restore
#line 50 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                                                            Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                                            <td>\n                                                                                                                ");
#nullable restore
#line 52 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                                                                           Write(order.Status.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                                                        </td> </tr>\n");
#nullable restore
#line 54 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                                                                                                   Write(Html.Raw(" </tr>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                                                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n");
#nullable restore
#line 58 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
     if (Model.Orders.Count() > 0)
    {
        var spent = this.Model.Orders.Sum(x => x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"text-info\">Total spent: $ ");
#nullable restore
#line 61 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                Write(spent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
#nullable restore
#line 61 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Orders\MyOrders.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car2Go.Web.ViewModels.Orders.AllOrderInputViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
