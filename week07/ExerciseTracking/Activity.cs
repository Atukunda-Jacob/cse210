public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string name = GetType().Name;
        return $"{_date} {name} ({_minutes} min): Distance {distance:0.0} km, Speed: {speed:0.0} kph, Pace: {pace:0.00} min per km";
    }
}
