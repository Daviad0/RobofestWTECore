#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b5901254c3572daf120f8f62e5417a9c756902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatches), @"mvc.1.0.view", @"/Views/Team/TeamMatches.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/TeamMatches.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatches))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b5901254c3572daf120f8f62e5417a9c756902", @"/Views/Team/TeamMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTECore.Models.ViewModels.TeamMatchDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 248, true);
            WriteLiteral("\n<h1>Team Matches</h1>\n<div>\r\n    <input type=\"button\" class=\"btn btn-success\" id=\"listallteams\" value=\"Save Changes\" />\r\n    <input type=\"button\" class=\"btn btn-danger\" id=\"discardchanges\" value=\"Discard Changes\" />\r\n    <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 308, "\"", 353, 1);
#line 7 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 315, Url.Action("TeamMatchesEdit", "Team"), 315, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(354, 85, true);
            WriteLiteral(">Edit Match Status</a>\r\n    <input type=\"number\" class=\"input-lg\" id=\"numberoffields\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 439, "\"", 463, 1);
#line 8 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 447, Model.NumFields, 447, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(464, 19, true);
            WriteLiteral(" />\r\n</div>\n<br />\n");
            EndContext();
#line 11 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
   int i = 0;

#line default
#line hidden
#line 12 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
 foreach (var match in Model.Matches.OrderBy(m => m.MatchID).ThenBy(m => m.Order))
        {
            i++;
            string idtoinput = i.ToString() + "-" + match.Order;
            string idtoinputbutton = i.ToString() + "-" + match.Order + "-add";
            string idtoinputteam = i.ToString() + "-" + match.Order + "-team";
            string idtoinputbuttonremove = i.ToString() + "-" + match.Order + "-remove";
            string idtoinputround = i.ToString() + "-" + match.Order + "-round";
            string idtoinputcompleted = i.ToString() + "-" + match.Order + "-completed";
            string idtoinputrerun = i.ToString() + "-" + match.Order + "-rerun";
            string idtoinputtestmatch = i.ToString() + "-" + match.Order + "-testmatch";
            string idtoinputparentc = i.ToString() + "-" + match.Order + "-parentcomp";
            string idtoinputparentt = i.ToString() + "-" + match.Order + "-parenttest";
            string idtoinputparentr = i.ToString() + "-" + match.Order + "-parentrerun";

#line default
#line hidden
            BeginContext(1526, 116, true);
            WriteLiteral("<div style=\"background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1642, "\"", 1657, 1);
#line 26 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1647, idtoinput, 1647, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1658, 71, true);
            WriteLiteral(" class=\"matchentry\">\r\n    <input type=\"text\" class=\"teamentry input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1729, "\"", 1754, 1);
#line 27 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1737, match.TeamNumber, 1737, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1755, 40, true);
            WriteLiteral(" maxlength=\"7\" placeholder=\"Team Number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1795, "\"", 1814, 1);
#line 27 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1800, idtoinputteam, 1800, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1815, 50, true);
            WriteLiteral(" />\r\n    <input type=\"button\" class=\"btn addafter\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1865, "\"", 1886, 1);
#line 28 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1870, idtoinputbutton, 1870, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1887, 79, true);
            WriteLiteral(" value=\"Add Another Below\" />\r\n    <input type=\"button\" class=\"btn removeentry\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1966, "\"", 1993, 1);
#line 29 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1971, idtoinputbuttonremove, 1971, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1994, 41, true);
            WriteLiteral(" value=\"Delete This Entry\" />\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2035, "\"", 2056, 1);
#line 30 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2041, idtoinputround, 2041, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2057, 59, true);
            WriteLiteral(">Round #</label>\r\n    <input type=\"number\" class=\"input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2116, "\"", 2139, 1);
#line 31 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2124, match.RoundNum, 2124, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2140, "\"", 2160, 1);
#line 31 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2145, idtoinputround, 2145, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2161, 43, true);
            WriteLiteral(" placeholder=\"Round #\" max=\"2\" min=\"1\" />\r\n");
            EndContext();
#line 32 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Completed == true)
    {

#line default
#line hidden
            BeginContext(2246, 83, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:dimgray;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2329, "\"", 2351, 1);
#line 34 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2334, idtoinputparentc, 2334, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2352, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2406, "\"", 2430, 1);
#line 35 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2411, idtoinputcompleted, 2411, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2431, 47, true);
            WriteLiteral(" checked />Status Completed\r\n        </label>\r\n");
            EndContext();
#line 37 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else if (match.Completed == false)
    {

#line default
#line hidden
            BeginContext(2532, 86, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:darkorange;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2618, "\"", 2640, 1);
#line 40 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2623, idtoinputparentc, 2623, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2641, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2695, "\"", 2719, 1);
#line 41 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2700, idtoinputcompleted, 2700, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2720, 39, true);
            WriteLiteral(" />Status Completed\r\n        </label>\r\n");
            EndContext();
#line 43 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(2766, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 44 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Test == true)
    {

#line default
#line hidden
            BeginContext(2803, 84, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:deeppink;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2887, "\"", 2909, 1);
#line 46 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2892, idtoinputparentt, 2892, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2910, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2964, "\"", 2988, 1);
#line 47 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2969, idtoinputtestmatch, 2969, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2989, 41, true);
            WriteLiteral(" checked />Test Match\r\n        </label>\r\n");
            EndContext();
#line 49 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3054, 83, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:dimgray;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3137, "\"", 3159, 1);
#line 52 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3142, idtoinputparentt, 3142, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3160, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3214, "\"", 3238, 1);
#line 53 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3219, idtoinputtestmatch, 3219, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3239, 33, true);
            WriteLiteral(" />Test Match\r\n        </label>\r\n");
            EndContext();
#line 55 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(3279, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 56 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Rerun == true)
    {

#line default
#line hidden
            BeginContext(3317, 87, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:forestgreen;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3404, "\"", 3426, 1);
#line 58 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3409, idtoinputparentr, 3409, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3427, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3481, "\"", 3501, 1);
#line 59 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3486, idtoinputrerun, 3486, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3502, 36, true);
            WriteLiteral(" checked />Rerun\r\n        </label>\r\n");
            EndContext();
#line 61 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3562, 83, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:dimgray;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3645, "\"", 3667, 1);
#line 64 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3650, idtoinputparentr, 3650, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3668, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3722, "\"", 3742, 1);
#line 65 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3727, idtoinputrerun, 3727, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3743, 28, true);
            WriteLiteral(" />Rerun\r\n        </label>\r\n");
            EndContext();
#line 67 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(3778, 15, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\n");
            EndContext();
#line 73 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
}

#line default
#line hidden
            BeginContext(3795, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ae995d6a92e4b9595e897ca3b758f2f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3856, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3857, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a14a282692047798f4cb4cc3894371e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3908, 3453, true);
            WriteLiteral(@"
<script>
    var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
    var i = 0;
    var reloads = 0;
    chat.on(""reloadRequired"", function () {
        reloads += 1
        if (reloads >= i) {
            location.reload(true)
        }
    });
    chat.start().then(function () {
        var scheduler = {
            ""schedules"" : []
        }
        $(document).on('click', '#listallteams', function () {
            
            chat.invoke(""clearSchedule"");
            $("".matchentry"").each(function () {
                i += 1;
                var localid = this.id
                var numfields = parseInt($(""#numberoffields"").val())
                var schedule = {

                };
                schedule.TeamNumber = $(this).children(""#"" + localid + ""-team"").val();
                schedule.RoundNum = $(this).children(""#"" + localid + ""-round"").val();
                schedule.CompID = 1;
                schedule.Order = i;
                schedule.Rerun = $(""#"" + localid + ""-re");
            WriteLiteral(@"run"").is("":checked"");
                schedule.Test = $(""#"" + localid + ""-testmatch"").is("":checked"");
                schedule.Completed = $(""#"" + localid + ""-completed"").is("":checked"");
                scheduler.schedules.push(schedule);
                completedschedule = JSON.stringify(schedule);
                chat.invoke(""changeMatches"", completedschedule, numfields);
            });
            
        });
        $(document).on('click', '.addafter', function () {
            var clearedstring = this.id.replace(""-add"", """");
            $(""#"" + clearedstring + ""-add"").attr(""disabled"", true)
            var newid = clearedstring.split(""-"")
            var newidstring = newid[0] + ""-"" + (parseInt(newid[1]) + 1)
            $(""<div style='background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px' id='"" + newidstring + ""' class='matchentry'><input type='text' class='teamentry input-sm' value='EMPTY' maxlength='7' placeholder='Team Number' id='"" + newidstring + """);
            WriteLiteral(@"-team' style='margin-right:4px'/><input type='button' class='btn addafter' id='"" + newidstring + ""-add' value='Add Another Below' style='margin-right:4px'/><input type='button' class='btn removeentry' id='"" + newidstring + ""-remove' value='Delete This Entry' placeholder='Round #' style='margin-right:4px'/><label for='"" + newidstring + ""-round' style='margin-right:4px'>Round #</label><input type='number' class='input-sm' id='"" + newidstring + ""-round' value=1 max='2' min='1' style='margin-right:4px'/><label class='checkbox-inline' style='background-color:darkorange;color:white'><input type='checkbox' class='checkbox' id='"" + newidstring + ""-completed' />Status Completed</label><label class='checkbox-inline' style='background-color:dimgray;color:white'><input type='checkbox' class='checkbox' id='"" + newidstring + ""-testmatch' />Test Match</label><label class='checkbox-inline' style='background-color:dimgray;color:white'><input type='checkbox' class='checkbox' id='"" + newidstring + ""-rerun' />Rerun</label></div>");
            WriteLiteral(@""").insertAfter(""#"" + clearedstring)
        });
        $(document).on('click', '.removeentry', function () {
            var clearedstring = this.id.replace(""-remove"", """");
            $(""#"" + clearedstring).remove();
        });
        $(""#discardchanges"").on(""click"", function () {
            location.reload(true);
        });
        //
    
    
        
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTECore.Models.ViewModels.TeamMatchDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
