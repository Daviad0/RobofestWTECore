#pragma checksum "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e464717f5e4ee90546ae14ea36fe81e6b0e35adb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_GAME), @"mvc.1.0.view", @"/Views/Team/GAME.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/GAME.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_GAME))]
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
#line 1 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/_ViewImports.cshtml"
using RobofestWTECore;

#line default
#line hidden
#line 3 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/_ViewImports.cshtml"
using RobofestWTECore.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e464717f5e4ee90546ae14ea36fe81e6b0e35adb", @"/Views/Team/GAME.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0c74960f6b96bae451f4a9058021941d4cf852", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_GAME : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.GamePageModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(75, 107, true);
            WriteLiteral("<style>\n    table{\n        border:0px;\n        border-collapse:collapse;\n        width:100%\n    }\n</style>\n");
            EndContext();
            BeginContext(182, 2337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef639560ad6d4ca788a432bd4b473da4", async() => {
                BeginContext(188, 379, true);
                WriteLiteral(@"
    <h2 style=""text-align:center"">Competition Index</h2>
    <div width=""100%"" style=""background-color:lightgray;border:1px lightgray solid;border-radius:10px;margin:10px"">
        <table style=""text-align:center;font-size:25px;margin:10px"">
            <tr>
                <td width=""33%""></td>
                <td width=""33%"" style=""padding-bottom:10px"">
                    ");
                EndContext();
                BeginContext(568, 36, false);
#line 20 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(604, 179, true);
                WriteLiteral("\n                </td>\n                <td width=\"33%\"></td>\n            </tr>\n\n            <tr style=\"font-size:20px\">\n                <td width=\"33%\">\n                    GAME #");
                EndContext();
                BeginContext(784, 38, false);
#line 27 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
                     Write(Html.DisplayFor(model => model.GameID));

#line default
#line hidden
                EndContext();
                BeginContext(822, 76, true);
                WriteLiteral("\n                </td>\n                <td width=\"33%\">\n                    ");
                EndContext();
                BeginContext(899, 36, false);
#line 30 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
               Write(Html.DisplayFor(model => model.Desc));

#line default
#line hidden
                EndContext();
                BeginContext(935, 56, true);
                WriteLiteral("\n                </td>\n                <td width=\"33%\">\n");
                EndContext();
#line 33 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
                       
                        int competitions = Model.Competitions.Count;
                    

#line default
#line hidden
                BeginContext(1106, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1127, 12, false);
#line 36 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
               Write(competitions);

#line default
#line hidden
                EndContext();
                BeginContext(1139, 739, true);
                WriteLiteral(@" Competitions
                </td>
            </tr>
        </table>
    </div>
    <h3 style=""text-align:center"">All Competitions:</h3>
    <table>
        <tr style=""font-size:20px;border-bottom:5px black solid"">
            <th style=""background-color:#ffffff;width:1%;padding-right:5px"">
                ID 
            </th>
            <th style=""background-color:#ffffff"">
                Location
            </th>
            <th style=""background-color:#ffffff"">
                Date
            </th>
            <th>
                Extra
            </th>
            <th>
                # of Teams
            </th>
            <th style=""background-color:#ffffff"">
                Options
            </th>
        </tr>
");
                EndContext();
#line 63 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
         foreach (var item in Model.Competitions.OrderByDescending(a => a.Date))
        {

#line default
#line hidden
                BeginContext(1969, 88, true);
                WriteLiteral("        <tr>\n            <td style=\"background-color:#ffffff;width:1%\">\n                ");
                EndContext();
                BeginContext(2058, 11, false);
#line 67 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
           Write(item.CompID);

#line default
#line hidden
                EndContext();
                BeginContext(2069, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2122, 13, false);
#line 70 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
           Write(item.Location);

#line default
#line hidden
                EndContext();
                BeginContext(2135, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2188, 9, false);
#line 73 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
           Write(item.Date);

#line default
#line hidden
                EndContext();
                BeginContext(2197, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2250, 14, false);
#line 76 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
           Write(item.ExtraData);

#line default
#line hidden
                EndContext();
                BeginContext(2264, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2317, 14, false);
#line 79 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
           Write(item.TeamCount);

#line default
#line hidden
                EndContext();
                BeginContext(2331, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2384, 67, false);
#line 82 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
           Write(Html.ActionLink("Details", "Competition", new { id = item.CompID }));

#line default
#line hidden
                EndContext();
                BeginContext(2451, 33, true);
                WriteLiteral("\n            </td>\n        </tr>\n");
                EndContext();
#line 85 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/GAME.cshtml"
        }

#line default
#line hidden
                BeginContext(2494, 18, true);
                WriteLiteral("\n    </table>\n   \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.GamePageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
