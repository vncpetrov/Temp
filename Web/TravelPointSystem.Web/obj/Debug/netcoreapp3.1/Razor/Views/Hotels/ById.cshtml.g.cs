#pragma checksum "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c80ddf116ed6ae4fc6c59f9fad79837c49615bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotels_ById), @"mvc.1.0.view", @"/Views/Hotels/ById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c80ddf116ed6ae4fc6c59f9fad79837c49615bc", @"/Views/Hotels/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051f16ba2eb8244e0f699cf8bd5e78c980024597", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotels_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelPointSystem.Web.ViewModels.Hotels.HotelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
  
    this.ViewData["Title"] = Model.Name;
    string starSymbol = "\u2B50";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-4\">\r\n\r\n    <!--Grid column-->\r\n    <div class=\"col-md-6 mb-4\">\r\n\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 267, 1);
#nullable restore
#line 12 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
WriteAttributeValue("", 252, Model.ImageUrl, 252, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 286, "\"", 292, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    </div>\r\n    <!--Grid column-->\r\n    <!--Grid column-->\r\n    <div class=\"col-md-6 mb-4\">\r\n\r\n        <!--Content-->\r\n        <div class=\"p-4\">\r\n            <div class=\"mb-3 h1\">");
#nullable restore
#line 21 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                            Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 21 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                                                          Write(string.Concat(Enumerable.Repeat(starSymbol, Model.Stars)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            <p class=\"lead\">\r\n                <span>$");
#nullable restore
#line 23 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                  Write(Model.PricePerNightPerPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <i class=\"fa fa-user\"></i></span>\r\n            </p>\r\n\r\n            <p class=\"lead font-weight-bold\">\r\n                Board: <span class=\"lead font-weight-normal\">");
#nullable restore
#line 27 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                                                        Write(Model.FeedingType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n\r\n            <p class=\"lead font-weight-bold\">\r\n                Available Rooms: <span class=\"lead font-weight-normal\">");
#nullable restore
#line 31 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                                                                  Write(Model.AvailableRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n\r\n            <p class=\"lead font-weight-bold\">\r\n                Address: <span class=\"lead font-weight-normal\">");
#nullable restore
#line 35 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                                                          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n\r\n            <p class=\"lead font-weight-bold\">Description</p>\r\n\r\n            <p>\r\n                ");
#nullable restore
#line 41 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p class=\"d-flex justify-content-center\">\r\n");
#nullable restore
#line 45 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                 if (Model.AvailableRooms == 0 || Model.AvailableRooms < (Model.NumberOfTourists / 2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-primary disabled\">No rooms</a>\r\n");
#nullable restore
#line 48 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c80ddf116ed6ae4fc6c59f9fad79837c49615bc8563", async() => {
                WriteLiteral("Book");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reservationType", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                                                                                                                       WriteLiteral(Model.ReservationType);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservationType"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reservationType", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservationType"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                                                                                                                                                             WriteLiteral(Model.Id.ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
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
#line 52 "D:\Programming\Темп\Local\Temp\Web\TravelPointSystem.Web\Views\Hotels\ById.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </div>\r\n        <!--Content-->\r\n\r\n    </div>\r\n    <!--Grid column-->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelPointSystem.Web.ViewModels.Hotels.HotelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
