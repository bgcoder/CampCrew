#pragma checksum "C:\Users\the_f\git-projects\CampCrew\Views\Home\Trips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd78f0e85a54f2ccbb8f37ada6f62089cbfa5700"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Trips), @"mvc.1.0.view", @"/Views/Home/Trips.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Trips.cshtml", typeof(AspNetCore.Views_Home_Trips))]
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
#line 1 "C:\Users\the_f\git-projects\CampCrew\Views\_ViewImports.cshtml"
using CampCrew;

#line default
#line hidden
#line 2 "C:\Users\the_f\git-projects\CampCrew\Views\_ViewImports.cshtml"
using CampCrew.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd78f0e85a54f2ccbb8f37ada6f62089cbfa5700", @"/Views/Home/Trips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acfae4390d26b94cf2fce73d863a63ffde5bafdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Trips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\the_f\git-projects\CampCrew\Views\Home\Trips.cshtml"
  
    ViewData["Title"] = "Trips";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\the_f\git-projects\CampCrew\Views\Home\Trips.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\Users\the_f\git-projects\CampCrew\Views\Home\Trips.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 538, true);
            WriteLiteral(@"</h3>

<p>This is the information gateway for a group of friends to discuss, plan, and prepare for various camping trips, 
river trips, hunting trips, and various other outdoor activities.
</p><br>
<p>Any member here will be allowed to begin a discussion, schedule an event, and create lists for items 
that need to be brought for an event.</p><br><br>
<p>Since This site is designed and developed by one individual with a limited vision in mind, please feel free
to offer suggestions for how the site may be improved. Cheers.</p>");
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
