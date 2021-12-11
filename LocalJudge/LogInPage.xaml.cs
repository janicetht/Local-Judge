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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LogInPage : Window
    {

        public LogInPage()
        {
            InitializeComponent();
        }

        private void Log_In_Button_Click(object sender, RoutedEventArgs e)
        {
            JudgeSystem js = new JudgeSystem();
            js.Login(Username_Textbox, Passwordbox);

            if (JudgeSystemStatic.currentUser != null)
            {
                if (JudgeSystemStatic.currentUser.userType == 2)
                {
                    ProblemList s = new ProblemList();
                    this.Close();
                    s.Show();
                    //this.NavigationService.Navigate(new StudentInterface());
                }
                else if (JudgeSystemStatic.currentUser.userType == 1)
                {
                    AdminInterface a = new AdminInterface();
                    this.Close();
                    a.Show();
                    //this.NavigationService.Navigate(new AdminInterface());
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or password!");
            }
        }
    }

}
