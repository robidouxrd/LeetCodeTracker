using LeetCodeTracker.Models;
using System.Text.Json;

namespace LeetCodeTracker
{
    public partial class MainForm : Form
    {
        private ProblemCollection problems = new ProblemCollection();
        private string savePath = "problems.json";
        private ListViewItem? rightClickedItem;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCollection();
            PopulateListView(4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCollection();
        }

        private void SaveCollection()
        {
            string json = JsonSerializer.Serialize(problems, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(savePath, json);
        }

        private void LoadCollection()
        {
            if (File.Exists(savePath))
            {
                string json = File.ReadAllText(savePath);
                problems = JsonSerializer.Deserialize<ProblemCollection>(json) ?? new ProblemCollection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewForm addNewPopUp = new AddNewForm();
            addNewPopUp.ShowDialog();
            LcProblem newProblem = new LcProblem(addNewPopUp.ProblemName, addNewPopUp.ProblemDescripion, addNewPopUp.ProblemDifficulty);
            problems.addProblem(newProblem);
            PopulateListView(FindCheckedRadioButton());
            foreach (LcProblem prob in problems.ProblemList) 
            {
                Console.WriteLine(prob.Name);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!problems.IsEmpty())
            {
                PracticeForm randPopUp = new PracticeForm(getProbFromListView(), problems);
                randPopUp.ShowDialog();
                PopulateListView(FindCheckedRadioButton());
            }

        }

        private LcProblem getProbFromListView()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (LcProblem prob in problems.ProblemList)
                {
                    Console.WriteLine($"Comparing: '{prob.Name}' vs '{listView1.SelectedItems[0].Text}'");

                    if (prob.Name == listView1.SelectedItems[0].Text)
                    {
                        Console.WriteLine("match!!!!!!!!!!!");
                        return prob;
                    }
                }
            }
            return problems.getRandProblem();

        }

        private void rdBtnEasy_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListView(1);
        }

        private void rdBtnMed_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListView(2);
        }

        private void rdBtnHard_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListView(3);
        }

        private void rdBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            PopulateListView(4);
        }

        private void PopulateListView(int difficulty)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name", 120);
            listView1.Columns.Add("Difficulty", 95);
            listView1.Columns.Add("Attempts", 95);
            listView1.Columns.Add("Success Rate", 95);
            listView1.Columns.Add("Created On", 95);


            foreach (LcProblem prob in problems.ProblemList)
            {
                if (difficulty == 4)
                {
                    AddSubItems(prob);
                }
                else if (prob.Difficulty == difficulty)
                {
                    AddSubItems(prob);
                }
            }
        }

        private void AddSubItems(LcProblem prob)
        {
            ListViewItem item = new ListViewItem(prob.Name);
            item.SubItems.Add(GetDifficulty(prob.Difficulty));
            item.SubItems.Add(prob.Attempts.ToString());
            item.SubItems.Add(prob.SuccessRate.ToString("P0"));
            item.SubItems.Add(prob.CreatedAt.ToString("MM/dd/yy"));
            listView1.Items.Add(item);
        }

        private string GetDifficulty(int num)
        {
            if (num == 1)
            {
                return "easy";
            }
            else if (num == 2)
            {
                return "medium";
            }
            return "hard";
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickedItem = listView1.GetItemAt(e.X, e.Y);
                listView1.SelectedItems.Clear();
                if (rightClickedItem != null)
                {
                    rightClickedItem.Selected = true;
                }
            }
        }

        private void deletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rightClickedItem != null)
            {
                //for (int i = 0; i < problems.ProblemList.Count; i++)
                //{
                //    if (problems.ProblemList[i].Name == rightClickedItem.Text)
                //    {
                //        problems.ProblemList.RemoveAt(i);
                //        break;
                //    }
                //}
                problems.RemoveProblem(rightClickedItem.Text);
            }

            PopulateListView(FindCheckedRadioButton());
        }

        private int FindCheckedRadioButton()
        {

            if (rdBtnEasy.Checked)
            {
                return 1;
            }
            else if (rdBtnMed.Checked)
            {
                return 2;
            }
            else if (rdBtnHard.Checked)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortBy sortBy;
            switch (e.Column)
            {
                case 0:
                    sortBy = SortBy.Name;
                    break;
                case 1:
                    sortBy = SortBy.Difficulty;
                    break;
                case 2:
                    sortBy = SortBy.SuccessRate;
                    break;
                case 3:
                    sortBy = SortBy.Date;
                    break;
                default:
                    return;
            }

            problems.Sort(sortBy, false);
            PopulateListView(FindCheckedRadioButton());

        }
    }
}
