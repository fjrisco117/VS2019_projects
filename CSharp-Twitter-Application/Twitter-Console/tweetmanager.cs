using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter_Console
{
    class tweetmanager
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
            {
                return "Error: Tweet is longer than 140 chars";
            }

            if (tweetCounter >= tweets.Length)
            {
                return "Error: Max Tweets Reached";
            }

            tweets[tweetCounter++] = tweet;

            return "Tweet Posted Successfully";
        }

        public string[] GetTweets()
        {
            return tweets;
        }

        public int TweetCount()
        {
            return tweetCounter;
        }


    }
}
