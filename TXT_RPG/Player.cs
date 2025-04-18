using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Player
    {
        public int Level { get; set; } = 1;
        public string Job { get; set; } = "전사";
        public int Attack { get; set; } = 10;
        public int AttackPercent { get; set; } = 0;
        public int Shield { get; set; } = 5;
        public int ShieldPercent { get; set; } = 0;
        public int HP { get; set; } = 100;
        public int Money { get; set; } = 5000;
    }

}

