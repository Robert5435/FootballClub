using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int PlayerNumber { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Position { get; set; }
        public string PositionId { get; set; }
        public string Apperances { get; set; }
        public string Description { get; set; }
        public int Goals { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public double HeightInMeters { get; set; }
        public int WeihtInKilograms { get; set; }
    }
}
