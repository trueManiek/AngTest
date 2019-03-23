using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAngular.Models
{
    public class Worker
    {
        public int WorkedID { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Master = 0,
        Expert = 1,
        Apprentice = 2,
        Novie = 3
    }
}
