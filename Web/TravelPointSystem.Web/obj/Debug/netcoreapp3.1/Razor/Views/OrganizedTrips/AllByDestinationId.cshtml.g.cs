#pragma checksum "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab9b3eeb5a8f140f548b848da883634cd23fce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrganizedTrips_AllByDestinationId), @"mvc.1.0.view", @"/Views/OrganizedTrips/AllByDestinationId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab9b3eeb5a8f140f548b848da883634cd23fce1", @"/Views/OrganizedTrips/AllByDestinationId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051f16ba2eb8244e0f699cf8bd5e78c980024597", @"/Views/_ViewImports.cshtml")]
    public class Views_OrganizedTrips_AllByDestinationId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelPointSystem.Web.ViewModels.OrganizedTrips.OrganizedTripsByDestinationIdListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
  
    this.ViewData["Title"] = "Organized Trips in";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center mt-5 mb-3 h1\">");
#nullable restore
#line 6 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                    Write(Model.OrganizedTrips.FirstOrDefault().Destination.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 6 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                                                                             Write(Model.OrganizedTrips.FirstOrDefault().Destination.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row d-flex justify-content-evenly ml-5\">\r\n");
#nullable restore
#line 9 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
     foreach (var trip in this.Model.OrganizedTrips)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 my-5\">\r\n            <div class=\"card\" style=\"width: 17rem;\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 568, "", 587, 1);
#nullable restore
#line 13 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
WriteAttributeValue("", 573, trip.ImageUrl, 573, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" id=\"card-img-cover\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 15 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                      Write(trip.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Destination: ");
#nullable restore
#line 16 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                 Write(trip.Destination.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 16 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                                             Write(trip.Destination.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\">Transport: ");
#nullable restore
#line 19 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                      Write(trip.Transport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">Price: $");
#nullable restore
#line 20 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                   Write(trip.PricePerPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n                <div class=\"card-body d-flex justify-content-between\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab9b3eeb5a8f140f548b848da883634cd23fce19099", async() => {
                WriteLiteral("View more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                                           WriteLiteral(trip.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
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
#line 24 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                     if (trip.AvailableSeats == 0 || trip.AvailableSeats < Model.NumberOfTourists)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"btn btn-primary disabled\">No Seats</a>\r\n");
#nullable restore
#line 27 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab9b3eeb5a8f140f548b848da883634cd23fce112975", async() => {
                WriteLiteral("Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reservationType", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                                                                                    WriteLiteral(trip.ReservationType);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservationType"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reservationType", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservationType"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                                                                                                                                                         WriteLiteral(trip.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
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
#line 31 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 35 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\OrganizedTrips\AllByDestinationId.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelPointSystem.Web.ViewModels.OrganizedTrips.OrganizedTripsByDestinationIdListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
