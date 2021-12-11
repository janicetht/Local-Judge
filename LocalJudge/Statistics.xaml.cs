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
    /// Interaction logic for Statistics.xaml
    /// </summary>
    public partial class Statistics : Window
    {
        JudgeSystem js = new JudgeSystem();
        public Statistics()
        {
            InitializeComponent();
            js.Browse_statistics(Statistic_ListView);
            //Statistic_ListView.ItemsSource = JudgeSystemStatic.problems;
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            JudgeSystem js = new JudgeSystem();
            LogInPage login = new LogInPage();
            js.Logout();
            this.Close();
            login.Show();
        }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminInterface a = new AdminInterface();
            this.Close();
            a.Show();
        }

        private void ListViewItem_Click(object sender, MouseButtonEventArgs e)
        {
            ProgramProblem item = (ProgramProblem)(sender as ListView).SelectedItem;
            if (item != null)
            {
                EditProblem x = new EditProblem(item);
                this.Close();
                x.Show();
            }
        }

    }
}
