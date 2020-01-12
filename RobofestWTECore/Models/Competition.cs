using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class Competition
    {
        [Key]
        public int CompID { get; set; }
        public int GameID { get; set; }
        public string Location { get; set; }
        public string ExtraData { get; set; }
        public DateTime Date { get; set; }
        public int RunningFields { get; set; }
        public int ScheduleNumber { get; set; }
        public virtual GAME GAME { get; set; }
        public virtual ICollection<StudentTeam> StudentTeams { get; set; }
        public virtual ICollection<CompField> Fields { get; set; }
        public int field1preferred { get; set; }
        public int field2preferred { get; set; }
        public int field3preferred { get; set; }
        public int field4preferred { get; set; }
        public int field5preferred { get; set; }
        public int field6preferred { get; set; }
    }
}