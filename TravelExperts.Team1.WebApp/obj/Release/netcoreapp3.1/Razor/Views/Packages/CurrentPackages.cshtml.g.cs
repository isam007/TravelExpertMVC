#pragma checksum "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22310dee5cff80516e9dc551cc7b78a58d501f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_CurrentPackages), @"mvc.1.0.view", @"/Views/Packages/CurrentPackages.cshtml")]
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
#line 1 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\_ViewImports.cshtml"
using TravelExperts.Team1.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\_ViewImports.cshtml"
using TravelExperts.Team1.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22310dee5cff80516e9dc551cc7b78a58d501f78", @"/Views/Packages/CurrentPackages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f911707156a0e4cca98190738059f00d09efcdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_CurrentPackages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelExperts.Team1.WebApp.Models.PackagesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
  
    ViewData["Title"] = "Current Packages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center text-sm-center text-md-center text-lg-center text-xl-center\">Book the Trip of Your Dream! </h1>\r\n<br />\r\n<hr />\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4 col-sm-6\">\r\n        <div class=\"animation-element slide-up\">\r\n            <div class=\"card\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22310dee5cff80516e9dc551cc7b78a58d501f784852", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 493, "~/img/", 493, 6, true);
#nullable restore
#line 17 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
AddHtmlAttributeValue("", 499, Html.DisplayFor(modelItem => item.PkgImage), 499, 46, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 545, ".jpg", 545, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
AddHtmlAttributeValue("", 556, Html.DisplayFor(modelItem => item.PkgImage), 556, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body lightcolor\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.PkgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text price\"><strong>");
#nullable restore
#line 20 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.PkgTotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 20 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                                                                                                               Write(Html.DisplayFor(modelItem => item.PkgTotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.PkgDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text dates\">\r\n                        <strong>");
#nullable restore
#line 23 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                           Write(Html.DisplayNameFor(model => model.PkgStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 23 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                                                                                       Write(Html.DisplayFor(modelItem => item.PkgStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <strong>");
#nullable restore
#line 24 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                           Write(Html.DisplayNameFor(model => model.PkgEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 24 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.PkgEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""form-group right-align"">
                    <input type=""submit"" value=""Pick me!"" class=""btn btn-primary"" />
                </div>
            </div>
            <br />
        </div>
    </div>
");
#nullable restore
#line 34 "C:\Users\JunioTech\Documents\Training\SAIT_Webdev\TravelExpertFinal\TravelExpertMVC\travel-experts\travel-experts\TravelExperts.Team1.WebApp\Views\Packages\CurrentPackages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelExperts.Team1.WebApp.Models.PackagesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
