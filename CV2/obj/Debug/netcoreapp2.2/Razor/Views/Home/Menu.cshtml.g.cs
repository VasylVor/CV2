#pragma checksum "D:\My projects\CV2\CV2\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8996317ccb6c1d83a6e481cd3dd57dfb42e4edc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Menu.cshtml", typeof(AspNetCore.Views_Home_Menu))]
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
#line 1 "D:\My projects\CV2\CV2\Views\_ViewImports.cshtml"
using CV2;

#line default
#line hidden
#line 2 "D:\My projects\CV2\CV2\Views\_ViewImports.cshtml"
using CV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8996317ccb6c1d83a6e481cd3dd57dfb42e4edc9", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f2ae02a755f66869e106e066c32850f4b6dfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Section>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 261, true);
            WriteLiteral(@"
<a href=""#"" class=""logo"">VVS</a>
<ul>
    <li><a href=""#Main"">Main</a></li>
    <li><a href=""#Skils"">Skills</a></li>
    <li><a href=""#Project"">Project</a></li>
    <li><a href=""#Works"">Works</a></li>
    <li><a href=""#Contacts"">Contacts</a></li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Section> Html { get; private set; }
    }
}
#pragma warning restore 1591
