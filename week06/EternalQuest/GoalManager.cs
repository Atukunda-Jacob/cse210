public class GoalManager
{
    private List<Goal> _goals=new List<Goal>(); private int _score=0;
    public void Start(){
        while(true){
            Console.WriteLine($"\nYou have {_score} points.\nMenu: 1.Create 2.List 3.Save 4.Load 5.Record 6.Quit");
            Console.Write("Choice: "); string c=Console.ReadLine();
            if(c=="1") CreateGoal(); else if(c=="2") ListGoalDetails(); else if(c=="3") SaveGoals(); else if(c=="4") LoadGoals(); else if(c=="5") RecordEvent(); else if(c=="6") break;
        }
    }
    public void DisplayPlayerInfo(){Console.WriteLine($"\nYou have {_score} points.\n");}
    public void ListGoalNames(){for(int i=0;i<_goals.Count;i++) Console.WriteLine($"{i+1}. {_goals[i].GetName()}");}
    public void ListGoalDetails(){Console.WriteLine("The goals are:"); for(int i=0;i<_goals.Count;i++) Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");}
    public void CreateGoal(){
        Console.WriteLine("1.Simple 2.Eternal 3.Checklist"); Console.Write("Which type? "); string t=Console.ReadLine();
        Console.Write("Name: "); string n=Console.ReadLine(); Console.Write("Desc: "); string d=Console.ReadLine(); Console.Write("Points: "); int p=int.Parse(Console.ReadLine());
        if(t=="1") _goals.Add(new SimpleGoal(n,d,p));
        else if(t=="2") _goals.Add(new EternalGoal(n,d,p));
        else if(t=="3"){Console.Write("Target: "); int tar=int.Parse(Console.ReadLine()); Console.Write("Bonus: "); int bon=int.Parse(Console.ReadLine()); _goals.Add(new ChecklistGoal(n,d,p,tar,bon));}
    }
    public void RecordEvent(){
        ListGoalNames(); Console.Write("Which goal? "); int idx=int.Parse(Console.ReadLine())-1;
        bool was=_goals[idx].IsComplete(); _goals[idx].RecordEvent(); int pts=_goals[idx].GetPoints(); _score+=pts;
        if(_goals[idx] is ChecklistGoal cg && cg.IsComplete() &&!was){_score+=cg.GetBonus(); Console.WriteLine($"Earned {pts}+ bonus {cg.GetBonus()}!");}
        else Console.WriteLine($"Earned {pts}!");
    }
    public void SaveGoals(){Console.Write("Filename: "); string f=Console.ReadLine(); using(StreamWriter w=new StreamWriter(f)){w.WriteLine(_score); foreach(var g in _goals) w.WriteLine(g.GetStringRepresentation());}}
    public void LoadGoals(){Console.Write("Filename: "); string f=Console.ReadLine(); string[] lines=File.ReadAllLines(f); _score=int.Parse(lines[0]); _goals.Clear(); for(int i=1;i<lines.Length;i++){string[] parts=lines[i].Split(":"); string[] data=parts[1].Split(","); if(parts[0]=="SimpleGoal") _goals.Add(new SimpleGoal(data[0],data[1],int.Parse(data[2]),bool.Parse(data[3]))); else if(parts[0]=="EternalGoal") _goals.Add(new EternalGoal(data[0],data[1],int.Parse(data[2]))); else if(parts[0]=="ChecklistGoal") _goals.Add(new ChecklistGoal(data[0],data[1],int.Parse(data[2]),int.Parse(data[3]),int.Parse(data[4]),int.Parse(data[5])));}}
}
