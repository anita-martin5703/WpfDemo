// Programmer: Anita Martin
// Email: amartin98@cnm.edu

// Assignment.cs

using System;

namespace WpfDemo
{
    public class Assignment
    {
        public string Title { get; set; }
        public int score;
        public int Score
        {
            get { return score; }
            set
            {
                //Validate list of scores pased in as value
                if (value >= 0 && value <= 100)
                {
                    score = value;
                }
                else//it's not valid, throw an exception
                {
                    throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
                }
            }

        }
        public override string ToString()
        {
            return Title + " " + score;
        }

    }
}
