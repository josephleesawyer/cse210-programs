using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Llama Wrangler";
        job1._companyName = "Llama Mia";
        job1._startYear = 1962;
        job1._endYear = 1978;
        
        Job job2 = new Job();
        job2._jobTitle = "Batman";
        job2._companyName = "Wayne Enterprises";
        job2._startYear = 1979;
        job2._endYear = 1981;

        // job1.DisplayJob();
        // job2.DisplayJob();


        Resume resume1 = new Resume();
        resume1._namePerson = "Mac Guiver";
        resume1._jobHistory.Add(job1); 
        resume1._jobHistory.Add(job2);
        
        resume1.DisplayResume();
    }
}