#pragma checksum "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Views\Shared\NotFoundError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dfe7e141ce85ab895884a819643d285deb572b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NotFoundError), @"mvc.1.0.view", @"/Views/Shared/NotFoundError.cshtml")]
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
#line 1 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Views\_ViewImports.cshtml"
using TravelPointSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Views\_ViewImports.cshtml"
using TravelPointSystem.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfe7e141ce85ab895884a819643d285deb572b4", @"/Views/Shared/NotFoundError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051f16ba2eb8244e0f699cf8bd5e78c980024597", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NotFoundError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Views\Shared\NotFoundError.cshtml"
  
    ViewData["Title"] = "Not Found Error 404";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"align-items-center text-center four-zero-four\">\r\n    <div class=\"my-5 h1 four-zero-four-title\">\r\n        Ooops...");
#nullable restore
#line 8 "D:\Programming\Темп\TravelPointSystem\Web\TravelPointSystem.Web\Views\Shared\NotFoundError.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""four-zero-four-bg"">
    </div>
    <div class=""four-zero-four-text"">
        <h2>
            Look like you're lost
        </h2>
        <p>The page you are looking for not avaible!</p>
        <a href=""/"" class=""btn btn-secondary btn-lg active"">Go to Home</a>
    </div>
</div>










");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591