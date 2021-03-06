#pragma checksum "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0452751852f8079382ba1db653ecaa33df110e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0452751852f8079382ba1db653ecaa33df110e5", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11405023e71b4984b21d108cf68c11a8d007b906", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-10\">\r\n    <div class=\"jumbotron\">\r\n");
#nullable restore
#line 8 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
         if (TempData["success"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success\">\r\n                ");
#nullable restore
#line 11 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
           Write(TempData["success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 13 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
         if (TempData["error"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                ");
#nullable restore
#line 17 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
           Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Todo Items</h3>\r\n");
#nullable restore
#line 21 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
         if (Model.Todos.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"list-unstyled mt-3\">\r\n");
#nullable restore
#line 24 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                 foreach (var todo in Model.Todos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n");
#nullable restore
#line 27 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                         if (todo.IsCompleted)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-success\"><i class=\"fa fa-check\"></i></span>\r\n");
#nullable restore
#line 30 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-danger\"><i class=\"fa fa-times\"></i></span>\r\n");
#nullable restore
#line 34 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label");
            BeginWriteAttribute("class", " class=\"", 1094, "\"", 1102, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1103, "\"", 1122, 1);
#nullable restore
#line 36 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1111, todo.Title, 1111, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                                                       Write(todo.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> -\r\n                        <label");
            BeginWriteAttribute("class", " class=\"", 1177, "\"", 1185, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1186, "\"", 1211, 1);
#nullable restore
#line 37 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1194, todo.Description, 1194, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                                                              Write(todo.Description.Length > 35 ? todo.Description.Substring(0, 32) + "..." : todo.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> -\r\n                        ");
#nullable restore
#line 38 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                   Write(todo.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"float-right\">\r\n");
#nullable restore
#line 40 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                             if (todo.IsCompleted == false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1534, "\"", 1564, 2);
            WriteAttributeValue("", 1541, "/todo/complete/", 1541, 15, true);
#nullable restore
#line 42 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1556, todo.Id, 1556, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-success\" data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 1650, "\"", 1658, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Complete Task\"><i class=\"fa fa-check\"></i></a>\r\n");
#nullable restore
#line 43 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1790, "\"", 1818, 2);
            WriteAttributeValue("", 1797, "/todo/update/", 1797, 13, true);
#nullable restore
#line 44 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1810, todo.Id, 1810, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-info\" data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 1901, "\"", 1909, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Update Task\"><i class=\"fa fa-edit\"></i></a>\r\n                            <button class=\"btn btn-sm btn-outline-danger delete-button\" data-todo=\"");
#nullable restore
#line 45 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                                                                                              Write(todo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 2131, "\"", 2139, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Delete Task\"><i class=\"fa fa-times\"></i></button>\r\n                        </div>\r\n                    </li>\r\n                    <hr />\r\n");
#nullable restore
#line 49 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 51 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\">There is no any todos. You can add by clicking <a href=\"/todo/add\"");
            BeginWriteAttribute("class", " class=\"", 2485, "\"", 2493, 0);
            EndWriteAttribute();
            WriteLiteral(">this</a></div>\r\n");
#nullable restore
#line 55 "C:\Users\gurca\source\repos\TodoList\TodoList\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Todo Item</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Do you want to delete todo item?</p>
            </div>
            <div class=""modal-footer"">
                <a id=""deleteInModal""");
            BeginWriteAttribute("href", " href=\"", 3197, "\"", 3204, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"">Delete</a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""errorModal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Error</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Some error(s) accured!</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">OK</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('.delete-button').click(function () {
            console.log(""tet"")
            var todo = $(this).data('todo');
            if (todo) {
                $('#deleteInModal').attr('href', '/todo/delete/' + todo);
                $('#deleteModal').modal('show');
            }
            else {
                $('#errorModal').modal('show');
            }
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
