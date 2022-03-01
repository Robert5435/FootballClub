using Football.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.ViewModels
{
    public class PagePlayersViewModel
    {
        public List<Player> Players { get; set; }
        public PagePlayers Text { get; set; }
    }
}
