#pragma checksum "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aec414d143667d1ab82be3877a94d6cb37ad10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aec414d143667d1ab82be3877a94d6cb37ad10a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f53317874c6a6812e4ab1d2d4aa5aa7b053128", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SearchCarsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aec414d143667d1ab82be3877a94d6cb37ad10a3935", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Car2Go - Car Rental Service HTML Template</title>
    <!-- site favicon -->
    <link rel=""shortcut icon"" type=""image/png"" href=""/assets/images/favicon.jpg"" />
    <!-- fontawesome css link -->
    <link rel=""stylesheet"" href=""assets/css/fontawesome.min.css"">
    <!-- bootstrap css link -->
    <link rel=""stylesheet"" href=""assets/css/bootstrap.min.css"">
    <!-- lightcase css link -->
    <link rel=""stylesheet"" href=""assets/css/lightcase.css
    <!-- animate css link -->
    <link rel=""stylesheet"" href=""assets/css/animate.css"">
    <!-- nice select css link -->
    <link rel=""stylesheet"" href=""assets/css/nice-select.css"">
    <!-- datepicker css link -->
    <link rel=""stylesheet"" href=""assets/css/datepicker.min.css"">
    <!-- wickedpicker css link -->
    <link rel=""stylesheet"" href=""assets/css/wickedpicker.min.css"">
 ");
                WriteLiteral(@"   <!-- jquery ui css link -->
    <link rel=""stylesheet"" href=""assets/css/jquery-ui.min.css"">
    <!-- owl carousel css link -->
    <link rel=""stylesheet"" href=""assets/css/owl.carousel.min.css"">
    <!-- main style css link -->
    <link rel=""stylesheet"" href=""assets/css/main.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aec414d143667d1ab82be3877a94d6cb37ad10a6304", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div id=\"preloader\"></div>\r\n    <section class=\"banner-section banner-section--style2 bg_img\" data-background=\"/assets/images/Captiva.jpg\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6aec414d143667d1ab82be3877a94d6cb37ad10a6737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 42 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </section>

    <section class=""about-section pt-120 pb-120"">
        <div class=""element text-center""><img src=""/assets/images/elements/malibu.png"" alt=""image""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-5"">
                    <div class=""block-area"">
                        <div class=""block-header"">
                            <h2 class=""title"">");
#nullable restore
#line 52 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
                                         Write(localizer["We are Best Company to Find and rent a Car"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <p> ");
#nullable restore
#line 53 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
                           Write(localizer["Car2Go is the leading national car rental company in Uzbekistan. We operate with the fleet in the country, which currently consists of over cars, 90% of which are brand new or up to 3 years old. We offer national coverage of the service through a chain of over service offices in the country ."]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>

    <div class=""counter-section bg_img overlay-main"" data-background=""assets/images/kia.jpg"">
        <div class=""container"">
            <div class=""row mb-none-30"">
                <div class=""col-lg-3 col-sm-6"">
                    <div class=""counter-item counter-item--style2"">
                        <div class=""icon"">
                            <i class=""fa fa-car""></i>
                        </div>
                        <div class=""content"">
                            <span class=""counter"">0</span>
                            <span class=""title"">");
#nullable restore
#line 72 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
                                           Write(localizer["total car"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </div>
                    </div>
                </div><!-- counter-item end -->
                <div class=""col-lg-3 col-sm-6"">
                    <div class=""counter-item counter-item--style2"">
                        <div class=""icon"">
                            <i class=""fa fa-smile-o""></i>
                        </div>
                        <div class=""content"">
                            <span class=""counter"">0</span>
                            <span class=""title"" style=""font-size: 15.19px"">");
#nullable restore
#line 83 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
                                                                      Write(localizer["happy customer"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </div>
                    </div>
                </div><!-- counter-item end -->
                <div class=""col-lg-3 col-sm-6"">
                    <div class=""counter-item counter-item--style2"">
                        <div class=""icon"">
                            <i class=""fa fa-truck""></i>
                        </div>
                        <div class=""content"">
                            <span class=""counter"">0</span>
                            <span class=""title"">");
#nullable restore
#line 94 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
                                           Write(localizer["travel time"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </div>
                    </div>
                </div><!-- counter-item end -->
                <div class=""col-lg-3 col-sm-6"">
                    <div class=""counter-item counter-item--style2"">
                        <div class=""icon"">
                            <i class=""fa fa-puzzle-piece""></i>
                        </div>
                        <div class=""content"">
                            <span class=""counter"">0</span>
                            <span class=""title"">");
#nullable restore
#line 105 "C:\Users\Aziz_Norboev\Documents\GitHub\Car2Go\Car2Go\Car2Go.Web\Views\Home\Index.cshtml"
                                           Write(localizer["solutions"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""scroll-to-top"">
        <span class=""scroll-icon"">
            <i class=""fa fa-rocket""></i>
        </span>
    </div>

    <script src=""assets/js/jquery-3.3.1.min.js""></script>

    <script src=""assets/js/jquery-migrate-3.0.0.js""></script>

    <script src=""assets/js/bootstrap.min.js""></script>

    <script src=""assets/js/lightcase.js""></script>

    <script src=""assets/js/wow.min.js""></script>

    <script src=""assets/js/jquery.nice-select.min.js""></script>

    <script src=""assets/js/datepicker.min.js""></script>
    <script src=""assets/js/datepicker.en.js""></script>

    <script src=""assets/js/wickedpicker.min.js""></script>

    <script src=""assets/js/owl.carousel.min.js""></script>

    <script src=""assets/js/jquery-ui.min.js""></script>

    <script src=""assets/js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
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
