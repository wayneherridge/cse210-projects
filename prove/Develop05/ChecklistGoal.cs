using System;

public class ChecklistGoal : Goal
{
    private int _completedTimes;
    private int _requiredTimes;
    private int _bonusValue;

    public ChecklistGoal(int requiredTimes, int bonusValue)
    {
        _completedTimes = 0;
        this._requiredTimes = requiredTimes;
        this._bonusValue = bonusValue;
    }

    public override void RecordEvent()
    {
        _completedTimes++;

        if (_completedTimes >= _requiredTimes)
        {
            _goalValue += _bonusValue;
        }
    }

    public override string GetGoalStatus()
    {
        return $"Completed {_completedTimes}/{_requiredTimes} times";
    }

    public override string GetFormattedGoal()
    {
        return $"Name: {_goalName}\nDescription: {_goalDescription}\nStatus: {GetGoalStatus()}";
    }
}
