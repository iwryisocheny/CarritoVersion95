#pragma checksum "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c06b4c2072bf673152c45e40e56018014846653d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tiendas_ListaProductosAPI), @"mvc.1.0.view", @"/Views/Tiendas/ListaProductosAPI.cshtml")]
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
#line 1 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\_ViewImports.cshtml"
using CarritoVersion95;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\_ViewImports.cshtml"
using CarritoVersion95.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06b4c2072bf673152c45e40e56018014846653d", @"/Views/Tiendas/ListaProductosAPI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91db1f38f2ffe80edaba9cc2c1f86f88971e740", @"/Views/_ViewImports.cshtml")]
    public class Views_Tiendas_ListaProductosAPI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AgregarACarrito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
  
    ViewData["Title"] = "ListaProductosAPI";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Todos los productos</h1><br />\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
 if (Model != null && Model.Count() > 0)
{



    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
     foreach (var producto in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card border-secondary mb-3 mr-3 d-inline-block\">\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
      
        if (producto.Imagen1 != null)
        {
            string imageBase64Data = Convert.ToBase64String(producto.Imagen1);
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

           


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("style", " style=\"", 622, "\"", 781, 8);
            WriteAttributeValue("", 630, "background-image:url(", 630, 21, true);
#nullable restore
#line 33 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
WriteAttributeValue("", 651, imageDataURL, 651, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 664, ");", 664, 2, true);
            WriteAttributeValue(" ", 666, "background-repeat:no-repeat;", 667, 29, true);
            WriteAttributeValue(" ", 695, "background-position:", 696, 21, true);
            WriteAttributeValue(" ", 716, "center", 717, 7, true);
            WriteAttributeValue(" ", 723, "center;background-size:cover;", 724, 30, true);
            WriteAttributeValue(" ", 753, "width:17.9rem;height:18rem;", 754, 28, true);
            EndWriteAttribute();
            WriteLiteral(" ></div>\r\n");
#nullable restore
#line 34 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
        }
      

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"card-header\">\r\n        al ");
#nullable restore
#line 38 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
      Write(Html.DisplayFor(m => producto.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n    <div class=\"card-body\">\r\n\r\n\r\n");
            WriteLiteral("        <div class=\"d-inline-block text-truncate\" style=\"max-width: 16rem;\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
       Write(Html.DisplayFor(m => producto.DescripcionProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-group font-weight-bold\">\r\n           $ ");
#nullable restore
#line 51 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
        Write(Html.DisplayFor(m => producto.PrecioProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n    <div class=\"card-footer\">\r\n\r\n\r\n\r\n\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c06b4c2072bf673152c45e40e56018014846653d7524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 64 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new Item { IdProducto = producto.IdProducto };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 75 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
     




}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>No hay productos</div>\r\n");
#nullable restore
#line 85 "C:\Users\Cristian Yoo\Source\Repos\CarritoVersion95\CarritoVersion95\Views\Tiendas\ListaProductosAPI.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
