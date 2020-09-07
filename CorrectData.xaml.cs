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
using System.Windows.Shapes;

namespace Account
{
    /// <summary>
    /// Interaction logic for CorrectData.xaml
    /// </summary>
    /// 
    public partial class CorrectData : Window
    {
        public string Log{ get; set; }
        public string Pass { get; set; }
        public CorrectData(string true_log, string true_pass)
        {
            WorkInAccount workInAccount = new WorkInAccount(true_log,true_pass);
            Log = true_log;
            Pass = true_pass;
            InitializeComponent();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            WorkInAccount workInAccount = new WorkInAccount(Log, Pass);
            workInAccount.Age = Convert.ToInt32(Age.Text);
            workInAccount.Salary = float.Parse(Salary.Text);
            workInAccount.City = City.Text;
            workInAccount.Sex = Sex.Text;
            WorkInAccount.AddDataToDB(workInAccount);
        }

      
    }
}
