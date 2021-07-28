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

namespace CodePractices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            string uName = "admin";
            string pswd = "password";
            string userName = userNameEntry.Text.ToString().Trim();
            string userPswd = pswdEntry.Password.ToString();

            errorPswdText.Text = null;
            errorUserNameText.Text = null;

            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(userPswd))
            {
                errorUserNameText.Text = "Please provide a username";
                errorPswdText.Text = "Please provide a password";
            }
            else if(string.IsNullOrEmpty(userPswd)){
                errorPswdText.Text = "Please provide a password";
            }else if(string.IsNullOrEmpty(userName))
            {
                errorUserNameText.Text = "Please provide a username";
            }
            else
            {
                if(userName != uName)
                {
                    errorUserNameText.Text = "Username doesnt exist";
                }else if(userPswd != pswd)
                {
                    errorPswdText.Text = "incorrect password";
                }
                else
                {
                    HomePage homePage = new HomePage(userName);
                    mainPage.Content = homePage;
                }
            }
        }
    }
}
