<<<<<<< Updated upstream
#pragma checksum "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff1f879763b42a1bd8f067728efa88d4b4d35c8"
=======
#pragma checksum "D:\Fontys semester 2 2020-2021\Test\Carshop\Car To Go\Views\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d25ffa014e7be5769b900cb4721fe99a282de05"
>>>>>>> Stashed changes
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Index), @"mvc.1.0.view", @"/Views/Car/Index.cshtml")]
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
<<<<<<< Updated upstream
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff1f879763b42a1bd8f067728efa88d4b4d35c8", @"/Views/Car/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d25ffa014e7be5769b900cb4721fe99a282de05", @"/Views/Car/Index.cshtml")]
>>>>>>> Stashed changes
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c83138161ff59e1813736c524908620ad6316eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Car_To_Go.Models.CarViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"h2 pt-3 text-center font-weight-bold\">Our showroom, meet the prestigious cars!</div>\r\n<hr />\r\n\r\n");
#nullable restore
#line 7 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
 foreach (var item in Model)
{
   

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"card-deck\">\r\n\r\n           <div class=\"card\">\r\n               <h2>");
#nullable restore
#line 13 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
              Write(Html.DisplayFor(ModelItem => item.Brandname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 13 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
                                                              Write(Html.DisplayFor(ModelItem => item.Modelname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n               \r\n               <p>");
#nullable restore
#line 15 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
             Write(Html.DisplayFor(ModelItem => item.Enginepower));

#line default
#line hidden
#nullable disable
            WriteLiteral("PK</p>\r\n               <p>");
#nullable restore
#line 16 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
             Write(Html.DisplayFor(ModelItem => item.Acceleration));

#line default
#line hidden
#nullable disable
            WriteLiteral("seconds to 0-100km/h)</p>\r\n               <p>");
#nullable restore
#line 17 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
             Write(Html.DisplayFor(ModelItem => item.Cargospace));

#line default
#line hidden
#nullable disable
            WriteLiteral("Liters Cargospace</p>\r\n               <p>");
#nullable restore
#line 18 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
             Write(Html.DisplayFor(ModelItem => item.Seat));

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("</p>\r\n\r\n           </div>\r\n       </div>\r\n       <br/>\r\n");
#nullable restore
#line 23 "D:\Proftaak\Carshop\Car To Go\Views\Car\Index.cshtml"
       
                       
=======
            WriteLiteral("</p>\r\n\r\n           </div>\r\n       </div>\r\n       <br/>            \r\n");
#nullable restore
#line 23 "D:\Fontys semester 2 2020-2021\Test\Carshop\Car To Go\Views\Car\Index.cshtml"
>>>>>>> Stashed changes
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Car_To_Go.Models.CarViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
