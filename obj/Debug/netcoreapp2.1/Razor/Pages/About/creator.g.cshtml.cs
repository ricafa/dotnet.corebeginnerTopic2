#pragma checksum "C:\Users\ricardo\projetos\dotnet\mva\mywebapp\Pages\About\creator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ebe85000b8c84b75c35043e8d1b17b820cd7ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_About_creator), @"mvc.1.0.razor-page", @"/Pages/About/creator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About/creator.cshtml", typeof(AspNetCore.Pages_About_creator), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ebe85000b8c84b75c35043e8d1b17b820cd7ae", @"/Pages/About/creator.cshtml")]
    public class Pages_About_creator : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 29, true);
            WriteLiteral("\r\nRicardo\r\n<br/>\r\nCreated at ");
            EndContext();
            BeginContext(37, 12, false);
#line 5 "C:\Users\ricardo\projetos\dotnet\mva\mywebapp\Pages\About\creator.cshtml"
      Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(49, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 7 "C:\Users\ricardo\projetos\dotnet\mva\mywebapp\Pages\About\creator.cshtml"
  
    var sum = 2+2;

#line default
#line hidden
            BeginContext(86, 15, true);
            WriteLiteral("math way with: ");
            EndContext();
            BeginContext(102, 3, false);
#line 10 "C:\Users\ricardo\projetos\dotnet\mva\mywebapp\Pages\About\creator.cshtml"
          Write(sum);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_About_creator> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About_creator> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About_creator>)PageContext?.ViewData;
        public Pages_About_creator Model => ViewData.Model;
    }
}
#pragma warning restore 1591
