#pragma checksum "D:\Proftaak\Carshop\Car To Go\Views\Home\Location.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0cc89c67d03f5ec734d09ab59bf374e65290e15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Location), @"mvc.1.0.view", @"/Views/Home/Location.cshtml")]
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
#line 1 "D:\Proftaak\Carshop\Car To Go\Views\_ViewImports.cshtml"
using Car_To_Go;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proftaak\Carshop\Car To Go\Views\_ViewImports.cshtml"
using Car_To_Go.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cc89c67d03f5ec734d09ab59bf374e65290e15", @"/Views/Home/Location.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c83138161ff59e1813736c524908620ad6316eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Location : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proftaak\Carshop\Car To Go\Views\Home\Location.cshtml"
  
    ViewData["Title"] = "Location";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4 pb-2""> Our location in the Netherlands!</h1>
    <p class=""font-weight-light"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin sit amet vestibulum nulla. Suspendisse rutrum, lacus a placerat tempus, tellus velit efficitur leo, id tincidunt leo risus eget libero. Nulla vestibulum metus non neque ullamcorper, non ornare est aliquam. Maecenas in libero nec ipsum dapibus pellentesque sed eu mauris. Quisque dapibus leo fringilla lorem pulvinar volutpat. Sed commodo, nibh in condimentum ultricies, diam felis ultrices purus, sed aliquam libero felis et ligula. Fusce porta placerat dolor a imperdiet. Suspendisse dapibus, nisl sed consequat sollicitudin, erat diam porta metus, tempor sodales felis lectus non arcu. Aliquam ullamcorper sagittis pharetra. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. In laoreet accumsan lorem, vitae rhoncus nunc consequat pellentesque. In ac ligula metus. Nullam dui lorem, viverr");
            WriteLiteral(@"a vel aliquam sit amet, ultrices nec ante.</p>
</div>

<hr/>

<div class=""card-body"">
    <div class=""row"">
        <div class=""col-sm-4""><img src=""https://cdn.discordapp.com/attachments/754679426339569788/754989816499929188/ar129164824317869.png""/></div>
        <div class=""col-sm-8"">
            <h3 class=""pb2""> Location: Eindhoven</h3>
            <h5> Adres: Rachelmolen 1 </h5>
            <p>Why here? -This is the orgin of technology, and we believe that we can be part of it with our cars! Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin sit amet vestibulum nulla. Suspendisse rutrum, lacus a placerat tempus, tellus velit efficitur leo, id tincidunt leo risus eget libero. Nulla vestibulum metus non neque ullamcorper, non ornare est aliquam.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0cc89c67d03f5ec734d09ab59bf374e65290e155801", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-primary\">View our store!</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
