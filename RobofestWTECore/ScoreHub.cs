using System;
using System.Linq;
using RobofestWTECore.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using RobofestWTECore.Models;
using RobofestWTE.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace RobofestWTECore
{
    public class ScoreHub : Hub
    {
        private readonly GameContext db;
        private readonly ApplicationDbContext context;
        private readonly IHubContext<ScoreHub> _hubContext;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public ScoreHub(ApplicationDbContext context, GameContext db, IHubContext<ScoreHub> hubContext, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager2, RoleManager<IdentityRole> roleManager2)
        {
            this.context = context;
            this.db = db;
            _hubContext = hubContext;
            userManager = userManager2;
            roleManager = roleManager2;

        }
        public async Task SetupMatch(string Password, string UserName, int compid, int judges, int fieldstaff, int managers, int tech)
        {
            var CompetitionID = (from c in db.Competitions where c.CompID == compid select c).FirstOrDefault();
            if(CompetitionID.setup == false)
            {
                if (Password == "RobofestWTE")
                {
                        
                    /*IdentityRole judge = new IdentityRole();
                    judge.Name = "Judge";
                    judge.NormalizedName = "JUDGE";
                    judge.Id = "4";
                    IdentityRole field1a = new IdentityRole();
                    field1a.Name = "Field1";
                    field1a.NormalizedName = "FIELD1";
                    field1a.Id = "1001";
                    IdentityRole field2a = new IdentityRole();
                    field2a.Name = "Field2";
                    field2a.NormalizedName = "FIELD2";
                    field2a.Id = "1002";
                    IdentityRole field3a = new IdentityRole();
                    field3a.Name = "Field3";
                    field3a.NormalizedName = "FIELD3";
                    field3a.Id = "1003";
                    IdentityRole field4a = new IdentityRole();
                    field4a.Name = "Field4";
                    field4a.NormalizedName = "FIELD4";
                    field4a.Id = "1004";
                    IdentityRole field5a = new IdentityRole();
                    field5a.Name = "Field5";
                    field5a.NormalizedName = "FIELD5";
                    field5a.Id = "1005";
                    IdentityRole field6a = new IdentityRole();
                    field6a.Name = "Field6";
                    field6a.NormalizedName = "FIELD6";
                    field6a.Id = "1006";
                    IdentityRole allfields = new IdentityRole();
                    field6a.Name = "AllFields";
                    field6a.NormalizedName = "ALLFIELDS";
                    field6a.Id = "1000";
                    IdentityRole admin = new IdentityRole();
                    admin.Name = "Admin";
                    admin.NormalizedName = "ADMIN";
                    admin.Id = "1";
                    IdentityRole techrole = new IdentityRole();
                    techrole.Name = "Tech";
                    techrole.NormalizedName = "TECH";
                    techrole.Id = "-1";
                    IdentityRole managerrole = new IdentityRole();
                    managerrole.Name = "Manager";
                    managerrole.NormalizedName = "MANAGER";
                    managerrole.Id = "2";
                    IdentityRole fieldstaffrole = new IdentityRole();
                    fieldstaffrole.Name = "FieldStaff";
                    fieldstaffrole.NormalizedName = "FIELDSTAFF";
                    fieldstaffrole.Id = "3";
                    IdentityRole locked = new IdentityRole();
                    locked.Name = "Locked";
                    locked.NormalizedName = "LOCKED";
                    locked.Id = "5";
                    await Clients.All.SendAsync("setupProgress", 5, "Roles Created, Uploading...");
                    await roleManager.CreateAsync(judge);
                    Console.WriteLine("Judge Created");
                    await roleManager.CreateAsync(field1a);
                    await roleManager.CreateAsync(field2a);
                    await roleManager.CreateAsync(field3a);
                    await roleManager.CreateAsync(field4a);
                    await roleManager.CreateAsync(field5a);
                    await roleManager.CreateAsync(field6a);
                    await roleManager.CreateAsync(allfields);
                    await roleManager.CreateAsync(admin);
                    await roleManager.CreateAsync(techrole);
                    await roleManager.CreateAsync(managerrole);
                    await roleManager.CreateAsync(fieldstaffrole);
                    await roleManager.CreateAsync(locked);*/
                    
                    await Clients.All.SendAsync("setupProgress", 10, "Roles Uploaded to Database!");
                    System.Threading.Thread.Sleep(5000);
                    
                    await userManager.AddToRoleAsync(context.Users.Where(u => u.UserName == UserName).FirstOrDefault(), "Main");
                    
                    
                    await Clients.All.SendAsync("setupProgress", 20, "Competition Status & User Account Updated!");
                    for (int j = 0;j < judges; j++)
                    {
                        ApplicationUser JudgeToAdd = new ApplicationUser();
                        JudgeToAdd.UserName = "Judge" + (j + 1).ToString();
                        JudgeToAdd.NormalizedUserName = "JUDGE" + (j + 1).ToString();
                        JudgeToAdd.Email = JudgeToAdd.UserName + "@robofest.com";
                        JudgeToAdd.NormalizedEmail = JudgeToAdd.NormalizedUserName = "@ROBOFEST.COM";
                        JudgeToAdd.Id = Guid.NewGuid().ToString();
                        string PublicPass = "J!"+Guid.NewGuid().ToString("n").Substring(0, 8);
                        await userManager.CreateAsync(JudgeToAdd, PublicPass);
                        Console.WriteLine("Test Success");
                        ApplicationUser UserActual = await userManager.FindByEmailAsync(JudgeToAdd.Email);
                        await userManager.AddToRoleAsync(UserActual, "JUDGE");
                        await userManager.AddToRoleAsync(UserActual, "ALLFIELDS");
                        PresetAccount presetAccount = new PresetAccount();
                        presetAccount.CompID = compid;
                        presetAccount.Email = JudgeToAdd.Email;
                        presetAccount.PresetAccoutID = UserActual.Id;
                        presetAccount.PublicPasskey = PublicPass;
                        presetAccount.Username = JudgeToAdd.UserName;
                        await db.PresetAccounts.AddAsync(presetAccount); 
                        await db.SaveChangesAsync();
                    }
                    await Clients.All.SendAsync("setupProgress", 40, "Judge Roles Uploaded to Database!");
                    for (int j = 0; j < fieldstaff; j++)
                    {
                        ApplicationUser FSToAdd = new ApplicationUser();
                        FSToAdd.UserName = "FieldStaff" + (j + 1).ToString();
                        FSToAdd.NormalizedUserName = "FIELDSTAFF" + (j + 1).ToString();
                        //JudgeToAdd.Id = Guid.NewGuid().ToString();
                        FSToAdd.Email = FSToAdd.UserName + "@robofest.com";
                        FSToAdd.NormalizedEmail = FSToAdd.NormalizedUserName = "@ROBOFEST.COM";
                        FSToAdd.Id = Guid.NewGuid().ToString();
                        string PublicPass = "FS!" + Guid.NewGuid().ToString("n").Substring(0, 8);
                        
                        await userManager.CreateAsync(FSToAdd, PublicPass);
                        ApplicationUser UserActual = await userManager.FindByEmailAsync(FSToAdd.Email);
                        await userManager.AddToRoleAsync(UserActual, "FIELDSTAFF");
                        PresetAccount presetAccount = new PresetAccount();
                        presetAccount.CompID = compid;
                        presetAccount.Email = FSToAdd.Email;
                        presetAccount.PresetAccoutID = UserActual.Id;
                        presetAccount.PublicPasskey = PublicPass;
                        presetAccount.Username = FSToAdd.UserName;
                        await db.PresetAccounts.AddAsync(presetAccount);
                        await db.SaveChangesAsync();
                    }
                    await Clients.All.SendAsync("setupProgress", 60, "Field Staff Roles Uploaded to Database!");
                    for (int j = 0; j < managers; j++)
                    {
                        ApplicationUser ManagerToAdd = new ApplicationUser();
                        ManagerToAdd.UserName = "Manager" + (j + 1).ToString();
                        ManagerToAdd.NormalizedUserName = "MANAGER" + (j + 1).ToString();
                        //JudgeToAdd.Id = Guid.NewGuid().ToString();
                        ManagerToAdd.Email = ManagerToAdd.UserName + "@robofest.com";
                        ManagerToAdd.NormalizedEmail = ManagerToAdd.NormalizedUserName = "@ROBOFEST.COM";
                        ManagerToAdd.Id = Guid.NewGuid().ToString();
                        string PublicPass = "M!" + Guid.NewGuid().ToString("n").Substring(0, 8);
                        
                        await userManager.CreateAsync(ManagerToAdd, PublicPass);
                        ApplicationUser UserActual = await userManager.FindByEmailAsync(ManagerToAdd.Email);
                        await userManager.AddToRoleAsync(UserActual, "MANAGER");
                        PresetAccount presetAccount = new PresetAccount();
                        presetAccount.CompID = compid;
                        presetAccount.Email = ManagerToAdd.Email;
                        presetAccount.PresetAccoutID = UserActual.Id;
                        presetAccount.PublicPasskey = PublicPass;
                        presetAccount.Username = ManagerToAdd.UserName;
                        await db.PresetAccounts.AddAsync(presetAccount);
                        await db.SaveChangesAsync();
                    }
                    await Clients.All.SendAsync("setupProgress", 80, "Manager Roles Uploaded to Database!");
                    for (int j = 0; j < tech; j++)
                    {
                        ApplicationUser TechToAdd = new ApplicationUser();
                        TechToAdd.UserName = "Tech" + (j + 1).ToString();
                        TechToAdd.NormalizedUserName = "TECH" + (j + 1).ToString();
                        //JudgeToAdd.Id = Guid.NewGuid().ToString();
                        TechToAdd.Email = TechToAdd.UserName + "@robofest.com";
                        TechToAdd.NormalizedEmail = TechToAdd.NormalizedUserName = "@ROBOFEST.COM";
                        TechToAdd.Id = Guid.NewGuid().ToString();
                        string PublicPass = "T!" + Guid.NewGuid().ToString("n").Substring(0, 8);
                        
                        await userManager.CreateAsync(TechToAdd, PublicPass);
                        ApplicationUser UserActual = await userManager.FindByEmailAsync(TechToAdd.Email);
                        await userManager.AddToRoleAsync(UserActual, "TECH");
                        PresetAccount presetAccount = new PresetAccount();
                        presetAccount.CompID = compid;
                        presetAccount.Email = TechToAdd.Email;
                        presetAccount.PresetAccoutID = UserActual.Id;
                        presetAccount.PublicPasskey = PublicPass;
                        presetAccount.Username = TechToAdd.UserName;
                        await db.PresetAccounts.AddAsync(presetAccount);
                        await db.SaveChangesAsync();
                    }
                    await Clients.All.SendAsync("setupProgress", 99, "Tech Roles Uploaded to Database!");
                    await Clients.All.SendAsync("setupProgress", 100, "RSO Setup Complete!");
                    await Clients.All.SendAsync("setupSuccess");
                    CompetitionID.setup = true;
                    db.Competitions.Update(CompetitionID);
                    await db.SaveChangesAsync();
                }
                else
                {
                    await Clients.All.SendAsync("setupFailure");
                }
            }
            else
            {
                await Clients.All.SendAsync("setupFailure");
            }
            
            
        }
        public void SendTimer(int minutes, int seconds, string message, int status)
        {
            Clients.All.SendAsync("changeGlobalTimer", minutes, seconds, message, status);
            //0 = STOPPED, 1 = RUNNING, 2 = DONE
        }
        public void StartTimer()
        {
            Clients.All.SendAsync("startGlobalTimer");
        }
        public async Task ChangeMatches(string jsonrequired, int fields)
        {
            var CompetitionFields = (from d in db.Competitions where d.CompID == 1 select d).FirstOrDefault();
            CompetitionFields.RunningFields = fields;
            db.Competitions.Update(CompetitionFields);
            TeamMatch Match = JsonConvert.DeserializeObject<TeamMatch>(jsonrequired);
            await db.TeamMatches.AddAsync(Match);
            await db.SaveChangesAsync();
            var amountofmatches = db.TeamMatches.Where(t => t.CompID == 1).Count();
            float matchcountfloat = (float)amountofmatches / (float)CompetitionFields.RunningFields;
            int matchcount = (int)Math.Ceiling(matchcountfloat);
            await Clients.All.SendAsync("addMatches", matchcount);
            await Clients.All.SendAsync("reloadRequired");
        }
        public async Task ClearSchedule()
        {
            var EverythingToClear = (from m in db.TeamMatches where m.CompID == 1 select m).ToList();
            foreach (var match in EverythingToClear)
            {
                db.TeamMatches.Remove(match);
                await db.SaveChangesAsync();
            }

        }
        public async Task SelectThisMatch(int matchtoselect)
        {
            var MatchList = (from m in db.TeamMatches where m.CompID == 1 select m).OrderBy(m => m.MatchID).ThenBy(m => m.Order).ToList();
            var Competition = (from m in db.Competitions where m.CompID == 1 select m).FirstOrDefault();
            var SendBackList = new List<TeamMatch>();
            var skipthismany = (matchtoselect - 1) * Competition.RunningFields;
            foreach(var match in MatchList.Skip(skipthismany).Take(Competition.RunningFields))
            {
                SendBackList.Add(match);
            }
            await Clients.All.SendAsync("theseTeams", SendBackList);
        }
        public async Task CheckIfValid(int match)
        {
            var Competition = (from c in db.Competitions where c.CompID == 1 select c).FirstOrDefault();
            var MatchList = (from m in db.TeamMatches where m.CompID == 1 select m).OrderBy(m => m.MatchID).ThenBy(m => m.Order).ToList();
            var ListToCheck = new List<TeamMatch>();
            var skipthismany = (match - 1) * Competition.RunningFields;
            int[] MatchCheck = { 0, 0, 0, 0, 0, 0 };
            foreach (var matchsort in MatchList.Skip(skipthismany).Take(Competition.RunningFields))
            {
                ListToCheck.Add(matchsort);
            }
            int i = 0;
            foreach(var selectmatch in ListToCheck)
            {
                if (selectmatch.TeamNumber.Contains("-"))
                {
                    var TeamNumberSplit = selectmatch.TeamNumber.Split("-");
                    var CheckToDB = db.StudentTeams.Where(t => t.TeamNumberBranch.ToString() == TeamNumberSplit[0] && t.TeamNumberSpecific.ToString() == TeamNumberSplit[1] && t.CompID == 1).FirstOrDefault();
                    if(CheckToDB != null)
                    {
                        MatchCheck[i] = 1;
                    }
                }
                i++;
            }
            await Clients.All.SendAsync("validate", MatchCheck[0], MatchCheck[1], MatchCheck[2], MatchCheck[3], MatchCheck[4], MatchCheck[5]);
        }
        public async Task EditSpecificSchedule(int matchid, string calltype)
        {
            var SpecificMatch = (from m in db.TeamMatches where m.MatchID == matchid select m).FirstOrDefault();
            if (calltype == "completed")
            {
                if (SpecificMatch.Completed == true)
                {
                    SpecificMatch.Completed = false;
                }
                else
                {
                    SpecificMatch.Completed = true;
                }
            }
            else if (calltype == "testmatch")
            {
                if (SpecificMatch.Test == true)
                {
                    SpecificMatch.Test = false;
                }
                else
                {
                    SpecificMatch.Test = true;
                }
            }
            else if (calltype == "rerun")
            {
                if (SpecificMatch.Rerun == true)
                {
                    SpecificMatch.Rerun = false;
                }
                else
                {
                    SpecificMatch.Rerun = true;
                }
            }
            db.TeamMatches.Update(SpecificMatch);
            await db.SaveChangesAsync();
            await Clients.All.SendAsync("reloadRequired");
        }
        public async Task CompleteAll(bool completed)
        {
            var AllMatches = (from m in db.TeamMatches where m.CompID == 1 select m).ToList();
            foreach(var match in AllMatches)
            {
                if(completed == true)
                {
                    match.Completed = true;
                }
                else
                {
                    match.Completed = false;
                }
                db.TeamMatches.Update(match);
                await db.SaveChangesAsync();
            }
            await Clients.All.SendAsync("reloadRequired");
        }
        public async Task AutoComplete()
        {
            var AllMatches = (from m in db.TeamMatches where m.CompID == 1 select m).ToList();
            foreach(var match in AllMatches)
            {
                if (match.TeamNumber.Contains("-") != true)
                {
                    continue;
                }
                var TeamNumberParsed = match.TeamNumber.Split("-");
                var TeamID = (from t in db.StudentTeams where t.TeamNumberBranch.ToString() == TeamNumberParsed[0] & t.TeamNumberSpecific.ToString() == TeamNumberParsed[1] select t).First().TeamID;
                if(TeamID == 0)
                {
                    continue;
                }
                if(match.RoundNum == 1)
                {
                    var Round1 = (from r in db.RoundEntries where r.TeamID == TeamID & r.Round == 1 select r).FirstOrDefault();
                    if (Round1 != null)
                    {
                        if(Round1.TeamID == TeamID || Round1.Round == match.RoundNum)
                        {
                            match.Completed = true;
                        }
                        
                    }
                }
                else if (match.RoundNum == 2)
                {
                    var Round2 = (from r in db.RoundEntries where r.TeamID == TeamID & r.Round == 2 select r).First();
                    if (Round2 != null)
                    {
                        if (Round2.TeamID != TeamID || Round2.Round != match.RoundNum)
                        {
                            match.Completed = true;
                        }
                    }
                }
                db.TeamMatches.Update(match);
                await db.SaveChangesAsync();
            }
            await Clients.All.SendAsync("reloadRequired");
        }
        public void StopTimer()
        {
            Clients.All.SendAsync("stopGlobalTimer");
        }
        public void InitField(int field, int status, int score, string teamnumber, bool connection, bool matchkeeper, string data)
        {
            Clients.All.SendAsync("initFieldView",field, status, score, teamnumber, connection, matchkeeper, data);
            //0 = NotInit, 1 = NotReady, 2 = Ready
        }
        public void LookUpTeam(int id)
        {

            var teamnumber = (from t in db.StudentTeams where t.TeamID == id select t).FirstOrDefault().TeamNumberBranch + "-" + (from t in db.StudentTeams where t.TeamID == id select t).FirstOrDefault().TeamNumberSpecific;
            if (teamnumber == null)
            {
                teamnumber = "No Team";
            }
            Clients.All.SendAsync("retrieveTeam", teamnumber);
        }
        public void PingField(int field)
        {
            Clients.All.SendAsync("getPong",field);
        }
        public void Pong(int fieldid, string account)
        {
            Clients.All.SendAsync("updateLive", fieldid, account);
        }
        public void SetStage(int stage)
        {
            Clients.All.SendAsync("changeStage", stage);
        }
        public void JudgeHelp(int field, bool helpme)
        {
            Clients.All.SendAsync("helpThisJudge", field, helpme);
        }
        public void ScoreCheck(int field, string data, int score, int roundid, string teamnumber)
        {
            Clients.All.SendAsync("checkThisScore", field, data, score, roundid, teamnumber);
        }
        public void SendBroadcast(string message, bool issue, string sender, bool volunteersonly)
        {
            Clients.All.SendAsync("broadcast", message, issue, sender, volunteersonly);
            Clients.All.SendAsync("chatMessage",message, issue, sender, DateTime.Now, true);
        }
        public void SendMessage(string message, bool issue, string sender)
        {
            Clients.All.SendAsync("chatMessage",message, issue, sender, DateTime.Now, false);
        }
        public void TeamSelected(int TeamID, int field, int round)
        {

            var studentTeam = (from r in db.StudentTeams where r.TeamID == TeamID select r).FirstOrDefault();
            if (round == 1)
            {
                studentTeam.FieldR1 = field;
            }
            else if (round == 2)
            {
                studentTeam.FieldR2 = field;
            }
            db.StudentTeams.Update(studentTeam);
            db.SaveChanges();
            var MatchDataModelSent = new MatchDataModel();
            foreach (var s in db.StudentTeams.ToList())
            {
                var StudentTeam = new StudentTeam();
                var TeamData = db.StudentTeams.Find(s.TeamID);
                StudentTeam.TeamName = TeamData.TeamName;
                StudentTeam.TeamNumberBranch = TeamData.TeamNumberBranch;
                StudentTeam.TeamNumberSpecific = TeamData.TeamNumberSpecific;
                StudentTeam.TeamID = TeamData.TeamID;
                StudentTeam.FieldR1 = TeamData.FieldR1;
                StudentTeam.FieldR2 = TeamData.FieldR2;
                MatchDataModelSent.R1List.Add(StudentTeam);
                MatchDataModelSent.R2List.Add(StudentTeam);
            }
            MatchDataModelSent.R1List = MatchDataModelSent.R1List.Where(a => a.FieldR1 == 0).OrderBy(a => a.TeamNumberBranch).ThenBy(a => a.TeamNumberSpecific).ToList();
            MatchDataModelSent.R2List = MatchDataModelSent.R2List.Where(a => a.FieldR2 == 0).OrderByDescending(a => a.TeamNumberBranch).ThenByDescending(a => a.TeamNumberSpecific).ToList();
            Clients.All.SendAsync("changeList", MatchDataModelSent);
        }
        public void MatchMaker(string teamnum1, string teamnum2, string teamnum3, string teamnum4, string teamnum5, string teamnum6, int compid, int round, bool m1v, bool m2v, bool m3v, bool m4v, bool m5v, bool m6v)
        {
            //COMPID = 1 for DEMO
            var competition = (from c in db.Competitions where c.CompID == 1 select c).FirstOrDefault();
            competition.field1preferred = teamnum1;
            competition.field2preferred = teamnum2;
            competition.field3preferred = teamnum3;
            competition.field4preferred = teamnum4;
            competition.field5preferred = teamnum5;
            competition.field6preferred = teamnum6;
            competition.validmatch1 = m1v;
            competition.validmatch2 = m2v;
            competition.validmatch3 = m3v;
            competition.validmatch4 = m4v;
            competition.validmatch5 = m5v;
            competition.validmatch6 = m6v;
            db.Competitions.Update(competition);
            db.SaveChanges();
            Clients.All.SendAsync("availableSelections", teamnum1, teamnum2, teamnum3, teamnum4, teamnum5, teamnum6, round);
            Clients.All.SendAsync("validateSelections", m1v, m2v, m3v, m4v, m5v, m6v);
        }
        public async System.Threading.Tasks.Task UpdateUserRoleAsync(string UserName, string RoleName)
        {
            bool delete = await userManager.IsInRoleAsync(context.Users.Where(u => u.UserName == UserName).FirstOrDefault(), RoleName);
            if (delete == true)
            {
                await userManager.RemoveFromRoleAsync(context.Users.Where(u => u.UserName == UserName).FirstOrDefault(), RoleName);
            }
            else
            {
                await userManager.AddToRoleAsync(context.Users.Where(u => u.UserName == UserName).FirstOrDefault(), RoleName);
            }
            await Clients.All.SendAsync("reloadUsers");
        }
        public void GoToRC(string teamnum)
        {
            var teamnumbereach = teamnum.Split("-");
            var TeamID = (from t in db.StudentTeams where t.TeamNumberBranch.ToString() == teamnumbereach[0] && t.TeamNumberSpecific.ToString() == teamnumbereach[1] select t).FirstOrDefault();
            Clients.All.SendAsync("sendJudgesToPage", TeamID.TeamID);
        }
        public Task ThrowException()
        {
            throw new HubException("This error will be sent to the client!");
        }
    }
}