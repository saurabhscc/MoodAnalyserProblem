using MoodAnalyserproblem;
using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace moodanalyserproblem
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        ///  CreateMoodAnalyse  method to create object of MoodAnalyse class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorname"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorname)
        {
            ////create pattern check whether constructor name and class name are equal
            string pattern = @"." + constructorname + "$";
            Match result = Regex.Match(className, pattern);
            // if true then create object.
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                // class not found then then throw exception class not found 
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }
            }
            // constructor name not equal to class name then throw exception constructor not found
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor is not found");
            }
        }
        /// <summary>
        /// CreateMoodAnalyse ParameterizedConstructor method for Object of Moodanalyse Class 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyserParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = Type.GetType(className);
            try
            {
                if (type.FullName.Equals(className) || type.Name.Equals(className))
                {
                    if (type.Name.Equals(constructorName))
                    {
                        ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                        object instance = info.Invoke(new object[] { message });
                        return instance;
                    }
                    else
                    {
                        throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
                    }
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}

