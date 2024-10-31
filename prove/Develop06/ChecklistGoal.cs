public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        string detail = $"{GetName()} ({GetDescription()}) points: {GetPoints()} finish bonus: {_bonus} | {_amountCompleted}/{_target}";
        return $"{checkbox}  {detail}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {_target}, {_bonus}";
    }

}