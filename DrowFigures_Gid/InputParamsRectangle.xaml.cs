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
    /// Interaction logic for InputParamsRectangle.xaml
    /// </summary>
    public partial class InputParamsRectangle : Window
    {
        MainWindow window;
        Random random = new Random();
        public InputParamsRectangle()
        {
            InitializeComponent();
        }
        public InputParamsRectangle(MainWindow w)
        {
            InitializeComponent();
            window = w;
        }

        private void InputParams(object sender, RoutedEventArgs e)
        {

            Point2D MainP = new Point2D(int.Parse(T1.Text), int.Parse(T2.Text));
            int Hight = int.Parse(T3.Text);
            int Weight = int.Parse(T4.Text);
            Rectangle myRect = new Rectangle(MainP, Weight, Hight);
            window.rect = myRect;
            this.Close();
        }

        private void RandomNum(object sender, RoutedEventArgs e)
        {
            T3.Text = Convert.ToString(random.Next(1, (int)window.Scene.Height));
            T4.Text = Convert.ToString(random.Next(1, (int)window.Scene.Width));
            T1.Text = Convert.ToString(random.Next(0, ((int)window.Scene.Width) - int.Parse(T4.Text)));
            T2.Text = Convert.ToString(random.Next(0, ((int)window.Scene.Height) - int.Parse(T3.Text)));
            
        }
    }
}
