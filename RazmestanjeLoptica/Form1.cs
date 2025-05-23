namespace RazmestanjeLoptica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            balls = [];
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int spacing = 60;

            for (int x = 0; x < ClientRectangle.Width; x += spacing)
            {
                for (int y = 0; y < ClientRectangle.Height; y += spacing)
                {
                    int radius = Random.Shared.Next(10, 30);
                    int offsetX = Random.Shared.Next(-10, 10);
                    int offsetY = Random.Shared.Next(-10, 10);
                    Point position = new(x + offsetX, y + offsetY);
                    balls.Add(new Ball(radius, position));
                }
            }
        }

        private Ball? _lastMovingBall;
        private List<Ball> balls;
        private Point dragOffset;

        private void Form1_Paint(object sender, PaintEventArgs e) =>
            balls.ForEach(ball =>
            { ball.Draw(e.Graphics); ball.Fill(e.Graphics); });

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _lastMovingBall = balls.Find(ball => ball.Contains(e.Location));
            if (_lastMovingBall is null) return;

            Point center = _lastMovingBall.Center;
            dragOffset = new Point(e.X - center.X, e.Y - center.Y);
            SwapColorTimer.Enabled = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _lastMovingBall = null;
            SwapColorTimer.Enabled = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_lastMovingBall is null) return;
            Point newCenter = new(e.X - dragOffset.X, e.Y - dragOffset.Y);
            _lastMovingBall.Move(newCenter);

            Invalidate();
        }

        private void SwapColorTimer_Tick(object sender, EventArgs e)
        {
            _lastMovingBall?.ChangeRColor();
        }
    }
}
