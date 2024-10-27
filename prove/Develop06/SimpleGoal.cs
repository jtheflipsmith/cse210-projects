public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetName()}, {GetDescription()}, {GetPoints()}, ";
    }
}