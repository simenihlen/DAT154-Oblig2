namespace SpaceObjectsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            this.BackColor = Color.Black;

            Brush sun = new SolidBrush(Color.Yellow);

            g.FillEllipse(sun, 0, 0, 50, 50);
        }
    }
}
