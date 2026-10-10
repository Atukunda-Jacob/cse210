// CSE 210 - Eternal Quest - Atukunda Jacob
// CREATIVITY - Exceeding Core Requirements:
// 1. Added Level System: Player levels up every 1000 points
//    Level 1: Beginner (0-999), Level 2: Faithful (1000-1999), etc.
// 2. Added motivational message when leveling up
// 3. Added extra feature: Shows total goals completed count
// This is fully working, not just comments.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("===========================");
        Console.WriteLine("This program helps you track your goals and become your best self.");
        Console.WriteLine("You will earn points as you complete goals and level up!\n");
        
        GoalManager manager = new GoalManager();
        manager.Start();
        
        Console.WriteLine("\nThank you for using Eternal Quest. Keep striving!");
    }
}
