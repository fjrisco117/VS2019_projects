using System;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            tweetmanager tm = new tweetmanager();

            do
            {
                Console.WriteLine("------Main Menu------");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Enter New  Tweet");
                Console.WriteLine("3. Exit");

                choice = Console.ReadLine();

                Console.WriteLine("You selected #{0}", choice);

                if (choice == "1")
                {
                    for (int i = 0; i < tm.TweetCount(); i++)
                    { 
                            Console.WriteLine("Your tweet #{0} is: {1}, and your tweet length is {2}", i + 1,
                               tm.GetTweets()[i], tm.GetTweets()[i].Length);
                    }
                }

                if (choice == "2")
                {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();
                    string msg = tm.PostTweet(tweet);

                }
            }
            while (choice!="3");

            Console.ReadLine();
            
        }
    }
}
