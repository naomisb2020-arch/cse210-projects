using System;

class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
        
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()}:{GetDescription()}:{GetPoints()}:{_isComplete}";
    }
}
