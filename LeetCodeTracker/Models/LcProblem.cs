using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTracker.Models
{
    public class LcProblem
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public int Difficulty { get; set; }
        public int Attempts { get; set; }
        public double SuccessfulAttempts { get; set; }
        public DateTime CreatedAt { get; set; }
        public double SuccessRate
        {
            get
            {
                if (Attempts > 0)
                {
                    return ((double)SuccessfulAttempts / Attempts);
                }
                return 0;

            }
        }

        public LcProblem(string name, string link, int difficulty) {
            Name = name;
            Link = link;
            Difficulty = difficulty;
            Attempts = 0;
            SuccessfulAttempts = 0;
            CreatedAt = DateTime.Now;
        }

    }
}
