#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7faab41c8bab9b7b258cbdf4189df6959b9ad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_Details), @"mvc.1.0.view", @"/Views/Team/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Details.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7faab41c8bab9b7b258cbdf4189df6959b9ad4", @"/Views/Team/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.TeamDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 53, true);
            WriteLiteral("\r\n<br />\r\n<div id=\"outer\">\r\n    <div class=\"inner\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 97, "\"", 157, 1);
#line 5 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
WriteAttributeValue("", 104, Url.Action("Competition", new { id = Model.CompID }), 104, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(158, 223, true);
            WriteLiteral(" style=\"display:inline;padding-right:10px\"><input type=\"button\" class=\"btn btn-warning\" style=\"width:50vw;height:7vw;font-size:2vw;display:inline-block;font-family:Calibri\" value=\"Back to Competition\" /></a></div>\r\n</div>\r\n");
            EndContext();
            BeginContext(381, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f32b2813f54d41659af27076751304c0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 440, true);
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
<h2 style=""text-align:center"">");
            EndContext();
            BeginContext(908, 40, false);
#line 10 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                         Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(948, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(951, 48, false);
#line 10 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                                                                    Write(Html.DisplayFor(model => model.TeamNumberBranch));

#line default
#line hidden
            EndContext();
            BeginContext(999, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(1001, 24, false);
#line 10 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                                                                                                                      Write(Model.TeamNumberSpecific);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 38, true);
            WriteLiteral(")</h2>\r\n<h3 style=\"text-align:center\">");
            EndContext();
            BeginContext(1064, 40, false);
#line 11 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 37, true);
            WriteLiteral("</h3>\r\n<h3 style=\"text-align:center\">");
            EndContext();
            BeginContext(1142, 37, false);
#line 12 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Coach));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 48, true);
            WriteLiteral("</h3>\r\n<h3 style=\"text-align:center\">Average of ");
            EndContext();
            BeginContext(1228, 44, false);
#line 13 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                                    Write(Html.DisplayFor(model => model.RoundAverage));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 37, true);
            WriteLiteral("</h3>\r\n<h3 style=\"text-align:center\">");
            EndContext();
            BeginContext(1310, 62, false);
#line 14 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                         Write(Html.ActionLink("Edit", "TeamEdit", new { id = Model.TeamID }));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 89, true);
            WriteLiteral("</h3>\r\n<br />\r\n<h2 style=\"text-align:center\">Scores:</h2>\r\n<h4 style=\"text-align:center\">");
            EndContext();
            BeginContext(1462, 73, false);
#line 17 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                         Write(Html.ActionLink("Create Entry", "RoundCreate", new { id = Model.TeamID }));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 18 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
  int i = 0;
    int usable = 0;

#line default
#line hidden
#line 20 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
 foreach (var Round in Model.Round.OrderBy(a => a.Round).ThenBy(a => a.Rerun))
{
    i++;
    if (Round.Usable == true)
    {
        usable++;
    }
}

#line default
#line hidden
            BeginContext(1738, 296, true);
            WriteLiteral(@"
<style>
    .id {
        width: 1%
    }

    #outer {
        width: 100%;
        text-align: center;
    }

    .inner {
        display: inline-block;
    }
</style>
<h5 id=""uvalidation"" style=""text-align:center;color:darkred""></h5>
<script type=""text/javascript"">
    if (");
            EndContext();
            BeginContext(2035, 6, false);
#line 45 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
   Write(usable);

#line default
#line hidden
            EndContext();
            BeginContext(2041, 596, true);
            WriteLiteral(@" > 2) {
        $(""#uvalidation"").html(""Warning: There are more than 2 rounds used for the average. Please edit one entry and deselect 'Usable' to correct this error!"")
    } else {
        $(""#uvalidation"").html("""")
    }
</script>
<table class=""table"">
    <tr style=""font-size:20px"">
        <th class=""id"">ID</th>
        <th>Round #</th>
        <th>Score</th>
        <th>Time</th>
        <th>Score Info (Click link for more info)</th>
        <th>Rerun</th>
        <th>Used for Average</th>
        <th>Last Edited (Comp Time)</th>
        <th>Options</th>
    </tr>

");
            EndContext();
#line 64 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
     foreach (var Round in Model.Round.OrderBy(a => a.EntryID).ThenBy(a => a.Rerun))
    {

#line default
#line hidden
            BeginContext(2730, 92, true);
            WriteLiteral("        <tr style=\"background-color:#ffbeb8\">\r\n            <td class=\"id\">\r\n                ");
            EndContext();
            BeginContext(2823, 13, false);
#line 68 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.EntryID);

#line default
#line hidden
            EndContext();
            BeginContext(2836, 61, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                Round ");
            EndContext();
            BeginContext(2898, 11, false);
#line 71 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                 Write(Round.Round);

#line default
#line hidden
            EndContext();
            BeginContext(2909, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2965, 11, false);
#line 74 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2976, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3032, 10, false);
#line 77 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.Time);

#line default
#line hidden
            EndContext();
            BeginContext(3042, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3098, 10, false);
#line 80 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.Data);

#line default
#line hidden
            EndContext();
            BeginContext(3108, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(3112, 85, false);
#line 80 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
                         Write(Html.ActionLink("See Scoresheet Filled Out", "ScoreInfo", new { id = Round.EntryID }));

#line default
#line hidden
            EndContext();
            BeginContext(3197, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3253, 11, false);
#line 83 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.Rerun);

#line default
#line hidden
            EndContext();
            BeginContext(3264, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3320, 12, false);
#line 86 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.Usable);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3388, 15, false);
#line 89 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Round.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(3403, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3459, 64, false);
#line 92 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
           Write(Html.ActionLink("Edit", "RoundEdit", new { id = Round.EntryID }));

#line default
#line hidden
            EndContext();
            BeginContext(3523, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 95 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(3566, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.TeamDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
