#pragma checksum "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99919ef9f7e71f2bd554726cd13a6a88d113c316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Create), @"mvc.1.0.view", @"/Views/Movies/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99919ef9f7e71f2bd554726cd13a6a88d113c316", @"/Views/Movies/Create.cshtml")]
    public class Views_Movies_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>Movie</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 13 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
         using (Html.BeginForm("Create", "Movies", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"Title\" class=\"control-label\">Title</label>\r\n                ");
#nullable restore
#line 20 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Title, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span asp-validation-for=\"Title\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"ReleaseDate\" class=\"control-label\">Release Date</label>\r\n                ");
#nullable restore
#line 25 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
           Write(Html.TextBoxFor(model => model.ReleaseDate, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span asp-validation-for=\"ReleaseDate\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"Genre\" class=\"control-label\">Genre</label>\r\n                ");
#nullable restore
#line 30 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Genre, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span asp-validation-for=\"Genre\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"Price\" class=\"control-label\">Price</label>\r\n\r\n                ");
#nullable restore
#line 36 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Price, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span asp-validation-for=\"Price\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\gurpreet.singh\source\repos\ConsoleApp3\WebApplication1\Views\Movies\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
