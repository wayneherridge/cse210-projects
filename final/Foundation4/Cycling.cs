public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {_speed} kph, Pace: {GetPace()} min/km";
    }
}
