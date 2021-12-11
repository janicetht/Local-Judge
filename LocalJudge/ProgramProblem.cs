using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;


namespace LocalJudge
{
    public class ProgramProblem
    {
        public List<User> attempts;
        public List<User> ac;
        public List<Testcase> testcases;
        protected string title, content, author;
        protected int id, trial, difficulty;
        protected double acRate, tags;
        protected bool isLive;
        public ProgramProblem() { }
        public ProgramProblem(string filename) { }
        public ProgramProblem(int ID, string title, string content, string author, int difficulty, List<Testcase> testcases)
        {
            this.id = ID;
            this.title = title;
            this.content = content;
            this.author = author;
            this.difficulty = difficulty;
            ac = new List<User>();
            attempts = new List<User>();
            this.testcases = testcases;
            
        }
        public ProgramProblem(int ID, string title, string content, string author, int difficulty)
        {
            this.id = ID;
            this.title = title;
            this.content = content;
            this.author = author;
            this.difficulty = difficulty;
            ac = new List<User>();
            attempts = new List<User>();
            testcases = new List<Testcase>();
        }
        public int ID { get { return id; }}
        public string Title { get { return title; } set { title = value; } } // read-only property
        public string Content { get { return content; } set { content = value; } } // read-only property
        public string Author { get { return author; } } // read-only property
        public string Difficulty
        { // Data abstraction, read-only property
            get
            {
                if (difficulty == 0) return "Easy";
                else if (difficulty == 1) return "Moderate";
                else if (difficulty == 2) return "Difficult";
                else return "--";
            }
            set
            {
                if (value == "Easy") difficulty = 0;
                else if (value == "Moderate") difficulty = 1;
                else difficulty = 2;
            }
        }
        public int acNum
        {
            get { return ac.Count; }
        }
        public int AttemptNum
        {
            get { return attempts.Count; }
        }

        public double ACRate
        { // read-only property
            get { return acRate; }
        }
        // compile time polymorphism
        public void Edit_problem(string title, string content, string difficulty)
        {
            Title = title;
            Content = content;
            Difficulty = difficulty;
        }

        public void Add_testcases(string input, string output) // use in edit problem 
        {
            Testcase tc = new Testcase(input, output);
            testcases.Add(tc);
        }

        public void Remove_testcases(string input, string output) // use in edit problem 
        {
            Testcase tc = new Testcase(input, output);
            testcases.Remove(tc);
        }

        public bool Checking(string filename, ProgramProblem problem)
        {
            bool isCorrect = true;
            foreach (Testcase t in testcases)
            {
                string batFileName = "\\localjudge\\" + @"\" + Guid.NewGuid() + ".bat";
                using (StreamWriter batFile = new StreamWriter(batFileName))
                {
                    batFile.WriteLine($"cd \\localjudge\\");
                    batFile.WriteLine($"gcc " + filename + " -Wall -o program");
                    batFile.WriteLine($"C:\\localjudge\\program.exe");
                }
                System.Diagnostics.ProcessStartInfo ps = new System.Diagnostics.ProcessStartInfo(@"cmd.exe", "/c" + batFileName);
                ps.UseShellExecute = false;
                ps.RedirectStandardInput = true;
                ps.RedirectStandardOutput = true;
                ps.RedirectStandardError = true;
                ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                ps.CreateNoWindow = true; //not diplay a windows
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo = ps;
                p.Start();
                if (t.Input != null)
                {
                    StreamWriter sw = p.StandardInput;
                    sw.WriteLine(t.Input);
                }
                string output = p.StandardOutput.ReadToEnd(); //The output result
                string error = p.StandardError.ReadToEnd();
                //MessageBox.Show(output);
                //MessageBox.Show(error);
                p.WaitForExit();
                p.Close();
                File.Delete(batFileName);
                string[] errorLines = error.Split('\n');
                if (errorLines.Count() > 1)
                {
                    MessageBox.Show("Error!");
                    isCorrect = false;
                    break;
                }
                string[] lastLineOutput = output.Split('\n');
                int x = lastLineOutput.Count();
                //MessageBox.Show(lastLineOutput[x - 1]);
                if (lastLineOutput[x - 1] != t.Output)
                {
                    isCorrect = false;
                    break;
                }
            }
            File.Delete(filename);
            

            if (isCorrect)
            {
                bool attemptsAdd = true;
                bool acAdd = true;
                foreach (User i in attempts)
                {
                    if (JudgeSystemStatic.currentUser == i)
                    {
                        attemptsAdd = false;
                    }
                }
                if (attemptsAdd == true)
                {
                    attempts.Add(JudgeSystemStatic.currentUser);
                }

                foreach (User j in ac)
                {
                    if (JudgeSystemStatic.currentUser == j)
                    {
                        acAdd = false;
                    }
                }
                if (acAdd == true)
                {
                    ac.Add(JudgeSystemStatic.currentUser);
                    JudgeSystemStatic.currentUser.submission.Add(problem);
                }
                return true;
            }
            else
            {
                bool attemptsAdd = true;
                foreach (User k in attempts)
                {
                    if (JudgeSystemStatic.currentUser == k)
                    {
                        attemptsAdd = false;
                    }
                }
                if (attemptsAdd == true)
                {
                    attempts.Add(JudgeSystemStatic.currentUser);
                }
                return false;
            }

        }
    }

    public class Testcase
    {
        protected string input;
        protected string output;

        public string Input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }
        public string Output
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
            }
        }
        public Testcase(string output)
        {
            this.input = null;
            this.output = output;
        }
        public Testcase(string input, string output)
        {
            this.input = input;
            this.output = output;
        }

    }

}
