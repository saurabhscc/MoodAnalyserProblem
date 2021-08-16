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
            try
            {
                string message = msg.ToLower();
                if (message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood is null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Mood is empty");
                }
                if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException )
            {
                return "happy";
            }
        }
    }
}
