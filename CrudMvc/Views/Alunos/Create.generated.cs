﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CrudMvc;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Alunos/Create.cshtml")]
    public partial class _Views_Alunos_Create_cshtml : System.Web.Mvc.WebViewPage<CrudMvc.Models.Aluno>
    {
        public _Views_Alunos_Create_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Alunos\Create.cshtml"
  
    ViewBag.Title = "Create";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Create</h2>\r\n\r\n\r\n");

            
            #line 10 "..\..\Views\Alunos\Create.cshtml"
 using (Html.BeginForm()) 
{
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Alunos\Create.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Alunos\Create.cshtml"
                            
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <h4>Aluno</h4>\r\n        <hr />\r\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\Alunos\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\Alunos\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Alunos\Create.cshtml"
       Write(Html.LabelFor(model => model.Endereco, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.EditorFor(model => model.Endereco, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Endereco, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\Alunos\Create.cshtml"
       Write(Html.LabelFor(model => model.Telefone, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 37 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.EditorFor(model => model.Telefone, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Telefone, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Alunos\Create.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Alunos\Create.cshtml"
       Write(Html.LabelFor(model => model.Nascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.EditorFor(model => model.Nascimento, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..\Views\Alunos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nascimento, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\Alunos\Create.cshtml"
       Write(Html.LabelFor(model => model.Ativo, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 62 "..\..\Views\Alunos\Create.cshtml"
               Write(Html.EditorFor(model => model.Ativo));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 63 "..\..\Views\Alunos\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Ativo, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Create\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 74 "..\..\Views\Alunos\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 77 "..\..\Views\Alunos\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 81 "..\..\Views\Alunos\Create.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
