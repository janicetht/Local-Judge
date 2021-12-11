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

namespace LocalJudge
{
    /// <summary>
    /// Interaction logic for EditProblem.xaml
    /// </summary>
    public partial class EditProblem : Window
    {
        ProgramProblem p;
        public EditProblem(ProgramProblem p)
        {
            InitializeComponent();
            this.p = p;
            List<string> difficulty = new List<string>();
            difficulty.Add("Easy");
            difficulty.Add("Moderate");
            difficulty.Add("Difficult");
            Difficulty_ComboBox.ItemsSource = difficulty;
            Testcase_ListView.ItemsSource = p.testcases;
            Title_TextBox.Text = p.Title;
            Content_TextBox.Text = p.Content;
            Difficulty_ComboBox.SelectedItem = p.Difficulty;
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            Testcase selectedTestcase = (Testcase)Testcase_ListView.SelectedItem;
            p.testcases.Remove(selectedTestcase);
            Testcase_ListView.Items.Refresh();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            p.Add_testcases(Input_TextBox.Text, Output_TextBox.Text);
            Testcase_ListView.Items.Refresh();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            p.Edit_problem(Title_TextBox.Text, Content_TextBox.Text, Difficulty_ComboBox.SelectedItem.ToString());
            MessageBox.Show("Saved!");
            GoBack();
        }

        private void GoBack()
        {
            Statistics s = new Statistics();
            this.Close();
            s.Show();
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
