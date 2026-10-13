using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity running = new Running("03 Nov 2022", 30, 4.8);
        Activity cycling = new Cycling("03 Nov 2022", 30, 15.0);
        Activity swimming = new Swimming("03 Nov 2022", 30, 20);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
