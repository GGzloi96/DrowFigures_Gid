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

namespace DrowFigures_Gid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Triangle tr;
        public Rectangle rect;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            Point2D P1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int) Scene.Height));
            Point2D P2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D P3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

            tr = new Triangle(P1, P2, P3);
            
        }

        public void DrawLine(Point2D p1, Point2D p2)
        {
            
            Line line = new Line();
            
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 3;
            
            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;
            
            Scene.Children.Add(line);
        }

        public void DrawTriangle(Triangle tr)
        {
            
            DrawLine(tr.P1, tr.P2);
            DrawLine(tr.P2, tr.P3);
            DrawLine(tr.P3, tr.P1);
        }

        public void DrawRectangle(Rectangle rect)
        {
            DrawLine(rect.MainP, rect.P2);
            DrawLine(rect.P2, rect.P3);
            DrawLine(rect.P3, rect.P4);
            DrawLine(rect.P4, rect.MainP);
        }

        public void ClearScene()
        {
            
            Scene.Children.Clear();
        }

        private void RandomCreateTriangle(object sender, RoutedEventArgs e)
        {   
            ClearScene();
            Point2D P1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D P2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D P3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

            tr = new Triangle(P1, P2, P3);
            DrawTriangle(tr);
        }

        private void CteateWithParamsTriangle(object sender, RoutedEventArgs e)
        {
            ClearScene();
            InputParamsTriangle IPT = new InputParamsTriangle(this);
            IPT.ShowDialog();
            DrawTriangle(tr);
            
        }

        private void RandomCreateRectangle(object sender, RoutedEventArgs e)
        {
            ClearScene();
            int RandomHight = rnd.Next(1, (int)Scene.Height);
            int RandomWidth = rnd.Next(1, (int)Scene.Width);
            Point2D MainPoint = new Point2D(rnd.Next(0, ((int)Scene.Width) - RandomWidth), rnd.Next(0, ((int)Scene.Height) - RandomHight));
            rect = new Rectangle(MainPoint,RandomWidth,RandomHight);
            DrawRectangle(rect);

        }
    }
}
