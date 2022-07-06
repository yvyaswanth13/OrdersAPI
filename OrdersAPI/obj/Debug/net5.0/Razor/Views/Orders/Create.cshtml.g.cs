#pragma checksum "C:\Users\Admin\source\repos\OrdersAPI\OrdersAPI\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842af0752c605a32f1783bf6095cb0316926822e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Create), @"mvc.1.0.view", @"/Views/Orders/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842af0752c605a32f1783bf6095cb0316926822e", @"/Views/Orders/Create.cshtml")]
    public class Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdersAPI.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\OrdersAPI\OrdersAPI\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Order</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class =""form-control"" asp-items=""ViewBag.UserId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""DistinctItems"" class=""control-label""></label>
                <input asp-for=""DistinctItems"" class=""form-control"" />
                <span asp-validation-for=""DistinctItems"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TotalAmount"" class=""control-label""></label>
                <input asp-for=""TotalAmount"" class=""form-control"" />
                <span asp-validation-for=""TotalAmount"" class=""text-danger""></span>
            </div>
 ");
            WriteLiteral(@"           <div class=""form-group"">
                <label asp-for=""PaymentType"" class=""control-label""></label>
                <input asp-for=""PaymentType"" class=""form-control"" />
                <span asp-validation-for=""PaymentType"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PaymentId"" class=""control-label""></label>
                <input asp-for=""PaymentId"" class=""form-control"" />
                <span asp-validation-for=""PaymentId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OfferId"" class=""control-label""></label>
                <select asp-for=""OfferId"" class =""form-control"" asp-items=""ViewBag.OfferId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderedOn"" class=""control-label""></label>
                <input asp-for=""OrderedOn"" class=""form-control"" />
                <span asp-validation-f");
            WriteLiteral(@"or=""OrderedOn"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IsCancelled"" class=""control-label""></label>
                <input asp-for=""IsCancelled"" class=""form-control"" />
                <span asp-validation-for=""IsCancelled"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeliveryDate"" class=""control-label""></label>
                <input asp-for=""DeliveryDate"" class=""form-control"" />
                <span asp-validation-for=""DeliveryDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderStatus"" class=""control-label""></label>
                <input asp-for=""OrderStatus"" class=""form-control"" />
                <span asp-validation-for=""OrderStatus"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" ");
            WriteLiteral("class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\Admin\source\repos\OrdersAPI\OrdersAPI\Views\Orders\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdersAPI.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
