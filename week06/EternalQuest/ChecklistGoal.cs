public class ChecklistGoal : Goal
{
    private int _amountCompleted; private int _target; private int _bonus;
    public ChecklistGoal(string n,string d,int p,int t,int b):base(n,d,p){_target=t; _bonus=b; _amountCompleted=0;}
    public ChecklistGoal(string n,string d,int p,int b,int t,int a):base(n,d,p){_bonus=b; _target=t; _amountCompleted=a;}
    public override void RecordEvent(){_amountCompleted++;}
    public override bool IsComplete(){return _amountCompleted>=_target;}
    public override string GetDetailsString(){return $"{(IsComplete()?"[X]":"[ ]")} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";}
    public override string GetStringRepresentation(){return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";}
    public int GetBonus(){return _bonus;}
}
