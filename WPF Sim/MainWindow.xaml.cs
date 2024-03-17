using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_Sim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse el = new Ellipse();
        private Point pos = new(0, 0);
        private Point delta = new(15,15);
        
        public MainWindow()
        {
            InitializeComponent();

            el.Width = el.Height = 100;
            el.Fill = new SolidColorBrush(Colors.Red);

            draw.Children.Add(el);

            Canvas.SetTop(el, pos.Y-50);
            Canvas.SetLeft(el, pos.X-50);

            DispatcherTimer t = new()
            {
                Interval = TimeSpan.FromMilliseconds(100)
            };

            t.Tick += T_Tick;
            t.Start();

        }

        private void T_Tick(object? sender, EventArgs e)
        {
            Random r = new Random();

            if (pos.X <= 0) delta.X = (Math.Abs(delta.X) * (r.NextDouble() + 0.5));
            if (pos.X >= draw.RenderSize.Width) delta.X = -(Math.Abs(delta.X) * (r.NextDouble() + 0.5));
            if (pos.Y <= 0) delta.Y = (Math.Abs(delta.Y) * (r.NextDouble() + 0.5));
            if (pos.Y >= draw.RenderSize.Height) delta.Y = -(Math.Abs(delta.Y) * (r.NextDouble() + 0.5));

            pos.X += delta.X;
            pos.Y += delta.Y;

            Canvas.SetTop(el, pos.Y - 50);
            Canvas.SetLeft(el, pos.X - 50);
        }
    }
}