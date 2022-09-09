using System;

namespace StackOverflowPost_App
{
    public class Post 
    {
        public string  Title { get; set; }
        public string Description { get; set; }
        public DateTime Timecreated { get; set; }
        public int Votes { get; set; }

        public void UpVote() 
        {
            Votes++;

        }
        public void DownVote() 
        {
            Votes--;
        }

        public void DisplayPost() 
        {
            Console.WriteLine(Title);
            Console.WriteLine();

            Console.WriteLine("The date Posted:" + Timecreated.ToLongDateString());
            Console.WriteLine();

            Console.WriteLine(Description);
            Console.WriteLine();
            Console.WriteLine("The vote is: " + Votes);
        }

    }
}
