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
using System.IO;

namespace LocalJudge
{
    /// <summary>
    /// Interaction logic for DisplayProblem.xaml
    /// </summary>
    public partial class DisplayProblem : Window
    {
        public string filename;
        ProgramProblem p;
        public DisplayProblem(ProgramProblem p)
        {
            InitializeComponent();
            ProblemTitle_TextBlock.Text = "Problem: " + p.Title;
            Description_TextBlock.Text = p.Content;
            Author_TextBlock.Text = p.Author;
            Difficulty_TextBlock.Text = p.Difficulty;
            this.p = p;
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
            ProblemList pl = new ProblemList();
            this.Close();
            pl.Show();
        }

        private void SelectFile_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".c";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                filename = dlg.FileName;   // Open document
                Filename_TextBlock.Text = filename;
                IsCorrect(p.Checking(filename, p));
            }
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            filename = @"C:\localjudge\program.c";
            //filename = "program.c";
            File.WriteAllText(filename, Program_TextBox.Text);
            IsCorrect(p.Checking(filename, p));
        }

        private void IsCorrect(bool isCorrect)
        {
            if (isCorrect == true)
            {
                MessageBox.Show("Congratulations! You have passed all the testcases.");
            }
            else
            {
                MessageBox.Show("Failed to pass all the testcases.");
            }
        }

    }
}
