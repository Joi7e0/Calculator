using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private const int MaxInputLength = 16;
        public MainWindow()
        {
            InitializeComponent();


            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;


            if (str == "AC")
                textLabel1.Text = "";
            else if (str == "DEL")
            {
                if (textLabel1.Text.Length > 0)
                {
                    textLabel1.Text = textLabel1.Text.Substring(0, textLabel1.Text.Length - 1);
                }
            }
            else if (str == "=")
            {
                string expression = textLabel1.Text.Replace(',', '.');
                string value = new DataTable().Compute(expression, null).ToString();
                textLabel1.Text = value.ToString();
            }
            else if (str == "%")
            {
                textLabel1.Text = "NAN";
                if (textLabel1.Text == "NAN")
                {
                    textLabel1.Text = "";
                }

            }
            else
                textLabel1.Text += str;

            /*if (textLabel1.Text.Length < MaxInputLength)
            {
                textLabel1.Text += str;
            }
            */
            //




        }
    }
}
