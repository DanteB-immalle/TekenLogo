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

namespace TekenLogo
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

        private void MijnKnop_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            DrawLogo(canvas, brush, 10, 20);
            DrawLogo(canvas, brush, 100, 100);
         
            DrawTriangle(canvas, brush, 100, 10, 40, 40);
            DrawTriangle(canvas, brush, 10, 100, 20, 60);
            


        }
        private void DrawRectangle(Canvas drawingArea, SolidColorBrush brushToUse, double xPos, double yPos, double size)
        {
            Rectangle rect = new Rectangle();
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(xPos, yPos, 0, 0);
            rect.Stroke = brushToUse;
            canvas.Children.Add(rect);
     
        }
        private void DrawLogo(Canvas drawingArea, SolidColorBrush brushToUse, double xPos, double yPos)
        {
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 20);
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 40);
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 60);
        }
        private void DrawTriangle(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double width, double height)
        {
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace + height, xPlace + width, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace + width, yPlace + height);
        }
        private void DrawLine(Canvas drawingArea, SolidColorBrush brushToUse, double startX, double startY, double endX, double endY)
        {
            Line l = new Line();
            l.X1 = startX;  l.X2 = endX;
            l.Y1 = startY;  l.Y2 = endY;
            l.Stroke = brushToUse;
            drawingArea.Children.Add(l);
        }

        }
}
