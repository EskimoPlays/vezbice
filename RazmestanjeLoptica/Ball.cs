namespace RazmestanjeLoptica;

internal class Ball : MoveableEntity, IDisplayable
{
    public Ball(int radius, Point center)
    {
        (Radius, color, Center) = 
            (radius, Randomizer.RColor(), center);

        _brush = new SolidBrush(color);
        _pen = new Pen(_brush, 3f);
        circle = new Rectangle(Center, new Size(Radius * 2, Radius * 2));
    }

    Point _center;
    public override Point Center
    {
        get => _center;
        set
        {
            _center = new Point(value.X + Radius, value.Y + Radius);
            circle = new Rectangle(
                value.X,
                value.Y,
                Radius * 2,
                Radius * 2);
        }
    }

    public override void Move(Point newCenter)
    {
        Center = newCenter;
    }

    public override bool Contains(Point point)=>
        circle.Contains(point);

    public void Fill(Graphics graphics)
    {
        graphics.FillEllipse(_brush, circle);
    }

    public void Draw(Graphics graphics)
    {
        graphics.DrawEllipse(_pen, circle);
    }

    public void ChangeRColor()=>
        _brush = new SolidBrush(Randomizer.RColor());

    private Rectangle circle;
    private Brush _brush;
    private readonly Pen _pen;
    private readonly Color color;
    public int Radius { get; private set; }
}
