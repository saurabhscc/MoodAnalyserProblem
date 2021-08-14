using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserproblem
{
     public class MoodAnalyser
    {
        private string msg;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }
        public string AnalyseMood()
        {
            string message = msg.ToLower();
            if (message.Contains("Happy"))
                return "HAPPY";
            else
                return "SAD";
        }
    }
}
