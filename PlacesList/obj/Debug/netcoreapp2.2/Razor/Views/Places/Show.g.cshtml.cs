#pragma checksum "/Users/Guest/Desktop/places-solution/PlacesList/Views/Places/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f34d3932e055cf7b21017cd14becf1280343d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Places_Show), @"mvc.1.0.view", @"/Views/Places/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Places/Show.cshtml", typeof(AspNetCore.Views_Places_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f34d3932e055cf7b21017cd14becf1280343d9", @"/Views/Places/Show.cshtml")]
    public class Views_Places_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<h1>All the places I\'ve been!</h1>\n\n<h2>");
            EndContext();
            BeginContext(41, 19, false);
#line 3 "/Users/Guest/Desktop/places-solution/PlacesList/Views/Places/Show.cshtml"
Write(Model.GetCityName());

#line default
#line hidden
            EndContext();
            BeginContext(60, 15, true);
            WriteLiteral("</h2> <br>\n<h4>");
            EndContext();
            BeginContext(76, 23, false);
#line 4 "/Users/Guest/Desktop/places-solution/PlacesList/Views/Places/Show.cshtml"
Write(Model.GetDateTraveled());

#line default
#line hidden
            EndContext();
            BeginContext(99, 15, true);
            WriteLiteral("</h4> <br>\n<h4>");
            EndContext();
            BeginContext(115, 23, false);
#line 5 "/Users/Guest/Desktop/places-solution/PlacesList/Views/Places/Show.cshtml"
Write(Model.GetTraveledWith());

#line default
#line hidden
            EndContext();
            BeginContext(138, 15, true);
            WriteLiteral("</h4> <br>\n<h4>");
            EndContext();
            BeginContext(154, 18, false);
#line 6 "/Users/Guest/Desktop/places-solution/PlacesList/Views/Places/Show.cshtml"
Write(Model.GetJournal());

#line default
#line hidden
            EndContext();
            BeginContext(172, 94, true);
            WriteLiteral("</h4> \n\n<a href=\"/places/new\">Add another place</a>\n<a href=\"/places\">View all the places</a>\n");
            EndContext();
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