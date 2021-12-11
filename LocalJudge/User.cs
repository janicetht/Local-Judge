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
namespace LocalJudge
{
    public class User
    {
        public string ID, name, password;
        public int userType; // 1 = admin, 2 = student
        public List<ProgramProblem> submission;
        public User() { } // constructors
        public User(string ID, string name, string password) { }
        // runtime polymorphism
        public virtual void edit_profile(string name, string password) { }
        public void submit_problem(string problemID) { }
        public void select_problem(string problemID) { }
        public void upload_program(string problemID) { }
    }
    public class Student : User
    {
        public Student(string ID, string name, string password) 
        {
            this.ID = ID;
            this.name = name;
            this.password = password;
            userType = 2;
            submission = new List<ProgramProblem>();
        } 
        public override void edit_profile(string name, string password) { }
    }
    public class Admin : User
    {
        public Admin(string ID, string name, string password)
        {
            this.ID = ID;
            this.name = name;
            this.password = password;
            userType = 1;
            submission = new List<ProgramProblem>();
        }
        public override void edit_profile(string name, string password) { }
        void create_problem()
        {
            
        }
        void check_record() { }
        void view_statistics() { }
    }

    public class UserController
    {
        public UserController() { }
        public void AddUser(User user)
        {
            JudgeSystemStatic.users.Add(user);
        }
        public User findUserByID(string id)
        {
            foreach (User u in JudgeSystemStatic.users)
            {
                if (u.ID == id)
                {
                    return u;
                }
            }
            return null;
        }
        public User findUserByNamePass(string name, string password)
        {
            foreach (User u in JudgeSystemStatic.users)
            {
                if ((u.name == name) && (u.password == password))
                {
                    return u;
                }
            }
            return null;
        }
    }
}
