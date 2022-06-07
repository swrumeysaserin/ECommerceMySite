#pragma checksum "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e703c91d9403e023ed4b200312cfad9497f8d0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_BasketMini), @"mvc.1.0.view", @"/Views/Product/BasketMini.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e703c91d9403e023ed4b200312cfad9497f8d0a", @"/Views/Product/BasketMini.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2968736dbe31a6c94be6d93d385d3a6727c5ebcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_BasketMini : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"mini-products-list\">\r\n");
#nullable restore
#line 3 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
     foreach (var item in Model.BasketProducts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"item\">\r\n            <a class=\"product-image\" href=\"#\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 204, "\"", 230, 2);
            WriteAttributeValue("", 210, "/product/", 210, 9, true);
#nullable restore
#line 7 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
WriteAttributeValue("", 219, item.Image, 219, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 231, "\"", 255, 1);
#nullable restore
#line 7 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
WriteAttributeValue("", 237, item.product.Name, 237, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 256, "\"", 264, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </a>
            <div class=""product-details"">
                <a href=""#"" class=""remove""><i class=""anm anm-times-l"" aria-hidden=""true""></i></a>
                <a href=""#"" class=""edit-i remove""><i class=""anm anm-edit"" aria-hidden=""true""></i></a>
                <a class=""pName"" href=""cart.html"">");
#nullable restore
#line 12 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
                                             Write(item.product.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                <div class=\"wrapQtyBtn\">\r\n                    <div class=\"qtyField\">\r\n                        <span class=\"label\">Qty:</span>\r\n                        <a class=\"qtyBtn minus\"");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 917, 3);
            WriteAttributeValue("", 880, "javascript:plus(", 880, 16, true);
#nullable restore
#line 17 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
WriteAttributeValue("", 896, item.product.Id, 896, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 912, ",-1);", 912, 5, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa anm anm-minus-r\" aria-hidden=\"true\"></i></a>\r\n                        <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 1020, "\"", 1050, 2);
            WriteAttributeValue("", 1025, "quantity_", 1025, 9, true);
#nullable restore
#line 18 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
WriteAttributeValue("", 1034, item.product.Id, 1034, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"quantity\"");
            BeginWriteAttribute("value", " value=\"", 1067, "\"", 1089, 1);
#nullable restore
#line 18 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
WriteAttributeValue("", 1075, item.Quantity, 1075, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-form__input qty\">\r\n                        <a class=\"qtyBtn plus\"");
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1214, 3);
            WriteAttributeValue("", 1178, "javascript:plus(", 1178, 16, true);
#nullable restore
#line 19 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
WriteAttributeValue("", 1194, item.product.Id, 1194, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1210, ",1);", 1210, 4, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa anm anm-plus-r\" aria-hidden=\"true\"></i></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"priceRow\">\r\n                    <div class=\"product-price\">\r\n                        <span class=\"money\">");
#nullable restore
#line 24 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
                                       Write(item.product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 29 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<div class=\"total\">\r\n    <div class=\"total-in\">\r\n        <span class=\"label\">Toplam :</span><span class=\"product-price\"><span class=\"money\">");
#nullable restore
#line 33 "C:\AspNetCoreEducation\ECommerce\ECommerce.Web\Views\Product\BasketMini.cshtml"
                                                                                      Write(Model.BasketProducts.Sum(x => x.product.Price * x.Quantity).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></span>
    </div>
    <div class=""buttonSet text-center"">
        <a href=""/checkout"" class=""btn btn-secondary btn--small"">Checkout</a>
    </div>
</div>

<script>
    function plus(productId,quantity)
    {
      $.post(""/plusproduct"",{productId:productId,quantity:quantity},function(data,status){
                    $(""#quantity_""+productId).val(data);

                    });

      $.post(""/calculatebasket"",{},function(data,status){
                    $("".money"").html(data);
               
                    });
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
