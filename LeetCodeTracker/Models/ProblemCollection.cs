using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTracker.Models
{
    public enum SortBy
    {
        Name,
        Difficulty,
        Attempts,
        SuccessRate,
        Date,
    }

    public class ProblemCollection        
    {

        public List<LcProblem> ProblemList { get; set; } = new List<LcProblem>();
        public List<string> ProblemNames { get; set; } = new List<string>();

        public ProblemCollection()
        {
            ProblemList = new List<LcProblem>();
            ProblemNames = new List<string> ();
        }

        public bool addProblem(LcProblem problem)
        {
            if (ProblemNames.Contains(problem.Name))
            {
                return false;
            }
            else
            {
                ProblemNames.Add(problem.Name);
                ProblemList.Add(problem);
                return true;
            }
        }

        public void RemoveProblem(string name)
        {
            for (int i = 0; i < ProblemList.Count; i++)
            {
                if (ProblemList[i].Name == name)
                {
                    ProblemList.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < ProblemNames.Count; i++)
            {
                if (ProblemNames[i] == name)
                {
                    ProblemNames.RemoveAt(i);
                    break;
                }
            }
        }


        public LcProblem getProblem(int idx)
        {
            return ProblemList[idx];
        }

        public LcProblem getRandProblem()
        {
            Random randGenerator = new Random();
            int randInt = randGenerator.Next(0, ProblemList.Count);
            return ProblemList[randInt];
        }

        public void Sort(SortBy sortBy, bool descending = false)
        {
            switch (sortBy)
            {
                case (SortBy.Name):
                    ProblemList = descending
                        ? ProblemList.OrderByDescending(p => p.Name).ToList()
                        : ProblemList.OrderBy(p => p.Name).ToList();
                    break;
                case (SortBy.Difficulty):
                    ProblemList = descending
                        ? ProblemList.OrderByDescending(p => p.Difficulty).ToList()
                        : ProblemList.OrderBy(p => p.Difficulty).ToList();
                    break;
                case (SortBy.Attempts):
                    ProblemList = descending
                        ? ProblemList.OrderByDescending(p => p.Attempts).ToList()
                        : ProblemList.OrderBy(p => p.Attempts).ToList();
                    break;
                case (SortBy.SuccessRate):
                    ProblemList = descending
                        ? ProblemList.OrderByDescending(p => p.SuccessRate).ToList()
                        : ProblemList.OrderBy(p => p.SuccessRate).ToList();
                    break;
                case (SortBy.Date):
                    ProblemList = descending
                        ? ProblemList.OrderByDescending(p => p.CreatedAt).ToList()
                        : ProblemList.OrderBy(p => p.CreatedAt).ToList();
                    break;
            }
        }

        public bool IsEmpty()
        {
            return ProblemList.Count() == 0;
        }

    }
}
