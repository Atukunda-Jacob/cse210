public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string n,string d,int p):base(n,d,p){_isComplete=false;}
    public SimpleGoal(string n,string d,int p,bool c):base(n,d,p){_isComplete=c;}
    public override void RecordEvent(){_isComplete=true;}
    public override bool IsComplete(){return _isComplete;}
    public override string GetDetailsString(){return $"{(_isComplete?"[X]":"[ ]")} {_shortName} ({_description})";}
    public override string GetStringRepresentation(){return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";}
}
