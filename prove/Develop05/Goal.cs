using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalValue;

    public string GoalName
    {
        get { return _goalName; }
        set { _goalName = value; }
    }

    public string GoalDescription
    {
        get { return _goalDescription; }
        set { _goalDescription = value; }
    }

    public int GoalValue
    {
        get { return _goalValue; }
        set { _goalValue = value; }
    }

    public abstract void RecordEvent();
    public abstract string GetGoalStatus();
    public abstract string GetFormattedGoal();
}
