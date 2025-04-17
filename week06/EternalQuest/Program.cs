using System;



/// <summary>
/// Exceeding Requirements: 
/// 0. Added Player Levels. 
/// 1. Choice between Custom and Default point values for Goals
/// 2. Keeping track of how many times you've accomplished the Eternal Goals
/// 3. Able to remove goals
/// 5. When exiting, you are prompted to save
/// 6. Tracks points until next Level
/// 7. Tallies total number of goals completed. 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        GoalManaging gM = new();
        gM.Play();
    }
}