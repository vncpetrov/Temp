#pragma checksum "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa05ae7895140b7f792c5b73585575e413719b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buses_AllByDestinationsId), @"mvc.1.0.view", @"/Views/Buses/AllByDestinationsId.cshtml")]
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
#line 1 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\_ViewImports.cshtml"
using TravelPointSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\_ViewImports.cshtml"
using TravelPointSystem.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa05ae7895140b7f792c5b73585575e413719b0a", @"/Views/Buses/AllByDestinationsId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051f16ba2eb8244e0f699cf8bd5e78c980024597", @"/Views/_ViewImports.cshtml")]
    public class Views_Buses_AllByDestinationsId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelPointSystem.Web.ViewModels.Buses.BusesByDestinationsIdListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
  
    this.ViewData["Title"] = "Buses";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center mt-5 mb-3 h1\">");
#nullable restore
#line 6 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                 Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" from ");
#nullable restore
#line 6 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                              Write(Model.Buses.FirstOrDefault().StartPoint.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 6 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                                                                               Write(Model.Buses.FirstOrDefault().EndPoint.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row mx-5\">\r\n");
#nullable restore
#line 9 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
     foreach (var bus in Model.Buses)
    {
        var arriveDateTime = bus.DepartureDateTime.Add(bus.TravellingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-12 my-5\">\r\n            <div class=\"card border border-info\">\r\n                <div class=\"card-header bg-info text-white\">\r\n                    <h4 class=\"text-center\">Bus Number: ");
#nullable restore
#line 15 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                   Write(bus.BusNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"card-body d-flex justify-content-around align-items-center\">\r\n                    <div class=\"d-inline-block\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 19 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                          Write(bus.StartPoint.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 20 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                        Write(bus.StartPointStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Departure At: ");
#nullable restore
#line 21 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                      Write(bus.DepartureDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"d-inline-block\">\r\n                        <h1 class=\"card-title text-center\">&rarr;</h1>\r\n                        <p class=\"card-text\">Travelling Time: ");
#nullable restore
#line 25 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                         Write(bus.TravellingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Available Seats: ");
#nullable restore
#line 26 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                         Write(bus.AvailableSeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"d-inline-block\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 29 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                          Write(bus.EndPoint.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 30 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                        Write(bus.EndPointStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Arrive At: ");
#nullable restore
#line 31 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                   Write(arriveDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"d-inline-block border border-info rounded py-4 px-5 text-center\">\r\n                        <h5 class=\"card-title\">Price</h5>\r\n                        <p class=\"card-text\">$");
#nullable restore
#line 35 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                         Write(bus.PricePerPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-user\"></i></p>\r\n");
#nullable restore
#line 36 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                         if (bus.AvailableSeats == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-primary disabled\">No Seats</a>\r\n");
#nullable restore
#line 39 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa05ae7895140b7f792c5b73585575e413719b0a11119", async() => {
                WriteLiteral("Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reservationType", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                                                                                                           WriteLiteral(bus.ReservationType);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservationType"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reservationType", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservationType"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                                                                                                                                               WriteLiteral(bus.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                                                                                                                                                                                                                    WriteLiteral(Model.NumberOfTourists);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numberOfTourists"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numberOfTourists", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numberOfTourists"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 48 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Buses\AllByDestinationsId.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelPointSystem.Web.ViewModels.Buses.BusesByDestinationsIdListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
