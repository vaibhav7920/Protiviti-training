#pragma checksum "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7944fd6414c773c9777187f2d60c22a472f3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\_ViewImports.cshtml"
using DIDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\_ViewImports.cshtml"
using DIDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7944fd6414c773c9777187f2d60c22a472f3c7", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6be2cc6c4998bd97717b3e6d74d880905f4c7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DIDemo.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layoutdemo.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Customer ID</th>\r\n            <th>Customer </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml"
           Write(item.custid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml"
           Write(item.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\vaipar01\OneDrive - Robert Half\Desktop\UI-July\Dotnet\DIDemo\DIDemo\Views\Customer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DIDemo.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
