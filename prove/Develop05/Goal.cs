using System;

namespace EternalQuestLibrary
{
    public abstract class Goal
    {
        protected string _name;
        private int _value;
        protected bool _completed;

        public string Name => _name;
        public int Value => _value;
        public bool Completed => _completed;

        protected Goal(string name, int value)
        {
            _name = name;
            _value = value;
            _completed = false;
        }

        public virtual int RecordEvent()
        {
            _completed = true;
            return _value;
        }

        public virtual string GetStatus()
        {
            return _completed ? "[X]" : "[ ]";
        }

        public override string ToString()
        {
            return $"{GetStatus()} {_name}";
        }
    }

    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int value) : base(name, value) { }
    }

    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int value) : base(name, value) { }

        public override int RecordEvent()
        {
            return Value;
        }
    }

    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _target;

        public ChecklistGoal(string name, int value, int target) : base(name, value)
        {
            _timesCompleted = 0;
            _target = target;
        }

        public override int RecordEvent()
        {
            _timesCompleted++;
            if (_timesCompleted >= _target)
            {
                _completed = true;
                return Value + 500; // Bonus points
            }
            else
            {
                return Value;
            }
        }

        public override string GetStatus()
        {
            return _completed ? $"Completed {_timesCompleted}/{_target} times" : $"[ ] {_name}";
        }
    }
}
