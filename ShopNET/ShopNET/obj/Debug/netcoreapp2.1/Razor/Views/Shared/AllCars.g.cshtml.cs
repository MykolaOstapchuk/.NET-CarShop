#pragma checksum "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f49ff4e32cfc22f9bb25fce0ec9320b0f0608cc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllCars.cshtml", typeof(AspNetCore.Views_Shared_AllCars))]
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
#line 1 "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\_ViewImports.cshtml"
using ShopNET.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\_ViewImports.cshtml"
using ShopNET.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49ff4e32cfc22f9bb25fce0ec9320b0f0608cc2", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ebcb05d0dae5fbaf3214550e6d50019b3e2f4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 56, true);
            WriteLiteral("\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbmail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 68, "\"", 84, 1);
#line 4 "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 74, Model.img, 74, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 85, "\"", 102, 1);
#line 4 "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 91, Model.name, 91, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(103, 38, true);
            WriteLiteral(" width=\"320\" height=\"200\" />\r\n    <h2>");
            EndContext();
            BeginContext(142, 10, false);
#line 5 "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\Shared\AllCars.cshtml"
   Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(152, 20, true);
            WriteLiteral("</h2>\r\n    <p>Cena: ");
            EndContext();
            BeginContext(173, 25, false);
#line 6 "C:\Users\48730\source\repos\ShopNET\ShopNET\Views\Shared\AllCars.cshtml"
        Write(Model.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(198, 89, true);
            WriteLiteral("</p>\r\n    <p><a class=\"btn btn-warning\" href=\"a\">Dodatkowa informacja</a></p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
