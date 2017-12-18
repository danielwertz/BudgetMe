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
using System.IO;

namespace BudgetMe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ballance;
        string newBallance;

        public MainWindow()
        {
            InitializeComponent();
            saveData();

        }

        private void balanceBtn_Click(object sender, RoutedEventArgs e)
        {
            currentBalanceBtn();
        }

        private void withdrawBtn_Click(object sender, RoutedEventArgs e)
        {
            withdraw();
        }
        private void depositBtn_Click(object sender, RoutedEventArgs e)
        {
            deposit();
        }

        private void currentBalanceBtn()
        {
            newBallance = getInfoTextBox.Text;
            if (double.TryParse(newBallance, out ballance))
            {
                //balanceTextBox.Text = "";
                balanceTextBox.Text = ballance.ToString();
            }
        }
        private void withdraw()
        {

            newBallance = getInfoTextBox.Text;
            if (double.TryParse(newBallance, out ballance))
            {
                double newCurrentBalance;
                string currentBalance = balanceTextBox.Text;
                if(double.TryParse(currentBalance, out newCurrentBalance))
                {
                    balanceTextBox.Text = (newCurrentBalance + ballance).ToString();
                }

            }
        }

        private void deposit()
        {
            newBallance = getInfoTextBox.Text;
            if (double.TryParse(newBallance, out ballance))
            {
                double newCurrentBalance;
                string currentBalance = balanceTextBox.Text;
                if (double.TryParse(currentBalance, out newCurrentBalance))
                {
                    balanceTextBox.Text = (newCurrentBalance - ballance).ToString();
                }

            }
        }
        public void balanceBox()
        {
          
        }
        public void saveData()
        {

            string appSave = @"C:\Users\Danimal\Documents\Visual Studio 2017\Projects\WpfApp1\WpfApp1\LocalFiles\save.txt";
            if (!File.Exists(appSave))
            {
                
                
               
                using(TextWriter tw = new StreamWriter(appSave, true))
                {
                    tw.WriteLine("test");
                    
                }
               

            }else if (File.Exists(appSave))
            {
                using (TextWriter tw = new StreamWriter(appSave, append: true))
                {
                    tw.WriteLine("test2");

                }
            }


            //StreamWriter writer = new StreamWriter(@"C:\WpfApp1\LocalFiles");
            //writer.WriteLine("Hello World");
            //writer.Close();

        }

       
    }
}
