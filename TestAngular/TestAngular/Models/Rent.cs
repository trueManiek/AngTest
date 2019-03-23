using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAngular.Models
{
    public class Rent
    {
        public int RentID { get; set; }
        public string Weight { get; set; }
        public bool isActive { get; set; }
        public DateTime RentTime { get; set; }

        public virtual int GameID { get; set; }
        public virtual Game Game { get; set; }

        public virtual int UserID { get; set; }
        public virtual User Publisher { get; set; }

        public virtual int EventID { get; set; }
        public virtual Event Event { get; set; }
    }
}
