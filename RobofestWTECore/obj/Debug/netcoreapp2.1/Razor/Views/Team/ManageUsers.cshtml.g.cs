#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc153e9fac578de8174ce10ce192fb69fe7744e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_ManageUsers), @"mvc.1.0.view", @"/Views/Team/ManageUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/ManageUsers.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_ManageUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc153e9fac578de8174ce10ce192fb69fe7744e8", @"/Views/Team/ManageUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_ManageUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RobofestWTE.Models.UserListModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
  
    ViewBag.Title = "Users";

#line default
#line hidden
            BeginContext(86, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(90, 8256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe0a8cfc81e4cf295d868f8b5aee52f", async() => {
                BeginContext(96, 453, true);
                WriteLiteral(@"
        <h2>Volunteer & Student Management</h2>

        <table class=""table table-hover"">
            <tr style=""font-size:20px"">
                <th style=""background-color:#ffffff"">
                    Username
                </th>
                <th style=""background-color:#ffffff"">
                    Role(s)
                </th>
                <th>
                    Add or Remove
                </th>
            </tr>

");
                EndContext();
#line 22 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
             foreach (var user in Model)
            {


#line default
#line hidden
                BeginContext(608, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(681, 13, false);
#line 27 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(694, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 746, "\"", 765, 1);
#line 29 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 751, user.UserName, 751, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 766, "\"", 788, 1);
#line 29 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 774, user.UserName, 774, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(789, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 30 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
                BeginContext(887, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 33 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         foreach (var role in user.Roles)
                        {
                            i++;
                            if (role == "Judge")
                            {

#line default
#line hidden
                BeginContext(1088, 158, true);
                WriteLiteral("                                <span style=\"background-color:blue;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Judge</span>\r\n");
                EndContext();
#line 39 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "FieldStaff")
                            {

#line default
#line hidden
                BeginContext(1368, 174, true);
                WriteLiteral("                                <span style=\"background-color:cornflowerblue;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Field Staff</span>\r\n");
                EndContext();
#line 43 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Manager")
                            {

#line default
#line hidden
                BeginContext(1661, 169, true);
                WriteLiteral("                                <span style=\"background-color:darkorchid;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Management</span>\r\n");
                EndContext();
#line 47 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Admin")
                            {

#line default
#line hidden
                BeginContext(1947, 162, true);
                WriteLiteral("                                <span style=\"background-color:deeppink;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Admin</span>\r\n");
                EndContext();
#line 51 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Main")
                            {

#line default
#line hidden
                BeginContext(2225, 167, true);
                WriteLiteral("                                <span style=\"background-color:orange;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Main Account</span>\r\n");
                EndContext();
#line 55 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Tech")
                            {

#line default
#line hidden
                BeginContext(2508, 171, true);
                WriteLiteral("                                <span style=\"background-color:hotpink;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Website Manager</span>\r\n");
                EndContext();
#line 59 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Locked")
                            {

#line default
#line hidden
                BeginContext(2797, 157, true);
                WriteLiteral("                                <span style=\"border:2px red dashed;color:red;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Locked</span>\r\n");
                EndContext();
#line 63 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }

                        }

#line default
#line hidden
                BeginContext(3014, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 66 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         if (i == 0)
                        {

#line default
#line hidden
                BeginContext(3079, 139, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">Student / Spectator</span>\r\n");
                EndContext();
#line 69 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(3245, 112, true);
                WriteLiteral("                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"judge\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3357, "\"", 3374, 1);
#line 72 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3362, user.UserID, 3362, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3375, "\"", 3397, 1);
#line 72 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3383, user.UserName, 3383, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3398, 78, true);
                WriteLiteral(">Judge</button>\r\n                        <button type=\"button\" class=\"manager\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3476, "\"", 3493, 1);
#line 73 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3481, user.UserID, 3481, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3494, "\"", 3516, 1);
#line 73 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3502, user.UserName, 3502, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3517, 83, true);
                WriteLiteral(">Manager</button>\r\n                        <button type=\"button\" class=\"fieldstaff\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3600, "\"", 3617, 1);
#line 74 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3605, user.UserID, 3605, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3618, "\"", 3640, 1);
#line 74 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3626, user.UserName, 3626, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3641, 82, true);
                WriteLiteral(">Field Staff</button>\r\n                        <button type=\"button\" class=\"admin\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3723, "\"", 3740, 1);
#line 75 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3728, user.UserID, 3728, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3741, "\"", 3763, 1);
#line 75 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3749, user.UserName, 3749, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3764, 75, true);
                WriteLiteral(">Admin</button>\r\n                        <button type=\"button\" class=\"tech\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3839, "\"", 3856, 1);
#line 76 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3844, user.UserID, 3844, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3857, "\"", 3879, 1);
#line 76 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3865, user.UserName, 3865, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3880, 87, true);
                WriteLiteral(">Website Manager</button>\r\n                        <button type=\"button\" class=\"banned\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3967, "\"", 3984, 1);
#line 77 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3972, user.UserID, 3972, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3985, 39, true);
                WriteLiteral(" style=\"background-color:palevioletred\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4024, "\"", 4046, 1);
#line 77 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 4032, user.UserName, 4032, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4047, 70, true);
                WriteLiteral(">Lock Out</button>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 80 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
            }

#line default
#line hidden
                BeginContext(4132, 473, true);
                WriteLiteral(@"
        </table>

        <h2>Judge Field Assignments</h2>
        <table class=""table table-hover"">
            <tr style=""font-size:20px"">
                <th style=""        background-color: #ffffff"">
                    Username
                </th>
                <th style=""background-color:#ffffff"">
                    Role(s)
                </th>
                <th>
                    Add or Remove
                </th>
            </tr>

");
                EndContext();
#line 98 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
             foreach (var user in Model.Where(u => u.Roles.Contains("Judge")))
            {


#line default
#line hidden
                BeginContext(4702, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4775, 13, false);
#line 103 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4788, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4840, "\"", 4859, 1);
#line 105 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 4845, user.UserName, 4845, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 4860, "\"", 4882, 1);
#line 105 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 4868, user.UserName, 4868, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4883, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 106 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                           int j = 0;

#line default
#line hidden
                BeginContext(4926, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 107 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         foreach (var role in user.Roles)
                        {
                            
                            if (role == "Field1")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5162, 125, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid red\">Field 1</span>\r\n");
                EndContext();
#line 114 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field2")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5443, 130, true);
                WriteLiteral("                                <span style=\"color: black;padding: 3px;border-radius: 2px;border: 2px solid blue\">Field 2</span>\r\n");
                EndContext();
#line 119 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field3")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5729, 127, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid green\">Field 3</span>\r\n");
                EndContext();
#line 124 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field4")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6012, 128, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid orange\">Field 4</span>\r\n");
                EndContext();
#line 129 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field5")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6296, 130, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid deeppink\">Field 5</span>\r\n");
                EndContext();
#line 134 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field6")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6582, 127, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid black\">Field 6</span>\r\n");
                EndContext();
#line 139 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "AllFields")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6868, 142, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;background-color:mediumspringgreen\">All Fields</span>\r\n");
                EndContext();
#line 144 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }


                        }

#line default
#line hidden
                BeginContext(7072, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 148 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         if (j == 0)
                        {

#line default
#line hidden
                BeginContext(7137, 138, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">No Assigned Fields</span>\r\n");
                EndContext();
#line 151 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(7302, 114, true);
                WriteLiteral("                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"field1a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7416, "\"", 7433, 1);
#line 154 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7421, user.UserID, 7421, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7434, "\"", 7456, 1);
#line 154 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7442, user.UserName, 7442, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7457, 80, true);
                WriteLiteral(">Field 1</button>\r\n                        <button type=\"button\" class=\"field2a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7537, "\"", 7554, 1);
#line 155 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7542, user.UserID, 7542, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7555, "\"", 7577, 1);
#line 155 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7563, user.UserName, 7563, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7578, 80, true);
                WriteLiteral(">Field 2</button>\r\n                        <button type=\"button\" class=\"field3a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7658, "\"", 7675, 1);
#line 156 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7663, user.UserID, 7663, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7676, "\"", 7698, 1);
#line 156 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7684, user.UserName, 7684, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7699, 80, true);
                WriteLiteral(">Field 3</button>\r\n                        <button type=\"button\" class=\"field4a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7779, "\"", 7796, 1);
#line 157 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7784, user.UserID, 7784, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7797, "\"", 7819, 1);
#line 157 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7805, user.UserName, 7805, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7820, 80, true);
                WriteLiteral(">Field 4</button>\r\n                        <button type=\"button\" class=\"field5a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7900, "\"", 7917, 1);
#line 158 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7905, user.UserID, 7905, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7918, "\"", 7940, 1);
#line 158 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7926, user.UserName, 7926, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7941, 80, true);
                WriteLiteral(">Field 5</button>\r\n                        <button type=\"button\" class=\"field6a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 8021, "\"", 8038, 1);
#line 159 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8026, user.UserID, 8026, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8039, "\"", 8061, 1);
#line 159 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8047, user.UserName, 8047, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8062, 123, true);
                WriteLiteral(">Field 6</button>\r\n                        <button type=\"button\" class=\"fieldaa\" style=\"background-color:mediumspringgreen\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 8185, "\"", 8202, 1);
#line 160 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8190, user.UserID, 8190, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8203, "\"", 8225, 1);
#line 160 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8211, user.UserName, 8211, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8226, 72, true);
                WriteLiteral(">All Fields</button>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 163 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
            }

#line default
#line hidden
                BeginContext(8313, 26, true);
                WriteLiteral("\r\n        </table>\r\n\r\n    ");
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
            BeginContext(8346, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(8348, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37dd8eaabfa4d689d6bfbe00c6a206e", async() => {
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
            BeginContext(8409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(8411, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0077451c7a94f4eba6d3d1e59209075", async() => {
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
            BeginContext(8462, 2754, true);
            WriteLiteral(@"
<script>
    $(function () {
        // Reference the auto-generated proxy for the hub.
        var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
        chat.on(""reloadUsers"", function (field, helping) {
            location.reload(true);
        });
        chat.start().then(function () {
            $("".judge"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Judge"");
            });
            $("".manager"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Manager"");
            });
            $("".fieldstaff"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""FieldStaff"");
            });
            $("".admin"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsyn");
            WriteLiteral(@"c"", username, ""Admin"");
            });
            $("".tech"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Tech"");
            });
            $("".banned"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Locked"");
            });
            $("".field1a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field1"");
            });
            $("".field2a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field2"");
            });
            $("".field3a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field3"");
            });
            $("".field4a"").click(function () {
                var u");
            WriteLiteral(@"sername = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field4"");
            });
            $("".field5a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field5"");
            });
            $("".field6a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field6"");
            });
            $("".fieldaa"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""AllFields"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RobofestWTE.Models.UserListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
