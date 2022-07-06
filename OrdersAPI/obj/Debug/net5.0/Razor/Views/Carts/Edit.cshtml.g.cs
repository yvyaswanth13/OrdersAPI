#pragma checksum "C:\Users\Admin\source\repos\OrdersAPI\OrdersAPI\Views\Carts\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e21e7755c1041e833e81558f34384dd66e987b1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Edit), @"mvc.1.0.view", @"/Views/Carts/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21e7755c1041e833e81558f34384dd66e987b1d", @"/Views/Carts/Edit.cshtml")]
    public class Views_Carts_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdersAPI.Models.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\OrdersAPI\OrdersAPI\Views\Carts\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Cart</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class=""form-control"" asp-items=""ViewBag.UserId""></select>
                <span asp-validation-for=""UserId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductId"" class=""control-label""></label>
                <select asp-for=""ProductId"" class=""form-control"" asp-items=""ViewBag.ProductId""></select>
                <span asp-validation-for=""ProductId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quantity"" class=""control-label""></label>
                <input asp-fo");
            WriteLiteral(@"r=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SubTotal"" class=""control-label""></label>
                <input asp-for=""SubTotal"" class=""form-control"" />
                <span asp-validation-for=""SubTotal"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IsSelectedForOrder"" class=""control-label""></label>
                <input asp-for=""IsSelectedForOrder"" class=""form-control"" />
                <span asp-validation-for=""IsSelectedForOrder"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OfferId"" class=""control-label""></label>
                <input asp-for=""OfferId"" class=""form-control"" />
                <span asp-validation-for=""OfferId"" class=""text-danger""></span>
            </div>
            <div c");
            WriteLiteral("lass=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Admin\source\repos\OrdersAPI\OrdersAPI\Views\Carts\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdersAPI.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591