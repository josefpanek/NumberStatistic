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

namespace NumberStatistic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string strings = "78 56 12 23 -78 -68 0 1 62 100 11"; //Fixed input to avoid lengthy input
            
            InitializeComponent();

            textBoxInput.Text = strings;
        }

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            string strings = "78 56 12 23 -78 -68 0 1 62 100 11"; //Fixed input to avoid lengthy input
            double[] doubles = Array.ConvertAll(strings.Split(' '), Double.Parse);
            string sortedString = " ";

            textBlockSum.Text = doubles.Sum().ToString();
            textBlockMinimum.Text = doubles.Min().ToString();
            textBlockMaximum.Text = doubles.Max().ToString();
            textBlockAverage.Text = doubles.Average().ToString();

            if (comboBoxSort.SelectedIndex == 0)
                Array.Sort(doubles);
            else if (comboBoxSort.SelectedIndex == 1)
            {
                Array.Sort(doubles);
                Array.Reverse(doubles);
            }

            for (int i = 0; i < doubles.Length; i++)
            {
                sortedString += (doubles[i].ToString() + ' ');
            }

            textBlockSorted.Text = sortedString;
        }
    }
}
