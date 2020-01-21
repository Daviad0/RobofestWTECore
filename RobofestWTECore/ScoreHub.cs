using System;
using System.Linq;
using RobofestWTECore.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using RobofestWTECore.Models;
using RobofestWTE.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RobofestWTECore
{
    public class ScoreHub : Hub
    {
        private readonly GameContext db;
        private readonly ApplicationDbContext context;
        private readonly IHubContext<ScoreHub> _hubContext;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;

        public ScoreHub(ApplicationDbContext context, GameContext db, IHubContext<ScoreHub> hubContext, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager2)
        {
            this.context = context;
            this.db = db;
            _hubContext = hubContext;
            userManager = userManager2;
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
        public async Task ChangeMatches(string jsonrequired)
        {
            TeamMatch Match = JsonConvert.DeserializeObject<TeamMatch>(jsonrequired);
            await db.TeamMatches.AddAsync(Match);
            await db.SaveChangesAsync();
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
        public void StopTimer()
        {
            Clients.All.SendAsync("stopGlobalTimer");
        }
        public void InitField(int field, int status, int score, string teamnumber, bool connection, bool matchkeeper)
        {
            Clients.All.SendAsync("initFieldView",field, status, score, teamnumber, connection, matchkeeper);
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
        public void MatchMaker(int teamid1, int teamid2, int teamid3, int teamid4, int teamid5, int teamid6, int compid, int round)
        {
            //COMPID = 1 for DEMO
            var competition = (from c in db.Competitions where c.CompID == 1 select c).FirstOrDefault();
            competition.field1preferred = teamid1;
            competition.field2preferred = teamid2;
            competition.field3preferred = teamid3;
            competition.field4preferred = teamid4;
            competition.field5preferred = teamid5;
            competition.field6preferred = teamid6;
            db.Competitions.Update(competition);
            db.SaveChanges();
            Clients.All.SendAsync("availableSelections", teamid1, teamid2, teamid3, teamid4, teamid5, teamid6, round);
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
        
        public Task ThrowException()
        {
            throw new HubException("This error will be sent to the client!");
        }
    }
}