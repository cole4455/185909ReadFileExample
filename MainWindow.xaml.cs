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

namespace _185909FileReadExample
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

        private void Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr =
             new System.IO.StreamReader("birthdayList.txt");
                LblOutput.Content = "";
                while (!sr.EndOfStream)
                {
                    LblOutput.Content += sr.ReadLine() + Environment.NewLine;
                }
                sr.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr =
             new System.IO.StreamReader("Birthday.txt");
                LblOutput.Content = "";
                string output = "";
                while (!sr.EndOfStream)
                {
                    string fullname = sr.ReadLine();
                    string[] names =
                        fullname.Split(new char[] { ',' });
                    output += names[2] + Environment.NewLine;
                }

                LblOutput.Content = output;
                sr.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch

        }
    }
}

