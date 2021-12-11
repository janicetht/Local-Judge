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
using System.Diagnostics;


namespace LocalJudge
{
    public static class JudgeSystemStatic 
    {
        public static List<ProgramProblem> problems;
        public static List<User> users;
        public static User currentUser;
        public static int count = 0; 
    }
    public class JudgeSystem
    {
        //protected List<ProgramProblem> problems;
        //protected User currentUser;
        //protected NavigationService navigationService;
        public UserController uc = new UserController();
        public JudgeSystem() { }
        //public JudgeSystem(NavigationService n) { this.navigationService = n; } // constructor
        private void Initialization()
        {
            JudgeSystemStatic.users = new List<User>();
            Admin admin = new Admin("1", "Admin", "Admin");
            Student chansiuming = new Student("2", "ChanSiuMing", "20000101");
            Student chantaiming = new Student("3", "ChanTaiMing", "asdfghjkl;'");
            Student catchu = new Student("4", "CatChu", "catcatcat");
            uc.AddUser(admin);
            uc.AddUser(chansiuming);
            uc.AddUser(chantaiming);
            uc.AddUser(catchu);
            JudgeSystemStatic.problems = new List<ProgramProblem>();
            ProgramProblem problem1 = new ProgramProblem(1, "Hello World", "Output \"Hello World\"", "Admin", 0);
            ProgramProblem problem2 = new ProgramProblem(2, "Prime", "Check whether the input integer is a prime number. Output \"Prime\" if the input integer is a prime number. Otherwise, output \"Not prime\". ", "Admin", 1);
            problem1.attempts.Add(chansiuming);
            problem1.ac.Add(chansiuming);
            chansiuming.submission.Add(problem1);
            JudgeSystemStatic.problems.Add(problem1);
            JudgeSystemStatic.problems.Add(problem2);
            Testcase helloworld = new Testcase("Hello World");
            problem1.testcases.Add(helloworld);
            Testcase prime1 = new Testcase("3", "Prime");
            Testcase prime2 = new Testcase("6", "Not prime");
            Testcase prime3 = new Testcase("11", "Prime");
            Testcase prime4 = new Testcase("16", "Not prime");
            Testcase prime5 = new Testcase("23", "Prime");
            problem2.testcases.Add(prime1);
            problem2.testcases.Add(prime2);
            problem2.testcases.Add(prime3);
            problem2.testcases.Add(prime4);
            problem2.testcases.Add(prime5);
        }
        public void Login(TextBox Username_Textbox, PasswordBox Passwordbox)
        {
            if (JudgeSystemStatic.count == 0)
            {
                Initialization();
                JudgeSystemStatic.count = 1;
            }
            JudgeSystemStatic.currentUser = uc.findUserByNamePass(Username_Textbox.Text, Passwordbox.Password);

        }
        public void Logout()
        {
            JudgeSystemStatic.currentUser = null;
        }
        public void Browse_problem_list(ListView Problem_ListView)
        {
            Problem_ListView.ItemsSource = JudgeSystemStatic.problems;
        }
        public void Browse_submission(ListView Completion_ListView)
        {
            Completion_ListView.ItemsSource = JudgeSystemStatic.currentUser.submission;
        }
        public void Browse_statistics(ListView Statistic_ListView)
        {
            Statistic_ListView.ItemsSource = JudgeSystemStatic.problems;
        }
        public ProgramProblem Create_Problem(string difficulty, string title, string content)
        {
            int id = JudgeSystemStatic.problems.Count + 1;
            int d;
            if (difficulty == "Easy")
            {
                d = 0;
            }
            else if (difficulty == "Moderate")
            {
                d = 1;
            }
            else //if (difficulty == "Difficult")
            {
                d = 2;
            }
            ProgramProblem p = new ProgramProblem(id, title, content, "Admin", d);
            JudgeSystemStatic.problems.Add(p);
            return p;
        }
    }

}
