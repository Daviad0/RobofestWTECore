#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1721e4ec21d8b189888e5a6c3bcc8e27ce547899"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_JudgeIndex), @"mvc.1.0.view", @"/Views/Team/JudgeIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/JudgeIndex.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_JudgeIndex))]
namespace RobofestWTECore.Pages.Team
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore;

#line default
#line hidden
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1721e4ec21d8b189888e5a6c3bcc8e27ce547899", @"/Views/Team/JudgeIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_JudgeIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.JudgeIndexPageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"
  
    ViewBag.Title = "Judge Controller";

#line default
#line hidden
            BeginContext(95, 1189, true);
            WriteLiteral(@"<style>
    .btn-group {
        display: flex;
    }

    .btn {
        flex: 1
    }

    btn-default: {
        background-color: gray
    }

    .footer {
        position: fixed;
        left: 0;
        bottom: 0;
        width: 100%;
        background-color: #ecbb06;
        color: white;
        text-align: center;
    }

    .true {
        color: green
    }

    .false {
        color: green
    }
</style>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity");
            WriteLiteral("=\"sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl\" crossorigin=\"anonymous\"></script>\r\n<h2 style=\"text-align:center\">Scoresheet</h2>\r\n<br />\r\n");
            EndContext();
#line 42 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"
 foreach (var field in Model.Fields.OrderBy(f => f.FieldNumber))
{


#line default
#line hidden
            BeginContext(1355, 182, true);
            WriteLiteral("    <div style=\"background-color:lightgray;border-radius:6px;border:5px solid lightgray;z-index:-1;text-align:center\">\r\n        <div style=\"display:inherit\">\r\n            <h2>Field #");
            EndContext();
            BeginContext(1538, 17, false);
#line 47 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"
                  Write(field.FieldNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1555, 6, true);
            WriteLiteral(" <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1561, "\"", 1581, 1);
#line 47 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"
WriteAttributeValue("", 1569, field.Using, 1569, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1582, 69, true);
            WriteLiteral(" style=\"color:green\">&#9632;</span></h2>\r\n            <h4>Currently: ");
            EndContext();
            BeginContext(1652, 23, false);
#line 48 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"
                      Write(field.CurrentTeamNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 10, true);
            WriteLiteral(", Junior: ");
            EndContext();
            BeginContext(1686, 12, false);
#line 48 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"
                                                        Write(field.Junior);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 47, true);
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
            EndContext();
#line 52 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\JudgeIndex.cshtml"

}

#line default
#line hidden
            BeginContext(1750, 135, true);
            WriteLiteral("\r\n<!--<div class=\"footer\" style=\"z-index:1\">\r\n    <br />\r\n    <h3>Total Points: <span id=\"total\">0</span></h3>\r\n    <br />\r\n</div>-->\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.JudgeIndexPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
