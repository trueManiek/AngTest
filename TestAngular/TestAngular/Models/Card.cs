using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAngular.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public string QRcode { get; set; }
        public bool IsActive { get; set; }
        public string CardNr { get; set; }
        public DateTime AddDate { get; set; }

        public virtual int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
