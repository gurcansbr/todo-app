#pragma checksum "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Shared\_Leftbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf1ef03c77d3d4f028be4f9c4bb3fc0fafff61f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Leftbar), @"mvc.1.0.view", @"/Views/Shared/_Leftbar.cshtml")]
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
#line 1 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\_ViewImports.cshtml"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\_ViewImports.cshtml"
using TodoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf1ef03c77d3d4f028be4f9c4bb3fc0fafff61f", @"/Views/Shared/_Leftbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11405023e71b4984b21d108cf68c11a8d007b906", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Leftbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""sidebar-sticky"">
    <ul class=""nav flex-column"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/"">
                Show All <span class=""sr-only""></span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/todo/index/1"">
                Show Only Completed <span class=""sr-only""></span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/todo/add"">
                Add New Todo Item <span class=""sr-only""></span>
            </a>
        </li>
    </ul>
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
