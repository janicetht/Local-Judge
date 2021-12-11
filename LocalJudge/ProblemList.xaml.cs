using System;
using System.Collections.Generic;
using System.Text;
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

namespace LocalJudge
{
    /// <summary>
    /// Interaction logic for StudentInterface.xaml
    /// </summary>
    public partial class ProblemList : Window
    {
        public JudgeSystem js = new JudgeSystem();
        public ProblemList()
        {
            InitializeComponent();
            js.Browse_problem_list(Problem_ListView);
            js.Browse_submission(Completion_ListView);
            if (JudgeSystemStatic.currentUser.userType == 2) // if user is a student
            {
                GoBack_Button.Visibility = Visibility.Hidden;
            }
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LogInPage login = new LogInPage();
            js.Logout();
            this.Close();
            login.Show();
        }

        private void ListViewItem_Click(object sender, MouseButtonEventArgs e)
        {
            ProgramProblem item = (ProgramProblem)(sender as ListView).SelectedItem;
            if (item != null)
            {
                DisplayProblem x = new DisplayProblem(item);
                this.Close();
                x.Show();
            }
        }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminInterface a = new AdminInterface();
            this.Close();
            a.Show();
        }
    }

}
