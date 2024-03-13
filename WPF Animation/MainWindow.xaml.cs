using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _5___WPF_Animation {

    public partial class MainWindow : Window {
        private readonly DispatcherTimer t;
        private readonly Planet p;
        private readonly Planet p2;
        private readonly Planet p3;
        private readonly Planet p4;
        private readonly Planet p5;
        private readonly Planet p6;
        private readonly Planet p7;
        private readonly Planet p8;
        private readonly Planet p9;
        int time = 0;
        public event Action<int> MoveIt;

        public MainWindow() {
            InitializeComponent();

            t = new() 
            {
                Interval = new TimeSpan(200000)
            };
            t.Tick += Tick;
            t.Start();

            p = new()
            {
                Shape = mercury
            };
            MoveIt += p.CalcPos;

            p2 = new()
            {
                Shape = venus,
                OrbitalRadius = 100,
                OrbitalSpeed = 2.5
            };
            MoveIt += p2.CalcPos;

            p3 = new()
            {
                Shape = earth,
                OrbitalRadius = 150,
                OrbitalSpeed = 4.15
            };
            MoveIt += p3.CalcPos;

            p4 = new()
            {
                Shape = mars,
                OrbitalRadius = 200,
                OrbitalSpeed = 7.8
            };
            MoveIt += p4.CalcPos;

            p5 = new()
            {
                Shape = jupiter,
                OrbitalRadius = 250,
                OrbitalSpeed = 10
            };
            MoveIt += p5.CalcPos;

            p6 = new()
            {
                Shape = saturn,
                OrbitalRadius = 300,
                OrbitalSpeed = 12.5
            };
            MoveIt += p6.CalcPos;

            p7 = new()
            {
                Shape = uranus,
                OrbitalRadius = 350,
                OrbitalSpeed = 15
            };
            MoveIt += p7.CalcPos;

            p8 = new()
            {
                Shape = neptune,
                OrbitalRadius = 400,
                OrbitalSpeed = 17
            };
            MoveIt += p8.CalcPos;

            p9 = new()
            {
                Shape = pluto,
                OrbitalRadius = 450,
                OrbitalSpeed = 20
            };
            MoveIt += p9.CalcPos;

        }

        private void Tick(object sender, EventArgs e) {
            MoveIt(time++);
        }
    }


    class Planet {

        public int Xpos { get; set; }
        public int Ypos { get; set; }

        public double OrbitalRadius { get; set; } = 200;
        public double OrbitalSpeed { get; set; } = 1;

        public Ellipse Shape { get; set; }

        public void CalcPos(int time) {
            Canvas c = (Canvas)Shape.Parent;

            Xpos = (int)(c.RenderSize.Width / 2 - Shape.Width / 2 +
                (Math.Cos(time * OrbitalSpeed * 3.1416 / 180) * OrbitalRadius));
            Ypos = (int)(c.RenderSize.Height / 2 - Shape.Height / 2 +
                (Math.Sin(time * OrbitalSpeed * 3.1416 / 180) * OrbitalRadius));

            Canvas.SetLeft(Shape, Xpos);
            Canvas.SetTop(Shape, Ypos);

        }
    }


}
