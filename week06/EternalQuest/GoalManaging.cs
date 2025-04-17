using System.Runtime;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class GoalManaging
{
    private List<Goal> _currentGoals;
    private List<Goal> _completedGoals;
    private int _totalScore;
    // private int _totalCoin;
    private int _playerLevel;
    // private int _levelIndex;
    private List<int> _levelGoals;
    private int _numGoalsAchieved;
    private string _saveFileName;
    public GoalManaging()
    {
    _currentGoals = new();
    _completedGoals = new();
    _totalScore = 0;
    // _totalCoin = 0;
    _playerLevel = 1;
    // _levelIndex = 0;
    _levelGoals = new() {500, 1000, 1700, 2700, 3900, 5200, 6800, 8500, 10200};
    _numGoalsAchieved = 0;
    _saveFileName = "Planchar.txt";
    }
    // public void Tutorial()
    // {

    // }
    public void Play()
    {
        bool exiting = false;
        do
        {
            Console.Clear();
            CW("___Menu___");
            CW("1. See Player Profile");
            CW("2. See Current Goals");
            CW("3. See Completed Goals");
            CW("4. Create a Goal");
            CW("5. Achieve a Goal");
            // CW("6. Renew a Goal");
            CW("6. Delete a Goal");
            CW("7. Save Player Profile");
            CW("8. Load Player Profile");
            CW("0. Exit");
            int choice = AskInt("\r\n> ") - 1;
            List<Action> junctions; 
            junctions = new() {DisplayPlayerInfo, DisplayCurrentMissions, DisplayOldMissions, CreateMission, AchieveMission, CancelGoal, SaveProfile, LoadProfile};
            // Exit
            if (choice == -1)
            {
                string exInt = AskUntil("Do you want to save before you exit? (Y/N)", new List<string> {"Y", "y", "N", "n"});
                if (exInt == "Y" || exInt == "y")
                {
                    SaveProfile();
                }
                exiting = true;
            }
            else
            {
                junctions[choice]();
            }
        } while (exiting == false);
        CW($"Have a nice day!");
    }
    public void DisplayPlayerInfo()
    {
        string display = "";
        display+= $"Player Info: ";
        display+= $"\r\n Player Level: {_playerLevel}";
        // display+= $"\r\n Dungeon Floor: {_levelIndex}";
        display+= $"\r\n Total Score: {_totalScore}";
        if (_playerLevel != 10)
        {
            display+= $"\r\n Points until next Level: {_levelGoals[_playerLevel] -_totalScore}";
        }
        else
        {
            display+= $"\r\n (At Max Level)";
        }
        // display+= $"\r\n Points to Spend: {_totalCoin}";
        display+= $"\r\n Goals Completed: {_numGoalsAchieved}";
        // display+= $"\r\n Player Level: {_currentGoals.Count}";
        Console.WriteLine($"\r\n{display}\r\n");
        Ask("\r\nPress Enter to Continue   ");
    }
    public void DisplayCurrentMissions()
    {
        CW($"\r\nCurrent Goals ({_currentGoals.Count}):");
        foreach (Goal mish in _currentGoals)
        {
            CW($"{mish.DisplayText()}");
        }
        Ask("\r\nPress Enter to Continue   ");
    }
    public void DisplayOldMissions()
    {
        CW($"\r\nCompleted Goals ({_completedGoals.Count}):");
        foreach (Goal mish in _completedGoals)
        {
            CW($"{mish.DisplayText()}");
        }
        Ask("\r\nPress Enter to Continue   ");
    }
    public void CreateMission()
    {
        int points = 0;
        int bonus = 500;
        string bonusText = "";
        string goalType = "";
        do 
        {
            CW($"What type of Goal would you like to Add?  (a,  b,  or  c)");
            CW($"a. One-Time");
            CW($"b. Eternal");
            CW($"c. Check-List");
            string answer = Console.ReadLine();
            if (answer == "a")
            {
                goalType = "simple";
                points = 100;
            }
            else if (answer == "b")
            {
                goalType = "eternal";
                points = 50;
            }
            else if (answer == "c")
            {
                goalType = "checkList";
                points = 80;
                bonusText = $", {bonus}";
            }
        } while (goalType == "");

        // Get general parameters
        string metaName = "";
        do
        {
            metaName = Ask("Type in the goal below. Make sure to make it attainable and positive.\r\n> ");
        } while (metaName == "");
        string defOrNoAns = "";
        do
        {
        defOrNoAns = Ask($"Do you want to use: \r\na. Default Reward Points ({points}{bonusText})\r\nb. Custom Reward Points");
        } while (defOrNoAns != "a" && defOrNoAns != "b");

        if (defOrNoAns == "b")
        {
            points = AskInt("How many points should you get when you achieve?\r\n> ");
        }
        // Make Simple
        if (goalType == "simple")
        {
            _currentGoals.Add(new SimpleGoal(metaName, points));
        }
        // Make Eternal
        else if (goalType == "eternal")
        {
            _currentGoals.Add(new EternalGoal(metaName, points));
        }
        // Make Checklist
        else if (goalType == "checkList")
        {
            int target = AskInt($"How many times do you want to achieve this goal?");
            if (defOrNoAns == "b")
            {
                bonus = AskInt($"How many bonus points should you get when you achieve {target} times?");
            }
            _currentGoals.Add(new CheckListGoal(metaName, points, bonus, target));
        }
        else
        {
            CW("WRONG: ERROR - No goal type recieved");
        }
    }
    public void AchieveMission()
    {
        if (_currentGoals.Count == 0)
        {
            CW("No Current Goals to Achieve");
            Ask("\r\nPress Enter to Continue   ");
            return;
        }
        string question = "What Goal did you achieve? ";
        int i = 0;
        foreach (Goal goal in _currentGoals)
        {
            i++;
            CW($"\r\n{i}. {goal.DisplayText()}");
        }
        int goalChosen = AskInt($"{question}\r\n> ") - 1;
        int pointsGotten = _currentGoals[goalChosen].Achieve();
        // _totalCoin += pointsGotten;
        _totalScore += pointsGotten;

        if (_currentGoals[goalChosen].IsComplete())
        {
            _completedGoals.Add(_currentGoals[goalChosen]);
            _currentGoals.RemoveAt(goalChosen);
        }

        Ask($"Achivement logged! You got {pointsGotten} points!");
        _numGoalsAchieved++;
        if (_playerLevel < 10)
        {
            if (_totalScore >= _levelGoals[_playerLevel - 1])
            {
                _playerLevel++;
                CW($"Well done! You reached Level {_playerLevel}!!!");
                Ask("\r\nPress Enter to Continue   ");
            }
        }
    }
    public void SaveProfile()
    {
        File.Create("Planchar.txt").Close();
        using (StreamWriter saveFile = new StreamWriter(_saveFileName))
///     private List<Goal> _currentGoals;
 ///   private List<Goal> _completedGoals;
    ///private int _totalScore;
   /// private int _playerLevel;
  ///  private int _numGoalsAchieved;

        {
            saveFile.WriteLine(_playerLevel); // 0
            saveFile.WriteLine(_totalScore); // 1
            saveFile.WriteLine(_numGoalsAchieved); // 2
            foreach (Goal goal in _currentGoals) // 3
            {
                saveFile.Write(goal.SaveText());
            }
            foreach (Goal goal in _completedGoals) // 4
            {
                saveFile.WriteLine();
                saveFile.Write(goal.SaveText());
            }
        }
        Ask($"Profile Saved. Press Enter to continue. ");

    } 
    public void LoadProfile()
    {
        string[] lines = File.ReadAllLines(_saveFileName);
        _playerLevel = int.Parse(lines[0]);
        _totalScore = int.Parse(lines[1]);
        _numGoalsAchieved = int.Parse(lines[2]);

        _currentGoals = new();
        string[] goalChunksCu = lines[3].Split("///");
        foreach (string goalChunk in goalChunksCu)
        {
            string[] goalParts = goalChunk.Split("[[[]]]");
            if (goalParts[0] == "0")
            {
                SimpleGoal loadedGoal = new SimpleGoal(goalParts[1], int.Parse(goalParts[2]));
                loadedGoal.MarkComplete();
                _currentGoals.Add(loadedGoal);
            }
            else if (goalParts[0] == "1")
            {
                EternalGoal loadedGoal = new EternalGoal(goalParts[1], int.Parse(goalParts[2]));
                loadedGoal.SetNum(int.Parse(goalParts[3]));
                _currentGoals.Add(loadedGoal);
            }
            else if (goalParts[0] == "2")
            {
                CheckListGoal loadedGoal = new CheckListGoal(goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[4]), int.Parse(goalParts[5]));
                loadedGoal.SetNum(int.Parse(goalParts[3]));
                _currentGoals.Add(loadedGoal);
            }
        }

        _completedGoals = new();
        string[] goalChunksCom = lines[4].Split("///");
        foreach (string goalChunk in goalChunksCom)
        {
            string[] goalParts = goalChunk.Split("[[[]]]");
            if (goalParts[0] == "0")
            {
                SimpleGoal loadedGoal = new SimpleGoal(goalParts[1], int.Parse(goalParts[2]));
                loadedGoal.MarkComplete();
                _completedGoals.Add(loadedGoal);
            }
            else if (goalParts[0] == "1")
            {
                EternalGoal loadedGoal = new EternalGoal(goalParts[1], int.Parse(goalParts[2]));
                loadedGoal.SetNum(int.Parse(goalParts[3]));
                _completedGoals.Add(loadedGoal);
            }
            else if (goalParts[0] == "2")
            {
                CheckListGoal loadedGoal = new CheckListGoal(goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[4]), int.Parse(goalParts[5]));
                loadedGoal.SetNum(int.Parse(goalParts[3]));
                _completedGoals.Add(loadedGoal);
            }
        }
        Ask($"Profile Loaded. Press Enter to continue. ");

    }
    // public void ResurrectMission()
    // {
    //     string question = "What Goal will you renew? ";
    //     int i = 0;
    //     foreach (Goal goal in _completedGoals)
    //     {
    //         i++;
    //         CW($"\r\n{i}. {goal.DisplayText()}");
    //     }
    //     int goalChosen = AskInt($"{question}\r\n> ") - 1;
    //     _completedGoals.RemoveAt(goalChosen);
    //     // _totalCoin += pointsGotten;
    //     Ask($"Goal deleted. Press Enter to continue. ");
    // }
    public void CancelGoal()
    {
        if (_currentGoals.Count == 0)
        {
            CW("No Current Goals to Delete");
            Ask("\r\nPress Enter to Continue   ");
            return;
        }

        string question = "What Goal will you remove? ";
        int i = 0;
        foreach (Goal goal in _currentGoals)
        {
            i++;
            CW($"\r\n{i}. {goal.DisplayText()}");
        }
        int goalChosen = AskInt($"{question}\r\n> ") - 1;
        _currentGoals.RemoveAt(goalChosen);
        // _totalCoin += pointsGotten;
        Ask($"Goal deleted. Press Enter to continue. ");
    }
    // Clerical, Private Functions: ___
    private void CW(string input)
    {
        Console.WriteLine(input);
    }
    private void Cw(string input)
    {
        Console.Write(input);
    }
    private string CR()
    {
        return Console.ReadLine();
    }
    private string Ask(string input)
    {
        Cw(input);
        string answer = CR();
        return answer;
    }
    private int AskInt(string input)
    {
        int intAnswer;
        string answer;
        do 
        {
            answer = Ask(input);
        } while (!int.TryParse(answer, out intAnswer));
        return intAnswer;
    }
    private int AskIntil(string input, int lowbBound, int hiBound)
    {
        int intAnswer;
        string answer;
        do
        {
            do 
            {
                answer = Ask(input);
            } while (!int.TryParse(answer, out intAnswer));
        } while (intAnswer >= lowbBound && intAnswer <= hiBound);
        return intAnswer;
    }
    private string AskUntil(string input, List<string> requestList)
    {
        bool fits = false;
        string answer;
        do 
        {
            answer = Ask(input);
            foreach (string str in requestList)
            {
                if (str == answer)
                {
                    fits = true;
                }
            }
        } while (!fits);
        return answer;
    }
}
