#pragma checksum "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Account\CompleteForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d1a198b1ea26a3c59936abca755c508b0ef3df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CompleteForgotPassword), @"mvc.1.0.view", @"/Views/Account/CompleteForgotPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d1a198b1ea26a3c59936abca755c508b0ef3df", @"/Views/Account/CompleteForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc327b683a16f71791063a3c77ecc31f011299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CompleteForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mohamed\source\repos\Comapny-Website-ASP.NET-5-MVC\Presentaion_Layer\Views\Account\CompleteForgotPassword.cshtml"
  
    ViewData["Title"] = "CompleteForgotPassword";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""fp-box"">
        <div class=""logo"">
            <a href=""javascript:void(0);"">Admin<b>BSB</b></a>
            <small>Please Check Your Inbox</small>
        </div>
        <div class=""card"">
            <div class=""body"">
                    <div class=""msg"">
                        An Email with the reset instructions was sent to your inbox. please follow the link below to complete 
                        resetting your password.
                    </div>

                    <div class=""row m-t-20 m-b--5 align-center"">
                        <a href=""https://mail.google.com/mail/u/0/#inbox"">Go To Inbox!</a>
                    </div>
            </div>
        </div>
    </div>

");
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
