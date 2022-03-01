using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int HomeTeam { get; set; }
        public int AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string StadiumPhoto { get; set; }
    }
}
