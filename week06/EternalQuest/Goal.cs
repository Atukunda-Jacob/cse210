public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string n, string d, int p){_shortName=n; _description=d; _points=p;}
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
    public string GetName(){return _shortName;}
    public int GetPoints(){return _points;}
}
