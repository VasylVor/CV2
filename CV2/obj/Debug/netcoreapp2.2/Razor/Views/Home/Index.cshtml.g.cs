#pragma checksum "D:\My projects\CV2\CV2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f2ae02a755f66869e106e066c32850f4b6dfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/512px-.NET_Core_Logo.svg.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contatct-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\My projects\CV2\CV2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(66, 5600, true);
            WriteLiteral(@"
<div id=""Main"" class=""section Main"">
    <div id=""Banner-text"" class=""Main Banner-text"">
        <h1>Vasyl Voronin</h1>
        <p>I am .Net developer. I like backend but i know forntend too.</p>
        <a class=""Main-btn"" href=""#Contacts"">
            <span></span>
            <span></span>
            <span></span>
            <span></span>
            Contacts
        </a>
    </div>
</div>
<div id=""Skils"" class=""section Skils"">
    <div class=""container"">
        <div href="""" id=""card-net"" class=""card"">
            <div class=""box"">
                <div class=""percent"">
                    <svg>
                        <circle cx=""70"" cy=""70"" r=""70""></circle>
                        <circle cx=""70"" cy=""70"" r=""70""></circle>
                    </svg>
                    <div class=""number"">
                        <h2>80<span>%</span></h2>
                    </div>
                </div>
                <h2 class=""Skill-text"">.Net</h2>
            </div>
        </div>
    ");
            WriteLiteral(@"    <div href="""" id=""card-front"" class=""card"">
            <div class=""box"">
                <div class=""percent"">
                    <svg>
                        <circle cx=""70"" cy=""70"" r=""70""></circle>
                        <circle cx=""70"" cy=""70"" r=""70""></circle>
                    </svg>
                    <div class=""number"">
                        <h2>75<span>%</span></h2>
                    </div>
                </div>
                <h2 class=""Skill-text"">FrontEnd</h2>
            </div>
        </div>
        <div href="""" id=""card-db"" class=""card"">
            <div class=""box"">
                <div class=""percent"">
                    <svg>
                        <circle cx=""70"" cy=""70"" r=""70""></circle>
                        <circle cx=""70"" cy=""70"" r=""70""></circle>
                    </svg>
                    <div class=""number"">
                        <h2>85<span>%</span></h2>
                    </div>
                </div>
                <h2 class=""Skill-");
            WriteLiteral(@"text"">DatBase</h2>
            </div>
        </div>
    </div>
    <div id=""net"" class=""Skills-details"">
        <div class=""Skills-Info"">
            <span class=""Name"">C#</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:80%""></div>
            </div>
            <span class=""Value"">80%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">ASP.NET</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:70%""></div>
            </div>
            <span class=""Value"">70%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">Core</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:70%""></div>
            </div>
            <span class=""Value"">70%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">WCF</span>
            <div class=""Percent"">
                <di");
            WriteLiteral(@"v class=""Progress"" style=""width:90%""></div>
            </div>
            <span class=""Value"">90%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">WebForms</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:80%""></div>
            </div>
            <span class=""Value"">80%</span>
        </div>
    </div>

    <div id=""front""  class=""Skills-details"">
        <div class=""Skills-Info"">
            <span class=""Name"">HTML</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:90%""></div>
            </div>
            <span class=""Value"">90%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">CSS</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:85%""></div>
            </div>
            <span class=""Value"">85%</span>
        </div>

        <div class=""Skills-Info"">
            <span cla");
            WriteLiteral(@"ss=""Name"">JavaScript</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:65%""></div>
            </div>
            <span class=""Value"">65%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">jQuery</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:65%""></div>
            </div>
            <span class=""Value"">65%</span>
        </div>
    </div>

    <div id=""database"" class=""Skills-details"">
        <div class=""Skills-Info"">
            <span class=""Name"">SQL</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:90%""></div>
            </div>
            <span class=""Value"">90%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">Oracle</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:65%""></div>
            </div>
            <span class=""Value"">6");
            WriteLiteral(@"5%</span>
        </div>

        <div class=""Skills-Info"">
            <span class=""Name"">Entity Framework</span>
            <div class=""Percent"">
                <div class=""Progress"" style=""width:80%""></div>
            </div>
            <span class=""Value"">80%</span>
        </div>
    </div>
</div>

<div id=""Project"" class=""section Project"">
    <div class=""containerProject"">
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(5666, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf10354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5716, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(6215, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf12031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6265, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(6764, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf13708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6814, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(7313, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf15385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7363, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(7862, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf17062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7912, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(8411, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf18739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8461, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(8960, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf20416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9010, 499, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
        <div class=""box"">
            <div class=""imageBox"">
                ");
            EndContext();
            BeginContext(9509, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf22093", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9559, 1383, true);
            WriteLiteral(@"
            </div>
            <div class=""projectDetails"">
                <div class=""content"">
                    <h2>My First Project</h2>
                    <p>
                        It is porject is my porfolio. jdngkjnskgksdknkn
                        fndsknldnsglknsdkg
                        lkjfkdsjgkdsjgkj
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""Works"" class=""section Works"">
    
</div>

<div id=""Contacts"" class=""section Contacts"">
    <div class=""containerContacts"">
        <div class=""boxContacts"">
            <a id=""location"" class=""iconContacts"">
                <i class=""fa fa-map-marker"" aria-hidden=""true""></i>
                <h4>My Location</h4>
                <h3>Ukraine, Busk Rynok square</h3>
            </a>
        </div>
        <div class=""boxContacts"">
            <a id=""phone"" class=""iconContacts"">
                <i class=""fa fa-phone"" aria-hidden=""true""></i>
              ");
            WriteLiteral(@"  <h4>Mobile</h4>
                <h3>+380686212873</h3>
            </a>
        </div>
        <div class=""boxContacts"">
            <a id=""mail"" class=""iconContacts"">
                <i class=""fa fa-envelope"" aria-hidden=""true""></i>
                <h4>Email</h4>
                <h3>vasilvoronin0@gmail.com</h3>
            </a>
        </div>
");
            EndContext();
            BeginContext(11742, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(11895, 64, true);
            WriteLiteral("</div>\r\n    <div id=\"sendEmail\" class=\"sendEmail\">\r\n            ");
            EndContext();
            BeginContext(11959, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cceaf7bb1e262494be3ea58d1d26bf7b6e4145cf25004", async() => {
                BeginContext(11989, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(12008, 36, false);
#line 347 "D:\My projects\CV2\CV2\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("SendEmail"));

#line default
#line hidden
                EndContext();
                BeginContext(12044, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12065, 63, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div id=\"map\" class=\"map\" ></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
