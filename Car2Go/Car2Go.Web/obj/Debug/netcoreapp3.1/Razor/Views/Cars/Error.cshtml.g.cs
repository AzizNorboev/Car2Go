#pragma checksum "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b9868073fd690cce0bf8f2ef887646d2fff6c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Error), @"mvc.1.0.view", @"/Views/Cars/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b9868073fd690cce0bf8f2ef887646d2fff6c3", @"/Views/Cars/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f53317874c6a6812e4ab1d2d4aa5aa7b053128", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3 style=\"color:red\">Pick up date cannot be earier than today\'s date or later than return date</h3>\r\n\r\n<input type=\"button\" value=\"OK\" class=\"button\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 280, "\"", 335, 3);
            WriteAttributeValue("", 291, "location.href=\'", 291, 15, true);
#nullable restore
#line 8 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Cars\Error.cshtml"
WriteAttributeValue("", 306, Url.Action("Index", "Home"), 306, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 334, "\'", 334, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />

<style type=""text/css"">
    .button {
        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#5384BE', endColorstr='#4386D7');
        /* for IE */
        -ms-filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#5384BE', endColorstr='#4386D7');
        /* for IE 8 and above */
        background: -webkit-gradient(linear, left top, left bottom, from(#5384BE), to(#4386D7));
        /* for webkit browsers */
        background: -moz-linear-gradient(top, #5384BE, #4386D7);
        /* for firefox 3.6+ */
        background: -o-linear-gradient(top, #5384BE, #4386D7);
        /* for Opera */
        width: 70px;
        margin-left:400px;
        margin-top:30px;
    }
</style> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
