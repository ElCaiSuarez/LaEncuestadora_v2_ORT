#pragma checksum "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c0e5b82779ff7999f450e8ee616956eccb7fff7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encuesta_Details), @"mvc.1.0.view", @"/Views/Encuesta/Details.cshtml")]
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
#line 1 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\_ViewImports.cshtml"
using Encuestadora_Identity2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\_ViewImports.cshtml"
using Encuestadora_Identity2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0e5b82779ff7999f450e8ee616956eccb7fff7", @"/Views/Encuesta/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e609fcf4661df2429bedf0cd18a9243ea46750c", @"/Views/_ViewImports.cshtml")]
    public class Views_Encuesta_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Encuestadora_Identity2.Models.Encuesta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
  
    ViewData["Title"] = "Detalles";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var darAviso = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 9 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
Write(Html.DisplayFor(model => model.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n<p>\r\n    <button title=\"Mis Encuestas\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 287, "\"", 360, 4);
            WriteAttributeValue("", 297, "window.open(\'/Encuesta?userName=", 297, 32, true);
#nullable restore
#line 12 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
WriteAttributeValue("", 329, User.Identity.Name, 329, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 348, "\',", 348, 2, true);
            WriteAttributeValue(" ", 350, "\'_self\');", 351, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\"><img src=\"/img/icono_atras.svg\" class=\"img-fluid\" alt=\"Atras\" /></button>\r\n</p>\r\n<div>\r\n    <dl class=\"row\">\r\n");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Html.DisplayFor(model => model.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Html.DisplayFor(model => model.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Html.DisplayFor(model => model.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Preguntas\r\n        </dt>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 45 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
       Write(Model.preguntas.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
             if (Model.preguntas.Count == 0)
            {
                darAviso = true;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button title=\"Ver Preguntas\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1786, "\"", 1859, 4);
            WriteAttributeValue("", 1796, "window.open(\'/Pregunta?EncuestaId=", 1796, 34, true);
#nullable restore
#line 50 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
WriteAttributeValue("", 1830, Model.EncuestaId, 1830, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1847, "\',", 1847, 2, true);
            WriteAttributeValue(" ", 1849, "\'_self\');", 1850, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\"><img src=\"/img/icono_ver.svg\" class=\"img-fluid\" alt=\"Ver\" /></button>\r\n        </dt>\r\n    </dl>\r\n</div>\r\n");
            WriteLiteral("\r\n<p hidden id=\"mensaje\" class=\"btn btn-danger text-center col-4 active\"></p>\r\n\r\n");
#nullable restore
#line 62 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"
 if (darAviso)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        var mensaje = document.getElementById(\'mensaje\');\r\n        mensaje.removeAttribute(\"hidden\");\r\n        mensaje.innerHTML = \"CUIDADO: Encuesta sin preguntas!\"\r\n    </script>\r\n");
#nullable restore
#line 69 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Details.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Encuestadora_Identity2.Models.Encuesta> Html { get; private set; }
    }
}
#pragma warning restore 1591