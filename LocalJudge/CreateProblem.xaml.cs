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
using System.Windows.Shapes;
using Microsoft.Win32;

namespace LocalJudge
{
    /// <summary>
    /// Interaction logic for CreateProblem.xaml
    /// </summary>
    public partial class CreateProblem : Window
    {
        ProgramProblem p;
        JudgeSystem js = new JudgeSystem();
        public CreateProblem()
        {
            InitializeComponent();
            List<string> difficulty = new List<string>();
            difficulty.Add("Easy");
            difficulty.Add("Moderate");
            difficulty.Add("Difficult");
            Difficulty_ComboBox.ItemsSource = difficulty;
            
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            p.Add_testcases(Input_TextBox.Text, Output_TextBox.Text);
            //Testcase tc = new Testcase(Input_TextBox.Text, Output_TextBox.Text);
            //testcases.Add(tc);
            Testcase_ListView.ItemsSource = p.testcases;
            Testcase_ListView.Items.Refresh();
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            p.Remove_testcases(Input_TextBox.Text, Output_TextBox.Text);
            //Testcase selectedTestcase = (Testcase)Testcase_ListView.SelectedItem;
            //testcases.Remove(selectedTestcase);
            Testcase_ListView.ItemsSource = p.testcases;
            Testcase_ListView.Items.Refresh();
        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            this.p = js.Create_Problem(Difficulty_ComboBox.SelectedItem.ToString(), Title_TextBox.Text, Content_TextBox.Text);
            //this.testcases = p.testcases;
            MessageBox.Show("Problem Created Successfully! Please add testcases now.");
        }

        private void GoBack()  // Back to admin page
        {
            AdminInterface a = new AdminInterface();
            this.Close();
            a.Show();
        }
        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            GoBack();
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            JudgeSystem js = new JudgeSystem();
            LogInPage login = new LogInPage();
            js.Logout();
            this.Close();
            login.Show();
        }
    }
}
