#pragma checksum "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98dae0de9be0bb210df219162ee318fc4d17d7cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encuesta_Disponible), @"mvc.1.0.view", @"/Views/Encuesta/Disponible.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98dae0de9be0bb210df219162ee318fc4d17d7cc", @"/Views/Encuesta/Disponible.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e609fcf4661df2429bedf0cd18a9243ea46750c", @"/Views/_ViewImports.cshtml")]
    public class Views_Encuesta_Disponible : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Encuestadora_Identity2.Models.Encuesta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
  
    ViewData["Title"] = "Disponibles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row justify-content-start align-items-center"">
        <div class=""col-6 col-sm-6"">
            <h1>Encuestas Disponibles</h1>
        </div>
        <div hidden id=""mensaje"" class=""btn btn-danger text-center active""></div>
    </div>
</div>

<p>
    <button title=""Ir al Perfil"" type=""button"" onclick=""window.open('/Identity/Account/Manage', '_self');"" class=""btn btn-light""><img src=""/img/icono_perfil.svg"" class=""img-fluid"" alt=""Perfil"" /></button>
</p>
<div class=""container-fluid"">
    <section class=""row justify-content-start align-items-center"">
        <table class=""table-responsive"">
            <thead class=""btn btn-success col-12 col-sm-12"">
                <tr class=""col-12 col-sm-12"" style=""display:inline-table"">
                    <th class=""col-2 col-sm-2 text-center"">
                        Encuesta
                    </th>
                    <th class=""col-2  col-sm-2 text-center"">
                        Vencimiento
       ");
            WriteLiteral(@"             </th>
                    <th class=""col-2  col-sm-2 text-center"">
                        Preguntas
                    </th>
                    <th class=""col-2  col-sm-2 text-center"">
                        Tipo
                    </th>
                    <th class=""col-2  col-sm-2 text-center""></th>
                </tr>
            </thead>
            <tbody class=""btn bg-light col-12 col-sm-12"">
");
#nullable restore
#line 42 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                 foreach (var item in Model)
                {
                    //var encuestaCompleta = true;
                    //var i = 0;
                    //var preguntas = item.preguntas.ToList();
                    ////VALIDO QUE CADA PREGUNTA TENGA OPCIONES
                    //    while (i < preguntas.Count && encuestaCompleta)
                    //{
                    //    if (preguntas[i].opciones.Count <= 0)
                    //    {
                    //        encuestaCompleta = false;
                    //    }
                    //    else
                    //    {
                    //        i++;
                    //    }
                    //}
                    ////SI ESTA COMPLETA MUESTRO LA ENCUESTA
                    //    if (encuestaCompleta)
                    //{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"col-12 col-sm-12\" style=\"display:inline-table\">\r\n                        <td class=\"col-2 col-sm-2 text-center\">\r\n                            ");
#nullable restore
#line 64 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(Html.DisplayFor(modelItem => item.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-2 col-sm-2 text-center\">\r\n                            ");
#nullable restore
#line 67 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(Html.DisplayFor(modelItem => item.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <th class=\"col-2 col-sm-2 text-center\">\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 71 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(item.preguntas.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n");
#nullable restore
#line 73 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                         if (item.puntosEncuesta == PuntosEncuesta.ENCUESTA_ORO)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td class=""col-2 col-sm-2 text-center"">
                                <p class=""btn btn-warning btn-sm text-black-50 font-weight-bold active col-2 col-sm-2"" style=""display:inline""> ORO  </p>
                            </td>
");
#nullable restore
#line 78 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                        }
                        else if (item.puntosEncuesta == PuntosEncuesta.ENCUESTA_PLATA)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-2 col-sm-2 text-center\">\r\n                                <p class=\"btn btn-secondary active btn-sm col-2 col-sm-2\" style=\"display:inline\">PLATA </p>\r\n                            </td>\r\n");
#nullable restore
#line 84 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-2 col-sm-2 text-center\">\r\n                                <p class=\"btn active btn-sm col-2 col-sm-2\" style=\"display:inline\">GRATIS</p>\r\n                            </td>\r\n");
#nullable restore
#line 90 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-2 col-sm-2 text-center\">\r\n                            <button title=\"Responder\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4345, "\"", 4446, 4);
            WriteAttributeValue("", 4355, "window.open(\'/EncuestaRespondida/ResponderPreguntas?EncuestaId=", 4355, 63, true);
#nullable restore
#line 92 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
WriteAttributeValue("", 4418, item.EncuestaId, 4418, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4434, "\',", 4434, 2, true);
            WriteAttributeValue(" ", 4436, "\'_self\');", 4437, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\"><img src=\"/img/icono_responder.svg\" class=\"img-fluid\" alt=\"Ver\" /></button>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                    //}
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</div>\r\n\r\n");
#nullable restore
#line 103 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
 if (ViewBag.esEncuestaRespondida != null)
{
    if (ViewBag.esEncuestaRespondida)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            var mensaje = document.getElementById(\'mensaje\');\r\n            mensaje.removeAttribute(\"hidden\");\r\n            mensaje.innerHTML = \"Encuesta respondida, gracias! \"\r\n        </script>\r\n");
#nullable restore
#line 112 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Encuestadora_Identity2.Models.Encuesta>> Html { get; private set; }
    }
}
#pragma warning restore 1591