#pragma checksum "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58542853a12834ec3d851dd52c9c6b4b0e863c16"
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
#line 1 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58542853a12834ec3d851dd52c9c6b4b0e863c16", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2f008bb030c689fdd92cf0ac6c09ff2675aa17", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment2.Models.Test>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TheoryMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PracticeMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AssignmentMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TheoryMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PracticeMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssignmentMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 45 "E:\WorkSpace\mvc\Assignment2\Assignment2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment2.Models.Test>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591