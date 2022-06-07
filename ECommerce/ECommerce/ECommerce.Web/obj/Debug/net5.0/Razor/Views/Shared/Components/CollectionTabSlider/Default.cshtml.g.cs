#pragma checksum "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34015aa25a4d9dd7770225d289cdb617b7c44cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CollectionTabSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CollectionTabSlider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34015aa25a4d9dd7770225d289cdb617b7c44cd", @"/Views/Shared/Components/CollectionTabSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2968736dbe31a6c94be6d93d385d3a6727c5ebcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CollectionTabSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollectionTabSliderModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""tab-slider-product section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-sm-12 col-md-12 col-lg-12"">
                <div class=""section-header text-center"">
                    <h2 class=""h2"">Yeni Ürünler</h2>
                    <p>En Yeni Ürünler</p>
                </div>
                <div class=""tabs-listing"">
                    <ul class=""tabs clearfix"">
");
#nullable restore
#line 12 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 590, "\"", 598, 0);
            EndWriteAttribute();
            BeginWriteAttribute("rel", " rel=\"", 599, "\"", 617, 2);
            WriteAttributeValue("", 605, "tab-", 605, 4, true);
#nullable restore
#line 14 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
WriteAttributeValue("", 609, item.Id, 609, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                    <div class=\"tab_container\">\r\n");
#nullable restore
#line 20 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("id", " id=\"", 867, "\"", 884, 2);
            WriteAttributeValue("", 872, "tab-", 872, 4, true);
#nullable restore
#line 22 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
WriteAttributeValue("", 876, item.Id, 876, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tab_content grid-products\">\r\n                                <div class=\"productSlider\">\r\n");
#nullable restore
#line 24 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                     foreach (var item2 in Model.Products.Where(x => x.Key == item.Id))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                         foreach (var product in item2.Value)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col-12 item\">\r\n\r\n                                                <div class=\"product-image\">\r\n\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1457, "\"", 1486, 2);
            WriteAttributeValue("", 1464, "/urun/", 1464, 6, true);
#nullable restore
#line 33 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
WriteAttributeValue("", 1470, product.SeoName, 1470, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 34 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                          
                                                            int i = 0;
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                         foreach (var imagesItem in Model.ProductImages.Where(x => x.Key == product.Id).FirstOrDefault().Value)
                                                        {
                                                            if (i == 0)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <img class=\"primary blur-up lazyload\" data-src=\"/product/");
#nullable restore
#line 41 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                                                                                    Write(imagesItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 2175, "\"", 2206, 2);
            WriteAttributeValue("", 2181, "/product/", 2181, 9, true);
#nullable restore
#line 41 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
WriteAttributeValue("", 2190, imagesItem.Name, 2190, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" title=\"product\">\r\n");
#nullable restore
#line 42 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                                i++;
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <img class=\"hover blur-up lazyload\" data-src=\"/product/");
#nullable restore
#line 46 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                                                                                  Write(imagesItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 2636, "\"", 2667, 2);
            WriteAttributeValue("", 2642, "/product/", 2642, 9, true);
#nullable restore
#line 46 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
WriteAttributeValue("", 2651, imagesItem.Name, 2651, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" title=\"product\">\r\n");
#nullable restore
#line 47 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                            }

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                                    </a>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("                                                    <button class=\"btn btn-addto-cart\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3165, "\"", 3207, 3);
            WriteAttributeValue("", 3175, "AddBasketHomePage(1,", 3175, 20, true);
#nullable restore
#line 67 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
WriteAttributeValue("", 3195, product.Id, 3195, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3206, ")", 3206, 1, true);
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"0\">Sepete Ekle</button>\r\n");
            WriteLiteral(@"                                                    <div class=""button-set"">
                                                        <a href=""javascript:void(0)"" title=""Quick View"" class=""quick-view-popup quick-view"" data-toggle=""modal"" data-target=""#content_quickview"">
                                                            <i class=""icon anm anm-search-plus-r""></i>
                                                        </a>
                                                        <div class=""wishlist-btn"">
                                                            <a class=""wishlist add-to-wishlist"" href=""wishlist.html"">
                                                                <i class=""icon anm anm-heart-l""></i>
                                                            </a>
                                                        </div>
                                                        <div class=""compare-btn"">
                                                            <a clas");
            WriteLiteral(@"s=""compare add-to-compare"" href=""compare.html"" title=""Add to Compare"">
                                                                <i class=""icon anm anm-random-r""></i>
                                                            </a>
                                                        </div>
                                                    </div>

                                                </div>


                                                <div class=""product-details text-center"">

                                                    <div class=""product-name"">
                                                        <a href=""short-description.html"">");
#nullable restore
#line 91 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                                                    Write(product.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                    </div>\r\n\r\n\r\n                                                    <div class=\"product-price\">\r\n\r\n                                                        <span class=\"price\"");
            BeginWriteAttribute("id", " id=\"", 5274, "\"", 5279, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                                                             Write(product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </div>\r\n\r\n\r\n\r\n\r\n\r\n                                                </div>\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 107 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                                         

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 114 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Shared\Components\CollectionTabSlider\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CollectionTabSliderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
