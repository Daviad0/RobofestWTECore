#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0df6470bffe177d18dcffd6c77b9cdc82a69676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Index.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0df6470bffe177d18dcffd6c77b9cdc82a69676", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IOrderedEnumerable<RobofestWTE.Models.TeamDataModel>>
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(100, 2261, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "103f222b8bb94ebb979ee992108c8b56", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50b5ddcbef14383b3f48af1e55312a4", async() => {
>>>>>>> f3579c9b3cb15ecb107d8444ee46fbedffe400c3
                BeginContext(106, 888, true);
                WriteLiteral(@"
    <h2>Team Management</h2>

    <table class=""table table-hover"">
        <tr style=""font-size:20px"">
            <th style=""background-color:#ffffff"">
                Team #
            </th>
            <th style=""background-color:#ffffff"">
                Team Name
            </th>
            <th style=""background-color:#ffd1ba"">
                R1 Score
            </th>
            <th style=""background-color:#ffd1ba"">
                R1 Time
            </th>
            <th style=""background-color:#fffaba"">
                R2 Score
            </th>
            <th style=""background-color:#fffaba"">
                R2 Time
            </th>
            <th style=""background-color:#ffffff"">
                Average
            </th>
            <th style=""background-color:#ffffff"">
                Options
            </th>
        </tr>
");
                EndContext();
#line 36 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
          
            int i = 0;
        

#line default
#line hidden
                BeginContext(1041, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 39 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
         foreach (var teamDataModel in Model)
        {
            i++;

#line default
#line hidden
                BeginContext(1117, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1178, 60, false);
#line 44 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.TeamNumberBranch));

#line default
#line hidden
                EndContext();
                BeginContext(1238, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(1240, 32, false);
#line 44 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
                                                                             Write(teamDataModel.TeamNumberSpecific);

#line default
#line hidden
                EndContext();
                BeginContext(1272, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1340, 52, false);
#line 47 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.TeamName));

#line default
#line hidden
                EndContext();
                BeginContext(1392, 100, true);
                WriteLiteral("\r\n                </td>\r\n                <td style=\"background-color:#ffd1ba\">\r\n                    ");
                EndContext();
                BeginContext(1493, 55, false);
#line 50 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round1Score));

#line default
#line hidden
                EndContext();
                BeginContext(1548, 100, true);
                WriteLiteral("\r\n                </td>\r\n                <td style=\"background-color:#ffd1ba\">\r\n                    ");
                EndContext();
                BeginContext(1649, 54, false);
#line 53 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round1Time));

#line default
#line hidden
                EndContext();
                BeginContext(1703, 100, true);
                WriteLiteral("\r\n                </td>\r\n                <td style=\"background-color:#fffaba\">\r\n                    ");
                EndContext();
                BeginContext(1804, 55, false);
#line 56 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round2Score));

#line default
#line hidden
                EndContext();
                BeginContext(1859, 100, true);
                WriteLiteral("\r\n                </td>\r\n                <td style=\"background-color:#fffaba\">\r\n                    ");
                EndContext();
                BeginContext(1960, 54, false);
#line 59 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round2Time));

#line default
#line hidden
                EndContext();
                BeginContext(2014, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2082, 56, false);
#line 62 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.RoundAverage));

#line default
#line hidden
                EndContext();
                BeginContext(2138, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2206, 72, false);
#line 65 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = teamDataModel.TeamID }));

#line default
#line hidden
                EndContext();
                BeginContext(2278, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 68 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2333, 21, true);
                WriteLiteral("\r\n    </table>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IOrderedEnumerable<RobofestWTE.Models.TeamDataModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
