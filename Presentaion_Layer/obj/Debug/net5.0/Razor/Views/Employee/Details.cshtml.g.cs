#pragma checksum "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94274c8b3b7083067d817ec291ada0707099efd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\_ViewImports.cshtml"
using Presentaion_Layer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\_ViewImports.cshtml"
using Data_Access_Layer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\_ViewImports.cshtml"
using Presentaion_Layer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\_ViewImports.cshtml"
using Business_Logic_Layer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94274c8b3b7083067d817ec291ada0707099efd0", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c906f73649c4a1af9562c7e78ee4c53e0e1e32b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-pill-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString("download"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Details";
    string DeptName = ViewData["DeptName"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 13 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 14 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 17 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 18 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 21 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 22 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 25 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 26 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 29 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 30 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 33 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 34 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n     <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 37 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94274c8b3b7083067d817ec291ada0707099efd012415", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1396, "~/files/Imgs/", 1396, 13, true);
#nullable restore
#line 38 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
AddHtmlAttributeValue("", 1409, Model.ImgName, 1409, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n    </div>  \r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 43 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.CV));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94274c8b3b7083067d817ec291ada0707099efd014676", async() => {
                WriteLiteral("Open CV");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1648, "~/files/CVs/", 1648, 12, true);
#nullable restore
#line 44 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
AddHtmlAttributeValue("", 1660, Model.CVName, 1660, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94274c8b3b7083067d817ec291ada0707099efd016412", async() => {
                WriteLiteral("Download CV");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1746, "~/files/CVs/", 1746, 12, true);
#nullable restore
#line 45 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
AddHtmlAttributeValue("", 1758, Model.CVName, 1758, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div> \r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 50 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.DepartmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 51 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94274c8b3b7083067d817ec291ada0707099efd018876", async() => {
                WriteLiteral("Return to Employees");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
