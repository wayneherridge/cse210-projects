using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Goal> goalsList = new List<Goal>();
    private static int totalScore = 0;
    private static string fileName = "goals.txt";

    public static void Main()
    {
        LoadGoals();
        MainMenu();
    }

    private static void MainMenu()
    {
        MenuScore();

        Console.WriteLine("========== Eternal Quest ==========");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Show Goals");
        Console.WriteLine("4. Show Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Exit");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CreateNewGoal();
                break;
            case 2:
                RecordEvent();
                break;
            case 3:
                ShowGoals();
                break;
            case 4:
                ShowScore();
                break;
            case 5:
                SaveGoals();
                break;
            case 6:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                MainMenu();
                break;
        }
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("========== Create New Goal ==========");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Back");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateChecklistGoal();
                break;
            case 4:
                MainMenu();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                CreateNewGoal();
                break;
        }
    }

    private static void CreateSimpleGoal()
    {
        Console.WriteLine("========== Create Simple Goal ==========");
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        Goal goal = new SimpleGoal();
        goal.GoalName = name;
        goal.GoalDescription = description;
        goal.GoalValue = value;

        goalsList.Add(goal);
        Console.WriteLine("Simple goal created successfully!");
        MainMenu();
    }

    private static void CreateEternalGoal()
    {
        Console.WriteLine("========== Create Eternal Goal ==========");
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        Goal goal = new EternalGoal();
        goal.GoalName = name;
        goal.GoalDescription = description;
        goal.GoalValue = value;

        goalsList.Add(goal);
        Console.WriteLine("Eternal goal created successfully!");
        MainMenu();
    }

    private static void CreateChecklistGoal()
    {
        Console.WriteLine("========== Create Checklist Goal ==========");
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter required times for completion: ");
        int requiredTimes = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus value upon completion: ");
        int bonusValue = int.Parse(Console.ReadLine());

        Goal goal = new ChecklistGoal(requiredTimes, bonusValue);
        goal.GoalName = name;
        goal.GoalDescription = description;
        goal.GoalValue = value;

        goalsList.Add(goal);
        Console.WriteLine("Checklist goal created successfully!");
        MainMenu();
    }

    private static void RecordEvent()
    {
        Console.WriteLine("========== Record Event ==========");
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalsList[i].GetFormattedGoal()}");
        }

        Console.WriteLine($"{goalsList.Count + 1}. Back");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == goalsList.Count + 1)
        {
            MainMenu();
        }
        else if (choice > 0 && choice <= goalsList.Count)
        {
            Goal selectedGoal = goalsList[choice - 1];
            selectedGoal.RecordEvent();
            totalScore += selectedGoal.GoalValue;
            Console.WriteLine("Event recorded successfully!");
            RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            RecordEvent();
        }
    }

    private static void ShowGoals()
    {
        Console.WriteLine("========== Goals ==========");

        if (goalsList.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            for (int i = 0; i < goalsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goalsList[i].GetFormattedGoal()}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        MainMenu();
    }

        private static void MenuScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {totalScore} points.");
        Console.WriteLine();
    }
    private static void ShowScore()
    {
        Console.WriteLine("========== Score ==========");
        Console.WriteLine($"Total Score: {totalScore}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        MainMenu();
    }

    private static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Total Score: {totalScore}");

            foreach (Goal goal in goalsList)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.GoalName);
                writer.WriteLine(goal.GoalDescription);
                writer.WriteLine(goal.GoalValue);
                writer.WriteLine(goal.GetGoalStatus());

                if (goal is EternalGoal)
                {
                    writer.WriteLine(((EternalGoal)goal).GetFormattedGoal());
                }
                else if (goal is ChecklistGoal)
                {
                    writer.WriteLine(((ChecklistGoal)goal).GetFormattedGoal());
                }

                writer.WriteLine();
            }
        }

        Console.WriteLine("Goals saved successfully!");
        MainMenu();
    }

    private static void LoadGoals()
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                bool isScoreLine = true;
                Goal goal = null;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isScoreLine)
                    {
                        isScoreLine = false;
                        totalScore = int.Parse(line.Split(':')[1].Trim());
                    }
                    else if (line == "SimpleGoal")
                    {
                        goal = new SimpleGoal();
                    }
                    else if (line == "EternalGoal")
                    {
                        goal = new EternalGoal();
                    }
                    else if (line == "ChecklistGoal")
                    {
                        goal = new ChecklistGoal(0, 0);
                    }
                    else if (goal != null)
                    {
                        if (line.StartsWith("Name:"))
                        {
                            goal.GoalName = line.Split(':')[1].Trim();
                        }
                        else if (line.StartsWith("Description:"))
                        {
                            goal.GoalDescription = line.Split(':')[1].Trim();
                        }
                        else if (line.StartsWith("Value:"))
                        {
                            goal.GoalValue = int.Parse(line.Split(':')[1].Trim());
                        }
                        else if (line.StartsWith("Status:"))
                        {
                        }
                        else if (line.StartsWith("Completed") || line == "Never Complete")
                        {
                        }
                        else if (line == "")
                        {
                            goalsList.Add(goal);
                            goal = null;
                        }
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No goals file found. Starting with a fresh slate.");
        }
    }
}
