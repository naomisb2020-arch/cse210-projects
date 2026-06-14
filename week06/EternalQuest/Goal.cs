using System;

abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();


    public virtual string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        
        return $"{check} {_shortName} ({_description})";
    }

    public string GetPoints()
    {
        return _points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
}


