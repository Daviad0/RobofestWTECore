#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecc63fdc64564cc97ae2b01c24769e19f81bb143"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc63fdc64564cc97ae2b01c24769e19f81bb143", @"/Views/Team/TeamMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RobofestWTE.Models.TeamMatch>>
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
            BeginContext(42, 119, true);
            WriteLiteral("\n<h1>Team Matches</h1>\n<input type=\"button\" class=\"btn btn-success\" id=\"listallteams\" value=\"List All Teams (TEST)\" />\n");
            EndContext();
#line 5 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
   int i = 0;

#line default
#line hidden
#line 6 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
 foreach (var match in Model.OrderBy(m => m.MatchID).ThenBy(m => m.Order))
        {
            i++;
            string idtoinput = i.ToString() + "-" + match.Order;
            string idtoinputbutton = i.ToString() + "-" + match.Order + "-add";
            string idtoinputteam = i.ToString() + "-" + match.Order + "-team";
            string idtoinputbuttonremove = i.ToString() + "-" + match.Order + "-remove";
            string idtoinputround = i.ToString() + "-" + match.Order + "-round";
            string idtoinputcompleted = i.ToString() + "-" + match.Order + "-completed";

#line default
#line hidden
            BeginContext(761, 116, true);
            WriteLiteral("<div style=\"background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 877, "\"", 892, 1);
#line 15 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 882, idtoinput, 882, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(893, 71, true);
            WriteLiteral(" class=\"matchentry\">\r\n    <input type=\"text\" class=\"teamentry input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 964, "\"", 989, 1);
#line 16 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 972, match.TeamNumber, 972, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(990, 40, true);
            WriteLiteral(" maxlength=\"7\" placeholder=\"Team Number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1030, "\"", 1049, 1);
#line 16 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1035, idtoinputteam, 1035, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1050, 50, true);
            WriteLiteral(" />\r\n    <input type=\"button\" class=\"btn addafter\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1100, "\"", 1121, 1);
#line 17 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1105, idtoinputbutton, 1105, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1122, 79, true);
            WriteLiteral(" value=\"Add Another Below\" />\r\n    <input type=\"button\" class=\"btn removeentry\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1201, "\"", 1228, 1);
#line 18 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1206, idtoinputbuttonremove, 1206, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 41, true);
            WriteLiteral(" value=\"Delete This Entry\" />\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1270, "\"", 1291, 1);
#line 19 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1276, idtoinputround, 1276, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1292, 59, true);
            WriteLiteral(">Round #</label>\r\n    <input type=\"number\" class=\"input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1351, "\"", 1374, 1);
#line 20 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1359, match.RoundNum, 1359, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1375, "\"", 1395, 1);
#line 20 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1380, idtoinputround, 1380, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1396, 43, true);
            WriteLiteral(" placeholder=\"Round #\" max=\"2\" min=\"1\" />\r\n");
            EndContext();
#line 21 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Completed == true)
    {

#line default
#line hidden
            BeginContext(1481, 84, true);
            WriteLiteral("        <input type=\"button\" class=\"btn btn-success\" value=\"Completed\" disabled />\r\n");
            EndContext();
#line 24 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else if (match.Completed == false)
    {

#line default
#line hidden
            BeginContext(1619, 88, true);
            WriteLiteral("        <input type=\"button\" class=\"btn btn-warning\" value=\"Not Completed\" disabled />\r\n");
            EndContext();
#line 28 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(1714, 11, true);
            WriteLiteral("\r\n\r\n</div>\n");
            EndContext();
#line 32 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
}

#line default
#line hidden
            BeginContext(1727, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc40da32cfa8406982bbd2cfe3358150", async() => {
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
            BeginContext(1788, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1789, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc221e6be3644deabe7e498252726ce", async() => {
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
            BeginContext(1840, 2571, true);
            WriteLiteral(@"
<script>
    var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
    chat.on(""reloadRequired"", function () {
        location.reload(true);
    });
    chat.start().then(function () {
        var scheduler = {
            ""schedules"" : []
        }
        $(document).on('click', '#listallteams', function () {
            var i = 0;
            chat.invoke(""clearSchedule"");
            $("".matchentry"").each(function () {
                i += 1;
                var localid = this.id
                var schedule = {

                };
                schedule.TeamNumber = $(this).children(""#"" + localid + ""-team"").val();
                schedule.RoundNum = $(this).children(""#"" + localid + ""-round"").val();
                schedule.CompID = 1;
                schedule.Order = i;
                schedule.Rerun = false;
                schedule.Test = false;
                schedule.Completed = false;
                scheduler.schedules.push(schedule);
                completedschedule = JS");
            WriteLiteral(@"ON.stringify(schedule);
                chat.invoke(""changeMatches"", completedschedule);
            });
            
        });
        $(document).on('click', '.addafter', function () {
            var clearedstring = this.id.replace(""-add"", """");
            var newid = clearedstring.split(""-"")
            var newidstring = newid[0] + ""-"" + (parseInt(newid[1]) + 1)
            $(""<div style='background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px' id='"" + newidstring + ""' class='matchentry'><input type='text' class='teamentry input-sm' value='EMPTY' maxlength='7' placeholder='Team Number' id='"" + newidstring + ""-team' style='margin-right:4px'/><input type='button' class='btn addafter' id='"" + newidstring + ""-add' value='Add Another Below' style='margin-right:4px' disabled/><input type='button' class='btn removeentry' id='"" + newidstring + ""-remove' value='Delete This Entry' placeholder='Round #' style='margin-right:4px'/><label for='"" + newidstring + ""-round' ");
            WriteLiteral(@"style='margin-right:4px'>Round #</label><input type='number' class='input-sm' id='"" + newidstring + ""-round' value=1 max='2' min='1' style='margin-right:4px'/><input type=""button"" class=""btn btn - warning"" value=""Not Completed"" disabled /></div>"").insertAfter(""#"" + clearedstring)
        });
        $(document).on('click', '.removeentry', function () {
            var clearedstring = this.id.replace(""-remove"", """");
            $(""#"" + clearedstring).remove();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RobofestWTE.Models.TeamMatch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
