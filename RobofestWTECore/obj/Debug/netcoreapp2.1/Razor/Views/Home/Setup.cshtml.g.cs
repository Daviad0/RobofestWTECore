#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4f1c4bcdff07597a1a0b9283535ceebaf5ea4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Home.Views_Home_Setup), @"mvc.1.0.view", @"/Views/Home/Setup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Setup.cshtml", typeof(RobofestWTECore.Pages.Home.Views_Home_Setup))]
namespace RobofestWTECore.Pages.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4f1c4bcdff07597a1a0b9283535ceebaf5ea4e", @"/Views/Home/Setup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Setup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.SetupPageModel>
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
#line 2 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
  
    ViewData["Title"] = "Setup";

#line default
#line hidden
            BeginContext(83, 217, true);
            WriteLiteral("<style>\r\n    .protectedpassword{\r\n        color:black;\r\n        background-color:black;\r\n    }\r\n    .protectedpassword:hover{\r\n        color:white;\r\n    }\r\n</style>\r\n<h2>Robofest Scoring Online (RSO) Setup Page</h2>\r\n");
            EndContext();
#line 15 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#line 17 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
     if (Model.SetupCompleted == true)
    {

#line default
#line hidden
            BeginContext(387, 283, true);
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>Username</th>
                    <th>Email to Sign-In</th>
                    <th>Password (Hover to Reveal)</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 28 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
                 foreach (var account in Model.Accounts)
                {

#line default
#line hidden
            BeginContext(747, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(802, 16, false);
#line 31 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
                       Write(account.Username);

#line default
#line hidden
            EndContext();
            BeginContext(818, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(854, 13, false);
#line 32 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
                       Write(account.Email);

#line default
#line hidden
            EndContext();
            BeginContext(867, 53, true);
            WriteLiteral("</td>\r\n                        <td><input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 920, "\"", 950, 1);
#line 33 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
WriteAttributeValue("", 928, account.PublicPasskey, 928, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(951, 108, true);
            WriteLiteral(" style=\"font-family:Consolas\" class=\"input-sm protectedpassword\" disabled></td>\r\n                    </tr>\r\n");
            EndContext();
#line 35 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
                }

#line default
#line hidden
            BeginContext(1078, 268, true);
            WriteLiteral(@"                <tr>
                    <td></td>
                    <td></td>
                    <td><input type=""button"" id=""showhideall"" value=""Show All Passwords"" class=""btn btn-danger"" /></td>
                </tr>
            </tbody>
        </table>
");
            EndContext();
#line 43 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1370, 825, true);
            WriteLiteral(@"        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon"">
                <span>Competition Password</span>
            </span>
            <input type=""password"" id=""password"" placeholder=""##############################"" class=""form-control"" style=""z-index:0"" />
        </div>
        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon"">
                <span>Competition ID</span>
            </span>
            <input type=""number"" id=""compid"" value=""1"" class=""form-control"" style=""z-index:0"" />
        </div>
        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon"">
                <span>Your UserID</span>
            </span>
            <input type=""text"" id=""userid""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2195, "\"", 2222, 1);
#line 62 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
WriteAttributeValue("", 2203, User.Identity.Name, 2203, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2223, 2137, true);
            WriteLiteral(@" class=""form-control"" style=""z-index:0"" disabled />
        </div>
        <h3 style=""text-align:center"">Account Details</h3>
        <p style=""text-align:center"">Remember, you can still add more later on!</p>
        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon"" style=""background-color:blue;color:white"">
                <span># of Preset Judges</span>
            </span>
            <input type=""number"" id=""judges"" value=""6"" class=""form-control"" style=""z-index:0"" max=""12"" min=""0"" />
        </div>
        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon"" style=""background-color:cornflowerblue;color:white"">
                <span># of Field Staff</span>
            </span>
            <input type=""number"" id=""fieldstaff"" value=""5"" class=""form-control"" style=""z-index:0"" max=""20"" min=""0"" />
        </div>
        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon""");
            WriteLiteral(@" style=""background-color:darkorchid;color:white"">
                <span># of Managers</span>
            </span>
            <input type=""number"" id=""managers"" value=""1"" class=""form-control"" style=""z-index:0"" max=""5"" min=""0"" />
        </div>
        <div class=""input-group"" style=""margin-top:10px"">
            <span class=""input-group-addon"" style=""background-color:hotpink;color:white"">
                <span># of Tech</span>
            </span>
            <input type=""number"" id=""tech"" value=""2"" class=""form-control"" style=""z-index:0"" max=""5"" min=""0"" />
        </div>
        <input type=""button"" class=""btn btn-warning"" style=""width:100%;margin-top:10px"" value=""Setup Match"" id=""setupmatch"" />
        <div class=""container"">
            <p id=""progresslabel"">Progress Bar With Label</p>
            <div class=""progress"">
                <div class=""progress-bar"" id=""progressbar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width:0%"">
                    0%
");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <p id=\"status\"></p>\r\n");
            EndContext();
#line 100 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
    }

#line default
#line hidden
#line 100 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(4381, 78, true);
            WriteLiteral("    <p style=\"color:red\">You must be signed in to setup the competition!</p>\r\n");
            EndContext();
#line 106 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Setup.cshtml"
}

#line default
#line hidden
            BeginContext(4462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4464, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4fba2f3368d4ceba133df65c39e00e7", async() => {
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
            BeginContext(4525, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4527, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59209bb4ca04a57a286110b6524da5a", async() => {
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
            BeginContext(4578, 1973, true);
            WriteLiteral(@"
<script>
    $(function () {
        var showingall = false;
        // Reference the auto-generated proxy for the hub.

        var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
        // Create a function that the hub can call back to display messages.
        chat.on(""setupSuccess"", function () {
            $(""#status"").css(""color"", ""green"");
            $(""#status"").html(""Setup has been completed! You are now an administrator!"");

        });
        chat.on(""setupFailure"", function () {
            $(""#status"").css(""color"", ""red"");
            $(""#status"").html(""Setup failed! Your password is incorrect!"");
        });
        chat.on(""setupProgress"", function (percent, message) {
            $(""#progresslabel"").html(message);
            $(""#progressbar"").css(""width"", (percent + ""%""));
            $(""#progressbar"").html((percent + ""%""));
            $(""#progressbar"").attr(""aria-valuenow"", percent);
        });
        chat.start().then(function () {
  ");
            WriteLiteral(@"          $(""#setupmatch"").click(function () {
                $(""#status"").css(""color"", ""black"");
                $(""#status"").html("""");
                chat.invoke(""setupMatch"", $(""#password"").val(), $(""#userid"").val(), parseInt($(""#compid"").val()), parseInt($(""#judges"").val()), parseInt($(""#fieldstaff"").val()), parseInt($(""#managers"").val()), parseInt($(""#tech"").val()))
            })
            $(""#showhideall"").click(function () {
                if (showingall == false) {
                    $("".protectedpassword"").css(""color"", ""white"")
                    $(""#showhideall"").val(""Hide All Passwords"")
                    showingall == true;
                } else {
                    $("".protectedpassword"").css(""color"", ""black"")
                    $(""#showhideall"").val(""Show All Passwords"")
                    showingall == false;
                }
                
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.SetupPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
