#pragma checksum "C:\Users\Nasirov\Test\WebApiMvc\Views\Product\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8cf1c32a169cf8e94e4b722f1b2c17eab2b79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index1), @"mvc.1.0.view", @"/Views/Product/Index1.cshtml")]
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
#line 1 "C:\Users\Nasirov\Test\WebApiMvc\Views\_ViewImports.cshtml"
using WebApiMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nasirov\Test\WebApiMvc\Views\_ViewImports.cshtml"
using WebApiMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8cf1c32a169cf8e94e4b722f1b2c17eab2b79e", @"/Views/Product/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f602a3488cbf1e7fe9c968930c5214936c7a5da", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>GetList</h1>\r\n<div class=\"list-group\">\r\n\t<a href=\"#\" class=\"list-group-item\"><span class=\"fa fa-home\"></span> Products ");
#nullable restore
#line 10 "C:\Users\Nasirov\Test\WebApiMvc\Views\Product\Index1.cshtml"
                                                                             Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 11 "C:\Users\Nasirov\Test\WebApiMvc\Views\Product\Index1.cshtml"
     foreach (var product in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<a href=\"#\" class=\"list-group-item\">\r\n\t\t\t");
#nullable restore
#line 14 "C:\Users\Nasirov\Test\WebApiMvc\Views\Product\Index1.cshtml"
       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</a>\r\n");
#nullable restore
#line 16 "C:\Users\Nasirov\Test\WebApiMvc\Views\Product\Index1.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591