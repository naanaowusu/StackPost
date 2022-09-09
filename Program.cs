using System;

namespace StackOverflowPost_App
{
    class Program
    {
        static void Main(string[] args)
        {

            var showpost = new Post();
            showpost.Title = "How to upload a file to Github";
            showpost.Description = "I have been trying to upload my work on Github\nI have some problems\nCan anyone show to do this.";
            showpost.Timecreated = new DateTime(2022,9,9);

            showpost.UpVote();
            showpost.UpVote();
            showpost.UpVote();
            showpost.UpVote();
            showpost.UpVote();
            

            showpost.DownVote();
            showpost.DownVote();

            showpost.DisplayPost();
                    


            

            Console.ReadKey();
        }
    }
}
