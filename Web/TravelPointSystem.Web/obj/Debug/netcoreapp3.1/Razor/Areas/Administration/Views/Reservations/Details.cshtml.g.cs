#pragma checksum "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c257973baf2833f8f9ef2c5721c85feb80cde496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Reservations_Details), @"mvc.1.0.view", @"/Areas/Administration/Views/Reservations/Details.cshtml")]
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
#line 1 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\_ViewImports.cshtml"
using TravelPointSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\_ViewImports.cshtml"
using TravelPointSystem.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c257973baf2833f8f9ef2c5721c85feb80cde496", @"/Areas/Administration/Views/Reservations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"739bdcbe1636f34f91948168df4ab424622d44ef", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Reservations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelPointSystem.Web.ViewModels.Reservations.ReservationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("check-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center mt-5 mb-3 h1\">");
#nullable restore
#line 7 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                 Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    <h4>Reservation <span class=\"badge badge-pill badge-primary font-weight-light\">");
#nullable restore
#line 10 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Creator.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 19 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
         if (Model.ReservationType.ToString() == "Bus")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Bus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Bus.BusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Bus.StartPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Bus.StartPoint.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 31 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Bus.StartPoint.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 33 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        }
        else if (Model.ReservationType.ToString() == "Flight")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 37 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Flight.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 43 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight.StartPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 46 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Flight.StartPoint.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 46 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                    Write(Html.DisplayFor(model => model.Flight.StartPoint.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 48 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        }
        else if (Model.ReservationType.ToString() == "Hotel")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 55 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 58 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 61 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Destination.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 61 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                    Write(Html.DisplayFor(model => model.Hotel.Destination.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 63 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        }
        else if (Model.ReservationType.ToString() == "OrganizedTrip")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 67 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OrganizedTrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 70 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.OrganizedTrip.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 73 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OrganizedTrip.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 76 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.OrganizedTrip.Destination.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 76 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                            Write(Html.DisplayFor(model => model.OrganizedTrip.Destination.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 78 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 85 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
         if (Model.ReservationType.ToString() != "Bus" && Model.ReservationType.ToString() != "Flight")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 88 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Return));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 91 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
           Write(Html.DisplayFor(model => model.Return));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 93 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c257973baf2833f8f9ef2c5721c85feb80cde49618342", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 95 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 98 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c257973baf2833f8f9ef2c5721c85feb80cde49620210", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 101 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Balance);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 104 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        Write(Model.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c257973baf2833f8f9ef2c5721c85feb80cde49622084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 107 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsAccepted);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c257973baf2833f8f9ef2c5721c85feb80cde49623629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 110 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsAccepted);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tourists));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 133 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
         for (int i = 0; i < Model.Tourists.Count(); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
   Write(Html.DisplayFor(model => model.Tourists[i].FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.Tourists[i].PersonalNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                                                                           Write(Html.DisplayFor(model => model.Tourists[i].PersonalNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                                                                                                                                        Write(Html.DisplayNameFor(model => model.Tourists[i].PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                                                                                                                                                                                                         Write(Html.DisplayFor(model => model.Tourists[i].PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                                                                                                                                                                                                                                                                      Write(Html.DisplayNameFor(model => model.Tourists[i].PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 136 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                    Write(Html.DisplayFor(model => model.Tourists[i].PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n");
#nullable restore
#line 138 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c257973baf2833f8f9ef2c5721c85feb80cde49632084", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Areas\Administration\Views\Reservations\Details.cshtml"
                                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelPointSystem.Web.ViewModels.Reservations.ReservationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
