using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Competitor
    {
        private int id;
        private string name;
        private bool man;
        private Competition competition;
        public Competitor(int id, string n, bool m)
        {
            if(id <= 0) { throw new Exception(); }
            this.id = id;
            this.name = n;
            this.man = m;
        }
        public int ID() { return id; }
        public bool Man() { return man; }
        public bool IsWinner(Category c) 
        {
            Tuple<bool, Competitor> winner = competition.Winner(c, man);
            return winner.Item1 && winner.Item2 == this;
        }
        public void SetCompetition(Competition c)
        {
            competition = c;
        }
    }
}
