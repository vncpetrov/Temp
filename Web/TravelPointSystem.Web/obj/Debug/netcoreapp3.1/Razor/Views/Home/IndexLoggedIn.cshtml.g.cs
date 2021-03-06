#pragma checksum "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2600d1d3d05adbc67cfa3a9b68dcc83902a57c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexLoggedIn), @"mvc.1.0.view", @"/Views/Home/IndexLoggedIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2600d1d3d05adbc67cfa3a9b68dcc83902a57c", @"/Views/Home/IndexLoggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051f16ba2eb8244e0f699cf8bd5e78c980024597", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexLoggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelPointSystem.Web.ViewModels.Home.IndexLoggedInViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
  
    this.ViewData["Title"] = "Workplace";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center mt-5 mb-3 h1\">Welcome to ");
#nullable restore
#line 7 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                            Write(Model.CurrentUser.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                                           Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""row my-5 d-flex justify-content-center"">
    <div class=""col-md-11"">
        <table class=""table"">
            <thead>
                <tr class=""bg-info text-white"">
                    <th scope=""col"">Reservation ID</th>
                    <th scope=""col"">Reservation Date</th>
                    <th scope=""col"">Reservation For</th>
                    <th scope=""col"">Passenger</th>
                    <th scope=""col"">Destination</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                 foreach (var reservation in Model.Reservations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 28 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                   Write(reservation.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 29 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                       Write(reservation.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 31 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                             if (reservation.ReservationType.ToString() == "Hotel")
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                            Write("Hotel: " + reservation.Hotel.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                                     ;
                            }
                            else if (reservation.ReservationType.ToString() == "OrganizedTrip")
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                            Write("Organized Trip: " + reservation.OrganizedTrip.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                                                      ;
                            }
                            else if (reservation.ReservationType.ToString() == "Bus")
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                            Write("Bus: " + reservation.Bus.BusNumber);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                                      ;
                            }
                            else if (reservation.ReservationType.ToString() == "Flight")
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                            Write("Flight: " + reservation.Flight.FlightNumber);

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                                               ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 48 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                       Write(reservation.Tourists.FirstOrDefault().FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                       Write(reservation.Destination.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 49 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                      Write(reservation.Destination.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>$");
#nullable restore
#line 50 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                        Write(reservation.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 52 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                             if (reservation.IsAccepted)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-success\">Accepted</span>\r\n");
#nullable restore
#line 55 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-danger\">Not Accepted</span>\r\n");
#nullable restore
#line 59 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f2600d1d3d05adbc67cfa3a9b68dcc83902a57c11937", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                                                                                                              WriteLiteral(reservation.Id);

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
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Home\IndexLoggedIn.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelPointSystem.Web.ViewModels.Home.IndexLoggedInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
