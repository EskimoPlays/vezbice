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

        int movingBallIndex;
        bool ballIsMoving = false;
        private List<Ball> balls;
        private Point dragOffset;

        private void Form1_Paint(object sender, PaintEventArgs e) =>
            balls.ForEach(ball =>
            { ball.Draw(e.Graphics); ball.Fill(e.Graphics); });

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            movingBallIndex = balls.FindIndex(ball => ball.Contains(e.Location));
            if (movingBallIndex == -1) return;
            ballIsMoving = true;

            Point center = balls[movingBallIndex].Center;
            dragOffset = new Point(e.X - center.X, e.Y - center.Y);
            SwapColorTimer.Enabled = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ballIsMoving = false;
            SwapColorTimer.Enabled = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ballIsMoving) return;
            Point newCenter = new(e.X - dragOffset.X, e.Y - dragOffset.Y);
            balls[movingBallIndex].Move(newCenter);

            Invalidate();
        }

        private void SwapColorTimer_Tick(object sender, EventArgs e)
        {
            balls[movingBallIndex].ChangeRColor();
        }
    }
}
