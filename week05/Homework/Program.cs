using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new("Matthew McCaughnehey", "Saying Alright Thrice");
        MathAssignment mA1 = new("Batman", "How to Save Gotham from Giant Penguins", "BatSection 4", "BatProblems 19-39");
        WritingAssignment wA1 = new("Count of Monte Cristo", "How to Count from 1 to 10", "How I learned to Count");



        Console.WriteLine(assign1.StudAndTopDisplay());
        Console.WriteLine(mA1.StudAndTopDisplay());
        Console.WriteLine(mA1.HomeworkDisplay());
        Console.WriteLine(wA1.StudAndTopDisplay());
        Console.WriteLine(wA1.EssayDisplay());        
    }
}