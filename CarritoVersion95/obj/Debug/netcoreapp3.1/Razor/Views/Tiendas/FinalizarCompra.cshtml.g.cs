#pragma checksum "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5153cf89cd068ddab0d34df6eeaddb488cc63ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tiendas_FinalizarCompra), @"mvc.1.0.view", @"/Views/Tiendas/FinalizarCompra.cshtml")]
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
#line 1 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\_ViewImports.cshtml"
using CarritoVersion95;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\_ViewImports.cshtml"
using CarritoVersion95.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5153cf89cd068ddab0d34df6eeaddb488cc63ae0", @"/Views/Tiendas/FinalizarCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91db1f38f2ffe80edaba9cc2c1f86f88971e740", @"/Views/_ViewImports.cshtml")]
    public class Views_Tiendas_FinalizarCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarritoVersion95.Models.Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
  
    ViewData["Title"] = "FinalizarCompra";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Compra Finalizada</h1>\r\n\r\n<div>\r\n    <h4>Pedido</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
       Write(Html.DisplayNameFor(model => model.IdPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.IdPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
       Write(Html.DisplayNameFor(model => model.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecioTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.PrecioTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Cantidad
            </th>
            <th>
                Precio
            </th>
            <th>
                IdProducto
            </th>
            <th>
               IdTienda
            </th>
            <th>
               NombreProducto
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 58 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
               Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdTienda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 78 "C:\Users\iwry\source\repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\FinalizarCompra.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarritoVersion95.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
