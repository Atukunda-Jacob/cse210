public class EternalGoal : Goal
{
    public EternalGoal(string n,string d,int p):base(n,d,p){}
    public override void RecordEvent(){}
    public override bool IsComplete(){return false;}
    public override string GetDetailsString(){return $"[ ] {_shortName} ({_description})";}
    public override string GetStringRepresentation(){return $"EternalGoal:{_shortName},{_description},{_points}";}
}
