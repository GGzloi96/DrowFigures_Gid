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

namespace DrowFigures_Gid
{
    /// <summary>
    /// Interaction logic for InputParamsTriangle.xaml
    /// </summary>
    public partial class InputParamsTriangle : Window
    {
        MainWindow window;
        public InputParamsTriangle()
        {
            InitializeComponent();
        }
        public InputParamsTriangle(MainWindow w)
        {
            InitializeComponent();
            window = w;
        }

        private void InputParams(object sender, RoutedEventArgs e)
        {
            Triangle myTr = window.tr;
            myTr.P1 = new Point2D(int.Parse(T1.Text), int.Parse(T2.Text));
            myTr.P2 = new Point2D(int.Parse(T3.Text), int.Parse(T4.Text));
            myTr.P3 = new Point2D(int.Parse(T5.Text), int.Parse(T6.Text));
            this.Close();
        }
    }
}
