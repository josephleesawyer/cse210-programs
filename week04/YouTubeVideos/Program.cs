using System;

class Program
{
    static void Main(string[] args)
    {
        string author1 = "John";
        string author2 = "Jason";
        string author3 = "Jingleheimer";
        string author4 = "Schmidt";

        List<string>  authors = new();
        authors.Add(author1);
        authors.Add(author2);
        authors.Add(author3);
        authors.Add(author4);

        string title1 = "Such to Do About Something";
        string title2 = "Jomeo and Ruliette";
        string title3 = "The Shaming of the Trew";
        string title4 = "Ling Kear";

        List<string>  titles = new();
        titles.Add(title1);
        titles.Add(title2);
        titles.Add(title3);
        titles.Add(title4);

        string commenter1 = "loverly";
        string commenter2 = "day4";
        string commenter3 = "ettin";
        string commenter4 = "pi";

        List<string>  commenters = new();
        commenters.Add(commenter1);
        commenters.Add(commenter2);
        commenters.Add(commenter3);
        commenters.Add(commenter4);

        string prefix1 = "This stuff";
        string prefix2 = "This vid";
        string prefix3 = "This content";
        string prefix4 = "This gem";

        List<string>  prefixes = new();
        prefixes.Add(prefix1);
        prefixes.Add(prefix2);
        prefixes.Add(prefix3);
        prefixes.Add(prefix4);

        string suffix1 = "was incredible!";
        string suffix2 = "was amazing!";
        string suffix3 = "was worth it all.";
        string suffix4 = "brought tears to my eyes. Beauty!! (`:";

        List<string>  suffixes = new();
        suffixes.Add(suffix1);
        suffixes.Add(suffix2);
        suffixes.Add(suffix3);
        suffixes.Add(suffix4);

        int seconds1 = 16;
        int seconds2 = 18;
        int seconds3 = 14;
        int seconds4 = 13;

        List<int>  secondses = new();
        secondses.Add(seconds1);
        secondses.Add(seconds2);
        secondses.Add(seconds3);
        secondses.Add(seconds4);

        Video video1 = new(title1, author1, seconds1);
        Video video2 = new(title2, author2, seconds2);
        Video video3 = new(title3, author3, seconds3);
        Video video4 = new(title4, author4, seconds4);

        List<Video>  videos = new();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j<4; j++)
            {
                Comment com = new(commenters[j], $"{prefixes[j]} {suffixes[(j+i)%4]}");
                videos[i].AddComment(com);
            }
        } 


        foreach (Video video in videos)
        {
            Console.WriteLine(video.VidAndComDisplay());
        }
    }
}