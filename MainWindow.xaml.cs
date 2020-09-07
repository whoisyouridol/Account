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
using Newtonsoft.Json;
using System.IO;
namespace Account
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
        private bool test = false;
        private bool test2 = false;
        private void Login_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!test)
            {
                Login.Text = null;
            }
            test = true;
        }
        private void Password_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!test2)
            {
                Password.Password = null;
            }
            test2 = true;
        }
        private void Sign_up_Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_up sign_Up = new Sign_up(Login.Text, Password.Password);
            Sign_up.AddDataToJson(sign_Up);
            this.Close();
        }
        private void Sign_in_Button_Click(object sender, RoutedEventArgs e)
        {
           bool check =  Sign_in.Check(Login.Text, Password.Password);
            if (check)
            {
                CorrectData correctData = new CorrectData(Login.Text,Password.Password);
                this.Close();
                correctData.ShowDialog();
            }
            else
            {
                IncorrectData incorrectData = new IncorrectData();
                this.Close();
                incorrectData.ShowDialog();
            }
        }
    }
}
