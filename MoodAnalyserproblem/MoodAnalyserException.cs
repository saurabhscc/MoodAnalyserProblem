using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserproblem
{
    public class MoodAnalyserException : Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD, NO_SUCH_CLASS, NO_SUCH_CONSTRUCTOR,NO_SUCH_METHOD
        }
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}