#pragma checksum "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a441bb7cba24e367b3efd9102c9d6d297a9d2e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SliderShow_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SliderShow/Default.cshtml")]
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
#line 1 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Web.ViewConponents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a441bb7cba24e367b3efd9102c9d6d297a9d2e04", @"/Views/Shared/Components/SliderShow/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2968736dbe31a6c94be6d93d385d3a6727c5ebcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SliderShow_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SliderShowModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"slideshow slideshow-wrapper pb-section sliderFull\">\r\n    <div class=\"home-slideshow\">\r\n");
#nullable restore
#line 4 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
         foreach (var item in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"slide\">\r\n            <div class=\"blur-up lazyload bg-size\">\r\n                <img class=\"blur-up lazyload bg-img\" data-src=\"assets/images/slideshow-banners/");
#nullable restore
#line 8 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
                                                                                          Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 370, "\"", 419, 2);
            WriteAttributeValue("", 376, "assets/images/slideshow-banners/", 376, 32, true);
#nullable restore
#line 8 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
WriteAttributeValue("", 408, item.Image, 408, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 420, "\"", 438, 1);
#nullable restore
#line 8 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
WriteAttributeValue("", 426, item.Header, 426, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 439, "\"", 464, 1);
#nullable restore
#line 8 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
WriteAttributeValue("", 447, item.Description, 447, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                <div class=""slideshow__text-wrap slideshow__overlay classic bottom"">
                    <div class=""slideshow__text-content bottom"">
                        <div class=""wrap-caption center"">
                            <h2 class=""h1 mega-title slideshow__title"">");
#nullable restore
#line 12 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
                                                                  Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <span class=\"mega-subtitle slideshow__subtitle\">");
#nullable restore
#line 13 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
                                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                           <a");
            BeginWriteAttribute("href", " href=\"", 902, "\"", 919, 1);
#nullable restore
#line 14 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
WriteAttributeValue("", 909, item.Link, 909, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"btn\">Satın Al</span></a> \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\SliderShow\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SliderShowModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
