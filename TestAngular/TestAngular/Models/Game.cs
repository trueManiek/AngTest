using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAngular.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string EAN { get; set; }
        public bool IsOurs { get; set; }
        public string ImgLink { get; set; }
        public string BggLink { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public string NumberOfPlayers { get; set; }
        public string GameTime { get; set; }
        public string Age { get; set; }
        public int? ExpansionFor { get; set; }

        public virtual int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
