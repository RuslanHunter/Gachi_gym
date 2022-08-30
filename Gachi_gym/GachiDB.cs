using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gachi_gym
{
    public class GachiDB
    {
        public int Exercise_id { get; set; }
        public string ExerciseName { get; set; }
        public DateTime Exercise_date { get; set; } = DateTime.Today;
        public bool IsDone { get; set; } = false;
        public int Repetition { get; set; }
        public int Approach { get; set; }
    }

}
