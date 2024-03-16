using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EternalQuestLibrary
{
    public class EternalQuest
    {
        private List<Goal> _goals;
        private int _score;

        public EternalQuest()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public string RecordEvent(int goalIndex)
        {
            if (goalIndex < _goals.Count)
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _score += pointsEarned;
                return $"Completed goal '{_goals[goalIndex]}' and earned {pointsEarned} points.";
            }
            else
            {
                return ""; // Invalid goal index
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Current Score: {_score}");
        }

        public void DisplayGoals()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i]}");
            }
        }

        public void SaveProgress(string filename)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(filename, json);
        }

        public static EternalQuest LoadProgress(string filename)
        {
            string json = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<EternalQuest>(json);
        }
    }
}
