#pragma checksum "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032cdd177d315188155ea110cb061af98898b429"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\_ViewImports.cshtml"
using Locomotive_Empeorium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\_ViewImports.cshtml"
using Locomotive_Empeorium.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032cdd177d315188155ea110cb061af98898b429", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1960d14a2ce0c1ff449c45cca581ddddda82184b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Locomotive List</h2>
<table class=""table"" id=""test"">
	<tr>
		<th>Model Train Producer:</th>
		<th>Locomotive Name:</th>
		<th>Price</th>
		<th>Wheel Configuration</th>
		<th>Powerplant</th>
		<th>ID</th>
		<th>Year Manufactored</th>
	</tr>


");
#nullable restore
#line 16 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
     foreach (var product in Model)
	{
		

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr draggable=\"true\">\r\n\r\n\r\n\r\n\r\n\t<td>");
#nullable restore
#line 24 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 25 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.LocomotiveName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>$");
#nullable restore
#line 26 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 27 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.Gauge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 28 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.PowerPlant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 29 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.WheelConfig);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 30 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 31 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.Year_Manufactored);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 32 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"
   Write(product.WheelConfig);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\t\r\n\r\n</tr>\r\n");
#nullable restore
#line 37 "C:\Users\owner\source\repos\Locomotive_Empeorium\Locomotive_Empeorium\Views\Product\Index.cshtml"

	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
