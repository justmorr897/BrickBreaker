using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    public class Scores
    {
        public string name;
        public int score, time;

        public Scores(string _name, int _score, int _time)
        {
            name = _name;
            score = _score;
            time = _time;
        }
    }
}
