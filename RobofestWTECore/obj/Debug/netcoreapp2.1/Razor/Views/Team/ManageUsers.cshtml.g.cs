#pragma checksum "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21767f621918f74b3605ec0bd46ec660481fc03e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21767f621918f74b3605ec0bd46ec660481fc03e", @"/Views/Team/ManageUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0c74960f6b96bae451f4a9058021941d4cf852", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
  
    ViewBag.Title = "Users";

#line default
#line hidden
            BeginContext(81, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(85, 8095, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aef00912a7c1446096c31925dee0babc", async() => {
                BeginContext(91, 437, true);
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
#line 22 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
             foreach (var user in Model)
            {


#line default
#line hidden
                BeginContext(584, 70, true);
                WriteLiteral("                <tr>\n                    <td>\n                        ");
                EndContext();
                BeginContext(655, 13, false);
#line 27 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(668, 50, true);
                WriteLiteral("\n                    </td>\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 718, "\"", 737, 1);
#line 29 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 723, user.UserName, 723, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 738, "\"", 760, 1);
#line 29 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 746, user.UserName, 746, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(761, 2, true);
                WriteLiteral(">\n");
                EndContext();
#line 30 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
                BeginContext(855, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 33 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                         foreach (var role in user.Roles)
                        {
                            i++;
                            if (role == "Judge")
                            {

#line default
#line hidden
                BeginContext(1051, 157, true);
                WriteLiteral("                                <span style=\"background-color:blue;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Judge</span>\n");
                EndContext();
#line 39 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "FieldStaff")
                            {

#line default
#line hidden
                BeginContext(1327, 173, true);
                WriteLiteral("                                <span style=\"background-color:cornflowerblue;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Field Staff</span>\n");
                EndContext();
#line 43 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Manager")
                            {

#line default
#line hidden
                BeginContext(1616, 168, true);
                WriteLiteral("                                <span style=\"background-color:darkorchid;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Management</span>\n");
                EndContext();
#line 47 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Admin")
                            {

#line default
#line hidden
                BeginContext(1898, 161, true);
                WriteLiteral("                                <span style=\"background-color:deeppink;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Admin</span>\n");
                EndContext();
#line 51 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Main")
                            {

#line default
#line hidden
                BeginContext(2172, 166, true);
                WriteLiteral("                                <span style=\"background-color:orange;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Main Account</span>\n");
                EndContext();
#line 55 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Tech")
                            {

#line default
#line hidden
                BeginContext(2451, 170, true);
                WriteLiteral("                                <span style=\"background-color:hotpink;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Website Manager</span>\n");
                EndContext();
#line 59 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Locked")
                            {

#line default
#line hidden
                BeginContext(2736, 156, true);
                WriteLiteral("                                <span style=\"border:2px red dashed;color:red;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Locked</span>\n");
                EndContext();
#line 63 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }

                        }

#line default
#line hidden
                BeginContext(2949, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 66 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                         if (i == 0)
                        {

#line default
#line hidden
                BeginContext(3012, 138, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">Student / Spectator</span>\n");
                EndContext();
#line 69 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(3176, 110, true);
                WriteLiteral("                    </td>\n                    <td>\n                        <button type=\"button\" class=\"judge\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3286, "\"", 3303, 1);
#line 72 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3291, user.UserID, 3291, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3304, "\"", 3326, 1);
#line 72 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3312, user.UserName, 3312, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3327, 77, true);
                WriteLiteral(">Judge</button>\n                        <button type=\"button\" class=\"manager\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3404, "\"", 3421, 1);
#line 73 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3409, user.UserID, 3409, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3422, "\"", 3444, 1);
#line 73 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3430, user.UserName, 3430, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3445, 82, true);
                WriteLiteral(">Manager</button>\n                        <button type=\"button\" class=\"fieldstaff\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3527, "\"", 3544, 1);
#line 74 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3532, user.UserID, 3532, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3545, "\"", 3567, 1);
#line 74 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3553, user.UserName, 3553, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3568, 81, true);
                WriteLiteral(">Field Staff</button>\n                        <button type=\"button\" class=\"admin\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3649, "\"", 3666, 1);
#line 75 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3654, user.UserID, 3654, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3667, "\"", 3689, 1);
#line 75 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3675, user.UserName, 3675, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3690, 74, true);
                WriteLiteral(">Admin</button>\n                        <button type=\"button\" class=\"tech\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3764, "\"", 3781, 1);
#line 76 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3769, user.UserID, 3769, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3782, "\"", 3804, 1);
#line 76 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3790, user.UserName, 3790, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3805, 86, true);
                WriteLiteral(">Website Manager</button>\n                        <button type=\"button\" class=\"banned\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3891, "\"", 3908, 1);
#line 77 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3896, user.UserID, 3896, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3909, 39, true);
                WriteLiteral(" style=\"background-color:palevioletred\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3948, "\"", 3970, 1);
#line 77 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 3956, user.UserName, 3956, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3971, 67, true);
                WriteLiteral(">Lock Out</button>\n                    </td>\n                </tr>\n");
                EndContext();
#line 80 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
            }

#line default
#line hidden
                BeginContext(4052, 456, true);
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
#line 98 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
             foreach (var user in Model.Where(u => u.Roles.Contains("Judge")))
            {


#line default
#line hidden
                BeginContext(4602, 70, true);
                WriteLiteral("                <tr>\n                    <td>\n                        ");
                EndContext();
                BeginContext(4673, 13, false);
#line 103 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4686, 50, true);
                WriteLiteral("\n                    </td>\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4736, "\"", 4755, 1);
#line 105 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 4741, user.UserName, 4741, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 4756, "\"", 4778, 1);
#line 105 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 4764, user.UserName, 4764, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4779, 2, true);
                WriteLiteral(">\n");
                EndContext();
#line 106 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                           int j = 0;

#line default
#line hidden
                BeginContext(4820, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 107 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                         foreach (var role in user.Roles)
                        {
                            
                            if (role == "Field1")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5050, 124, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid red\">Field 1</span>\n");
                EndContext();
#line 114 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Field2")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5326, 129, true);
                WriteLiteral("                                <span style=\"color: black;padding: 3px;border-radius: 2px;border: 2px solid blue\">Field 2</span>\n");
                EndContext();
#line 119 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Field3")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5607, 126, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid green\">Field 3</span>\n");
                EndContext();
#line 124 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Field4")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5885, 127, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid orange\">Field 4</span>\n");
                EndContext();
#line 129 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Field5")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6164, 129, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid deeppink\">Field 5</span>\n");
                EndContext();
#line 134 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "Field6")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6445, 126, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid black\">Field 6</span>\n");
                EndContext();
#line 139 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }
                            else if (role == "AllFields")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6726, 141, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;background-color:mediumspringgreen\">All Fields</span>\n");
                EndContext();
#line 144 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                            }


                        }

#line default
#line hidden
                BeginContext(6925, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 148 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                         if (j == 0)
                        {

#line default
#line hidden
                BeginContext(6988, 137, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">No Assigned Fields</span>\n");
                EndContext();
#line 151 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(7151, 112, true);
                WriteLiteral("                    </td>\n                    <td>\n                        <button type=\"button\" class=\"field1a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7263, "\"", 7280, 1);
#line 154 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7268, user.UserID, 7268, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7281, "\"", 7303, 1);
#line 154 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7289, user.UserName, 7289, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7304, 79, true);
                WriteLiteral(">Field 1</button>\n                        <button type=\"button\" class=\"field2a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7383, "\"", 7400, 1);
#line 155 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7388, user.UserID, 7388, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7401, "\"", 7423, 1);
#line 155 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7409, user.UserName, 7409, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7424, 79, true);
                WriteLiteral(">Field 2</button>\n                        <button type=\"button\" class=\"field3a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7503, "\"", 7520, 1);
#line 156 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7508, user.UserID, 7508, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7521, "\"", 7543, 1);
#line 156 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7529, user.UserName, 7529, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7544, 79, true);
                WriteLiteral(">Field 3</button>\n                        <button type=\"button\" class=\"field4a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7623, "\"", 7640, 1);
#line 157 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7628, user.UserID, 7628, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7641, "\"", 7663, 1);
#line 157 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7649, user.UserName, 7649, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7664, 79, true);
                WriteLiteral(">Field 4</button>\n                        <button type=\"button\" class=\"field5a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7743, "\"", 7760, 1);
#line 158 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7748, user.UserID, 7748, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7761, "\"", 7783, 1);
#line 158 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7769, user.UserName, 7769, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7784, 79, true);
                WriteLiteral(">Field 5</button>\n                        <button type=\"button\" class=\"field6a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7863, "\"", 7880, 1);
#line 159 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7868, user.UserID, 7868, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7881, "\"", 7903, 1);
#line 159 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 7889, user.UserName, 7889, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7904, 122, true);
                WriteLiteral(">Field 6</button>\n                        <button type=\"button\" class=\"fieldaa\" style=\"background-color:mediumspringgreen\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 8026, "\"", 8043, 1);
#line 160 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 8031, user.UserID, 8031, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8044, "\"", 8066, 1);
#line 160 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
WriteAttributeValue("", 8052, user.UserName, 8052, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8067, 69, true);
                WriteLiteral(">All Fields</button>\n                    </td>\n                </tr>\n");
                EndContext();
#line 163 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/ManageUsers.cshtml"
            }

#line default
#line hidden
                BeginContext(8150, 23, true);
                WriteLiteral("\n        </table>\n\n    ");
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
            BeginContext(8180, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(8181, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7111b880784e1eb557918cbb1cbfbc", async() => {
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
            BeginContext(8242, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(8243, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2851f6253264d1eb9b4bc9025106825", async() => {
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
            BeginContext(8294, 2689, true);
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
                chat.invoke(""updateUserRoleAsync"", username, ""Admin"");");
            WriteLiteral(@"
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
                var username = $(this).val();
                chat.");
            WriteLiteral(@"invoke(""updateUserRoleAsync"", username, ""Field4"");
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
