namespace RazmestanjeLoptica;

internal abstract class MoveableEntity
{
    public abstract Point Center { get; set; }

    ///public void Start();
    public abstract void Move(Point newCenter);
    public abstract bool Contains(Point point);
}
