#pragma checksum "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4d2b24ce670cc3bcfdb1cab5d29ca5e8f97b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Flights_Delete), @"mvc.1.0.view", @"/Areas/Administration/Views/Flights/Delete.cshtml")]
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
#line 1 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\_ViewImports.cshtml"
using TravelPointSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\_ViewImports.cshtml"
using TravelPointSystem.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4d2b24ce670cc3bcfdb1cab5d29ca5e8f97b5d", @"/Areas/Administration/Views/Flights/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"739bdcbe1636f34f91948168df4ab424622d44ef", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Flights_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelPointSystem.Web.ViewModels.Flights.FlightViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center mt-5 mb-3 h1\">");
#nullable restore
#line 7 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
                                 Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"text-center mt-5 mb-3 h3\">Are you sure you want to delete this?</div>\r\n\r\n<div>\r\n    <h4>Flight</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerPerson));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 24 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
        Write(Html.DisplayFor(model => model.PricePerPerson));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Company.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartureDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepartureDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlightTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartPoint.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 48 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
                                                         Write(Html.DisplayFor(model => model.StartPoint.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartPointAirPort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartPointAirPort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndPoint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndPoint.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  ");
#nullable restore
#line 60 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
                                                        Write(Html.DisplayFor(model => model.EndPoint.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndPointAirPort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndPointAirPort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReservationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReservationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4d2b24ce670cc3bcfdb1cab5d29ca5e8f97b5d15116", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf4d2b24ce670cc3bcfdb1cab5d29ca5e8f97b5d15383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 95 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Areas\Administration\Views\Flights\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger px-5\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelPointSystem.Web.ViewModels.Flights.FlightViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
