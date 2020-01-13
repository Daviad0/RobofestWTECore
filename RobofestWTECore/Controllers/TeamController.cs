using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using RobofestWTE.Models;
using RobofestWTECore.Data;

namespace RobofestWTECore.Controllers
{
    public class TeamController : Controller
    {
        private readonly GameContext db;

        public TeamController(GameContext db)
        {
            this.db = db;
        }
        private readonly IHubContext<ScoreHub> _hubContext;

        public TeamController(IHubContext<ScoreHub> hubContext)
        {
            _hubContext = hubContext;
        }


        public void UpdateTopTen()
        {
            List<PresentationScoreboardModel> Scoreboard = new List<PresentationScoreboardModel>();
            foreach (var t in db.StudentTeams.Where(a => a.CompID == 1).OrderByDescending(a => a.RoundEntries.Where(b => b.Usable == true).Average(b => b.Score)).ThenBy(a => a.TeamNumberBranch).ThenBy(a => a.TeamNumberSpecific))
            {
                var AverageScore = 0;
                var AddedScore = 0;
                foreach (var r in db.RoundEntries.Where(a => a.TeamID == t.TeamID).Where(a => a.Usable == true))
                {
                    AddedScore++;
                    AverageScore = AverageScore + r.Score;
                }
                if (AddedScore != 0)
                {
                    AverageScore = AverageScore / 2;
                }

                var PresentationScoreboardModel = new PresentationScoreboardModel();
                if (AverageScore != 0)
                {
                    PresentationScoreboardModel.TeamID = t.TeamID;
                    PresentationScoreboardModel.TeamName = t.TeamName;
                    PresentationScoreboardModel.TeamNumberBranch = t.TeamNumberBranch;
                    PresentationScoreboardModel.TeamNumberSpecific = t.TeamNumberSpecific;
                    PresentationScoreboardModel.Average = AverageScore;
                    Scoreboard.Add(PresentationScoreboardModel);
                }

            }
            Scoreboard = Scoreboard.OrderByDescending(p => p.Average).Take(10).ToList();

            this.Clients.All.changeTeamScores(Scoreboard);
        }

        public void StartTimer()
        {
            this.Clients.All.changeGlobalTimer(2, 0);
        }

        public void UpdateScoresheet()
        {
            List<TeamDataModel> TeamDataModels = new List<TeamDataModel>();
            foreach (var t in db.StudentTeams.Where(a => a.CompID == 1).OrderByDescending(a => a.RoundEntries.Where(b => b.Usable == true).Average(b => b.Score)).ThenBy(a => a.TeamNumberBranch).ThenBy(a => a.TeamNumberSpecific))
            {
                TeamDataModel Data = new TeamDataModel();
                Data.TeamID = t.TeamID;
                Data.TeamName = t.TeamName;
                Data.TeamNumberBranch = t.TeamNumberBranch;
                Data.TeamNumberSpecific = t.TeamNumberSpecific;
                var Round1 = (from a in db.RoundEntries where a.TeamID == t.TeamID && a.Usable == true && a.Round == 1 select a).FirstOrDefault();
                if (Round1 != null)
                {
                    Data.Round1Score = Round1.Score;
                    Data.Round1Time = Round1.Time;
                }
                var Round2 = (from a in db.RoundEntries where a.TeamID == t.TeamID && a.Usable == true && a.Round == 2 select a).FirstOrDefault();
                if (Round2 != null)
                {
                    Data.Round2Score = Round2.Score;
                    Data.Round2Time = Round2.Time;
                }

                Data.RoundAverage = Data.Round1Score + Data.Round2Score;
                Data.RoundAverage = Data.RoundAverage / 2;
                Data.ReadyR1 = true;
                Data.ReadyR2 = true;
                TeamDataModels.Add(Data);


            }

            TeamDataModels = TeamDataModels.OrderByDescending(p => p.RoundAverage).ThenBy(p => p.TeamID).ToList();
            this._hubContext.Clients.All.SendAsync("changeScoreboard", TeamDataModels);

        }

        public ActionResult Presentation(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var PresentationViewModel = new PresentationViewModel();
            PresentationViewModel.CompData = (from a in db.Competitions where a.CompID == id select a).FirstOrDefault();
            int i = 0;
            foreach (var t in db.StudentTeams.Where(a => a.CompID == id))
            {
                var AverageScore = 0;
                var Round1Score = (from r in db.RoundEntries where r.TeamID == t.TeamID && r.Round == 1 select r).FirstOrDefault();
                var Round2Score = (from r in db.RoundEntries where r.TeamID == t.TeamID && r.Round == 2 select r).FirstOrDefault();
                if (Round1Score != null)
                {
                    AverageScore += Round1Score.Score;
                }
                if (Round2Score != null)
                {
                    AverageScore += Round2Score.Score;
                }
                if (Round1Score != null || Round2Score != null)
                {
                    AverageScore = AverageScore / 2;
                }

                var PresentationScoreboardModel = new PresentationScoreboardModel();
                if (Round1Score != null || Round2Score != null)
                {
                    PresentationScoreboardModel.TeamID = t.TeamID;
                    PresentationScoreboardModel.TeamName = t.TeamName;
                    PresentationScoreboardModel.TeamNumberBranch = t.TeamNumberBranch;
                    PresentationScoreboardModel.TeamNumberSpecific = t.TeamNumberSpecific;
                    PresentationScoreboardModel.Average = AverageScore;
                    PresentationViewModel.Scoreboard.Add(PresentationScoreboardModel);
                }

            }
            int c = 0;
            foreach (var count in db.StudentTeams.Where(a => a.CompID == id))
            {
                c++;
            }
            PresentationViewModel.TeamCount = c;
            PresentationViewModel.Scoreboard = PresentationViewModel.Scoreboard.OrderByDescending(s => s.Average).ToList();
            return View(PresentationViewModel);
        }

        public ActionResult IsNotAuthenticated()
        {
            return View();
        }
        // GET: Entry
        public ActionResult ManageUsers()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
            {
                var ListofUsers = new List<UserListModel>();
                var accountdb = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(accountdb));
                var Users = accountdb.Users.ToList();
                foreach (var user in Users)
                {
                    var UserModel = new UserListModel();
                    UserModel.UserID = user.Id.ToString();
                    UserModel.UserName = user.Email.ToString();
                    if (UserManager.IsInRoleAsync(user.Id, "Admin"))
                    {
                        UserModel.Roles.Add("Admin");
                    }
                    if (UserManager.IsInRoleAsync(user.Id, "Manager"))
                    {
                        UserModel.Roles.Add("Manager");
                    }
                    if (UserManager.IsInRoleAsync(user.Id, "Judge"))
                    {
                        UserModel.Roles.Add("Judge");
                    }
                    if (UserManager.IsInRoleAsync(user.Id, "FieldStaff"))
                    {
                        UserModel.Roles.Add("Field Staff");
                    }
                    if (UserManager.IsInRoleAsync(user.Id, "Banned"))
                    {
                        UserModel.Roles.Add("Banned");
                    }
                    ListofUsers.Add(UserModel);
                }
                return View(ListofUsers);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
            {


                var TeamDataModelList = new List<TeamDataModel>();
                int i = 0;
                foreach (var s in db.StudentTeams.ToList())
                {
                    i++;
                    var TeamData = db.StudentTeams.Find(s.TeamID);
                    var Round1 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 1 select a).FirstOrDefault();
                    var Round2 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 2 select a).FirstOrDefault();
                    var TeamDataModel = new TeamDataModel();
                    TeamDataModel.TeamName = TeamData.TeamName;
                    TeamDataModel.TeamID = TeamData.TeamID;
                    TeamDataModel.TeamNumberBranch = TeamData.TeamNumberBranch;
                    TeamDataModel.TeamNumberSpecific = TeamData.TeamNumberSpecific;

                    if (Round2 != null && Round1 != null)
                    {
                        TeamDataModel.Round1Score = Round1.Score;
                        TeamDataModel.Round2Score = Round2.Score;
                        TeamDataModel.RoundAverage = (Round1.Score + Round2.Score) / 2;
                    }
                    else if (Round2 != null && Round1 == null)
                    {
                        //Round 1 is null
                        TeamDataModel.Round1Score = 0;
                        TeamDataModel.Round2Score = Round2.Score;
                        TeamDataModel.RoundAverage = Round2.Score / 2;
                    }
                    else if (Round2 == null && Round1 != null)
                    {
                        //Round 2 is null
                        TeamDataModel.Round1Score = Round1.Score;
                        TeamDataModel.Round2Score = 0;
                        TeamDataModel.RoundAverage = Round1.Score / 2;
                    }
                    else if (Round2 == null && Round1 == null)
                    {
                        //Round 2 is null
                        TeamDataModel.Round1Score = 0;
                        TeamDataModel.Round2Score = 0;
                        TeamDataModel.RoundAverage = 0;
                    }

                    TeamDataModelList.Add(TeamDataModel);
                }
                return View(TeamDataModelList.OrderByDescending(a => a.RoundAverage));
            }
            else
            {
                return View("IsNotAuthenticated");
            }


        }
        public ActionResult MatchManager(int id)
        {
            if ((RUser.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                var MatchDataModel = new MatchDataModel();
                var Competition = (from a in db.Competitions where a.CompID == id select a).FirstOrDefault();
                MatchDataModel.RunningFields = Competition.RunningFields;
                int i = 0;
                foreach (var s in db.StudentTeams.ToList())
                {
                    var StudentTeam = new StudentTeam();
                    i++;
                    var TeamData = db.StudentTeams.Find(s.TeamID);
                    StudentTeam.TeamName = TeamData.TeamName;
                    StudentTeam.TeamNumberBranch = TeamData.TeamNumberBranch;
                    StudentTeam.TeamNumberSpecific = TeamData.TeamNumberSpecific;
                    StudentTeam.TeamID = TeamData.TeamID;
                    StudentTeam.FieldR1 = TeamData.FieldR1;
                    StudentTeam.FieldR2 = TeamData.FieldR2;
                    MatchDataModel.R1List.Add(StudentTeam);
                    MatchDataModel.R2List.Add(StudentTeam);
                }


                return View(MatchDataModel);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }
        public ActionResult Competition(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var CompetitionPageModel = new CompetitionPageModel();
            int i = 0;


            //COMPETITION ID CHANGES BASED ON WHATEVER IS PASSED THROUGH CONTROLLER
            //1 IS A TEST VALUE
            var Competition = (from a in db.Competitions where a.CompID == id select a).FirstOrDefault();
            CompetitionPageModel.CompID = Competition.CompID;
            CompetitionPageModel.Date = Competition.Date;
            CompetitionPageModel.Location = Competition.Location;
            CompetitionPageModel.ExtraData = Competition.ExtraData;
            CompetitionPageModel.GameID = Competition.GameID;
            CompetitionPageModel.FieldPreferred.Add(Competition.field1preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field2preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field3preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field4preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field5preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field6preferred);
            int sitem = 0;

            foreach (var s in db.StudentTeams.ToList())
            {
                var TeamData = db.StudentTeams.Find(s.TeamID);
                var Round1 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 1 && a.Usable == true select a).FirstOrDefault();
                var Round2 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 2 && a.Usable == true select a).FirstOrDefault();
                i++;

                var TeamDataModel = new TeamDataModel();
                TeamDataModel.TeamName = TeamData.TeamName;
                TeamDataModel.TeamID = TeamData.TeamID;
                TeamDataModel.TeamNumberBranch = TeamData.TeamNumberBranch;
                TeamDataModel.TeamNumberSpecific = TeamData.TeamNumberSpecific;
                TeamDataModel.Round1Score = 0;
                TeamDataModel.Round2Score = 0;
                if (Round2 != null)
                {
                    TeamDataModel.Round2Score = Round2.Score;
                }
                if (Round1 != null)
                {
                    TeamDataModel.Round1Score = Round1.Score;
                }
                TeamDataModel.RoundAverage = TeamDataModel.Round1Score + TeamDataModel.Round2Score;
                TeamDataModel.RoundAverage = TeamDataModel.RoundAverage / 2;
                CompetitionPageModel.Teams.Add(TeamDataModel);
            }

            return View(CompetitionPageModel);
        }
        public ActionResult GAME(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var GamePageModel = new GamePageModel();

            //GAME ID CHANGES BASED ON WHATEVER IS PASSED THROUGH CONTROLLER
            //1 IS A TEST VALUE
            var GAME = (from a in db.GAMES where a.GameID == id select a).FirstOrDefault();
            //Count the amount of teams
            //Where function will have to change based on competition
            //Create variable "i" to count with each competition so it can find amount of teams attached to each competition
            //Attach "i" to the where function



            GamePageModel.Desc = GAME.Desc;
            GamePageModel.GameID = GAME.GameID;
            GamePageModel.Name = GAME.Name;
            foreach (var c in db.Competitions.Where(a => a.GameID == 1).ToList())
            {
                int i = 0;
                foreach (var s in db.StudentTeams.Where(a => a.CompID == c.CompID))
                {
                    i++;
                }
                var Competition = (from a in db.Competitions where a.CompID == c.CompID select a).FirstOrDefault();
                var CompetitionPageModel = new CompetitionPageModel();
                CompetitionPageModel.CompID = Competition.CompID;
                CompetitionPageModel.Date = Competition.Date;
                CompetitionPageModel.Location = Competition.Location;
                CompetitionPageModel.ExtraData = Competition.ExtraData;
                CompetitionPageModel.TeamCount = i;
                GamePageModel.Competitions.Add(CompetitionPageModel);
            }

            return View(GamePageModel);
        }
        // GET: Entry/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var TeamData = (from a in db.StudentTeams where a.TeamID == id select a).FirstOrDefault();
            var Round1 = (from a in db.RoundEntries where a.TeamID == id && a.Round == 1 select a).FirstOrDefault();
            var Round2 = (from a in db.RoundEntries where a.TeamID == id && a.Round == 2 select a).FirstOrDefault();
            var TeamDetailsModel = new TeamDetailsModel();
            TeamDetailsModel.TeamName = TeamData.TeamName;
            TeamDetailsModel.TeamID = TeamData.TeamID;
            TeamDetailsModel.TeamNumberBranch = TeamData.TeamNumberBranch;
            TeamDetailsModel.TeamNumberSpecific = TeamData.TeamNumberSpecific;
            TeamDetailsModel.Location = TeamData.Location;
            TeamDetailsModel.Coach = TeamData.Coach;
            TeamDetailsModel.CompID = TeamData.CompID;
            int i = 0;
            int average = 0;
            //bool R1Rerun = false;
            //bool R2Rerun = false;
            foreach (var round in db.RoundEntries.Where(a => a.TeamID == id && a.Rerun == true).OrderBy(a => a.Round).ToList())
            {
                i++;
                var Round = (from a in db.RoundEntries where a.TeamID == id && a.Round == round.Round && a.Rerun == round.Rerun select a).FirstOrDefault();
                if (Round.Usable == true)
                {
                    average = average + Round.Score;
                }
                TeamDetailsModel.Round.Add(Round);
            }
            foreach (var round in db.RoundEntries.Where(a => a.TeamID == id && a.Rerun == false).OrderBy(a => a.Round).ToList())
            {
                i++;
                var Round = (from a in db.RoundEntries where a.TeamID == id && a.Round == round.Round && a.Rerun == round.Rerun select a).FirstOrDefault();
                if (Round.Usable == true)
                {
                    average = average + Round.Score;
                }
                TeamDetailsModel.Round.Add(Round);
            }
            TeamDetailsModel.RoundAverage = average / 2;
            return View(TeamDetailsModel);
        }

        // GET: Entry/Create
        public ActionResult RoundCreate(int id)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("Judge")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                var RoundEntry = new RoundEntry();
                RoundEntry.TeamID = id;
                var RoundsCompleted = (from a in db.RoundEntries where a.TeamID == id select a);
                bool R1 = false;
                bool R2 = false;
                bool Rerun = false;
                foreach (var Round in RoundsCompleted.OrderBy(a => a.Round).ToList())
                {
                    if (Round.Round == 1)
                    {
                        R1 = true;
                    }
                    else if (Round.Round == 2)
                    {
                        R2 = true;
                    }
                }
                if (R1 == true && R2 == true)
                {
                    Rerun = true;
                }
                RoundEntry.Rerun = Rerun;
                RoundEntry.Usable = true;
                return View(RoundEntry);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }

        public ActionResult ScoreInfo(int id)
        {
            var Round = (from a in db.RoundEntries where a.EntryID == id select a).FirstOrDefault();

            return View(Round);
        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoundCreate([Bind("TeamID,Score,Time,Round,Data,Rerun,Usable,TimeStamp,Field,JudgeConfirmNotes,StudentInitials")] RoundEntry roundEntry)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("Judge")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                db.RoundEntries.Add(roundEntry);
                db.SaveChanges();

                var TeamNumberBranch = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberBranch;
                var TeamNumberSpecific = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberSpecific;
                string TeamNumber = TeamNumberBranch + "-" + TeamNumberSpecific;
                this.Clients.All.initFieldView(roundEntry.Field, 3, roundEntry.Score, TeamNumber, false, false);
                this.Clients.All.checkThisScore(roundEntry.Field, roundEntry.Data, roundEntry.Score, roundEntry.EntryID, TeamNumber);
                UpdateScoresheet();
                UpdateTopTen();

                string page = roundEntry.TeamID.ToString();
                page = "Details/" + page;
                return RedirectToAction(page);
            }
            else
            {
                return View("IsNotAuthenticated");
            }


        }

        public ActionResult RoundCreateBlank()
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("Judge")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                return View();
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoundCreateBlank([Bind("TeamID,Score,Time,Round,Data,Rerun,Usable,TimeStamp,Field")] RoundEntry roundEntry)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("Judge")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                db.RoundEntries.Add(roundEntry);
                db.SaveChanges();
                this.Clients.All.initFieldView(roundEntry.Field, 3);
                UpdateScoresheet();
                UpdateTopTen();

                string page = roundEntry.TeamID.ToString();
                page = "Details/" + page;
                return RedirectToAction(page);
            }
            else
            {
                return View("IsNotAuthenticated");
            }


        }

        public ActionResult JudgeIndex(int id)
        {
            ViewBag.Message = "Your application description page.";
            var JudgeIndexPageModel = new JudgeIndexPageModel();
            foreach (var field in db.Fields.Where(f => f.CompID == id).OrderBy(f => f.FieldNumber))
            {
                JudgeIndexPageModel.Fields.Add(field);
                JudgeIndexPageModel.FieldAmount = JudgeIndexPageModel.FieldAmount + 1;
                field.CurrentTeamNumber = (from t in db.StudentTeams where t.CompID == id && t.TeamID == field.CurrentTeamID select t).FirstOrDefault().TeamNumberBranch + "-" + (from t in db.StudentTeams where t.CompID == id && t.TeamID == field.CurrentTeamID select t).FirstOrDefault().TeamNumberSpecific;
            }
            JudgeIndexPageModel.Competition = (from c in db.Competitions where c.CompID == id select c).FirstOrDefault();
            return View(JudgeIndexPageModel);
        }

        public ActionResult MatchKeeper(int id)
        {
            var MatchDataModel = new MatchDataModel();
            MatchDataModel.Competition = (from c in db.Competitions where c.CompID == id select c).FirstOrDefault();
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
                MatchDataModel.R1List.Add(StudentTeam);
                MatchDataModel.R2List.Add(StudentTeam);
            }
            return View(MatchDataModel);
        }

        // GET: Entry/Edit/5*/
        public ActionResult RoundEdit(int id)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("FieldStaff")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                if (id == null)
                {
                    //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                RoundEntry score = db.RoundEntries.Find(id);
                if (score == null)
                {
                    //return HttpNotFound();
                }
                return View(score);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }


        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoundEdit([Bind("EntryID,TeamID,Score,Time,Round,Data,Rerun,Usable,TimeStamp")] RoundEntry roundEntry)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("FieldStaff")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                if (ModelState.IsValid)
                {
                    var TeamNumberBranch = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberBranch;
                    var TeamNumberSpecific = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberSpecific;
                    string TeamNumber = TeamNumberBranch + "-" + TeamNumberSpecific;
                    var PreviousField = (from r in db.RoundEntries where r.EntryID == roundEntry.EntryID select r).FirstOrDefault().Field;
                    this.Clients.All.checkThisScore(PreviousField, roundEntry.Data, roundEntry.Score, roundEntry.EntryID, TeamNumber);
                    roundEntry.Field = PreviousField;
                    db.Set<RoundEntry>().Update(roundEntry);
                    db.SaveChanges();
                    UpdateScoresheet();
                    UpdateTopTen();

                    string page = roundEntry.TeamID.ToString();
                    page = "Details/" + page;
                    return RedirectToAction(page);
                }
                return View(roundEntry);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }

        public ActionResult TeamEdit(int id)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("FieldStaff")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                if (id == null)
                {
                    //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                StudentTeam score = db.StudentTeams.Find(id);
                if (score == null)
                {
                    //return HttpNotFound();
                }
                return View(score);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }


        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeamEdit([Bind("TeamID,CompID,TeamName,TeamNumber,Location,Coach,ReadyR1,ReadyR2")] StudentTeam studentTeam)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("FieldStaff")) || (User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                if (ModelState.IsValid)
                {
                    db.Entry(studentTeam).State = EntityState.Modified;
                    db.SaveChanges();
                    string page = studentTeam.CompID.ToString();
                    page = "Competition/" + page;
                    return RedirectToAction(page);
                }
                return View(studentTeam);
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }

        // GET: Entry/Create
        public ActionResult TeamCreate()
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                return View();
            }
            else
            {
                return View("IsNotAuthenticated");
            }

        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeamCreate([Bind("TeamID,CompID,TeamName,TeamNumber,Location,Coach,ReadyR1,ReadyR2")] StudentTeam studentTeam)
        {
            if ((User.Identity.IsAuthenticated && User.IsInRole("Manager")) || (User.Identity.IsAuthenticated && User.IsInRole("Admin")))
            {
                db.StudentTeams.Add(studentTeam);
                db.SaveChanges();
                UpdateScoresheet();
                string page = studentTeam.CompID.ToString();
                page = "Competition/" + page;
                return RedirectToAction(page);
            }
            else
            {
                return View("IsNotAuthenticated");
            }


        }
        /*
                // GET: Entry/Delete/5
                public ActionResult Delete(string id)
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    RoundEntry score = db.RoundEntries.Find(id);
                    if (score == null)
                    {
                        return HttpNotFound();
                    }
                    return View(score);
                }

                // POST: Entry/Delete/5
                [HttpPost, ActionName("Delete")]
                [ValidateAntiForgeryToken]
                public ActionResult DeleteConfirmed(string id)
                {
                    RoundEntry score = db.RoundEntries.Find(id);
                    db.RoundEntries.Remove(score);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}