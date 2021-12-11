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

namespace LocalJudge
{
    /// <summary>
    /// Interaction logic for AdminInterface.xaml
    /// </summary>
    public partial class AdminInterface : Window
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            JudgeSystem js = new JudgeSystem();
            LogInPage login = new LogInPage();
            js.Logout();
            this.Close();
            login.Show();
            
        }

        private void Statistics_Button_Click(object sender, RoutedEventArgs e)
        {
            JudgeSystem js = new JudgeSystem();
            Statistics stat = new Statistics();
            this.Close();
            stat.Show();
        }

        private void Problems_Button_Click(object sender, RoutedEventArgs e)
        {
            ProblemList pl = new ProblemList();
            this.Close();
            pl.Show();
        }

        private void CreateProblem_Button_Click(object sender, RoutedEventArgs e)
        {
            CreateProblem cp = new CreateProblem();
            this.Close();
            cp.Show();
        }
    }
}
