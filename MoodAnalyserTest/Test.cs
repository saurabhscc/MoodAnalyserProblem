using moodanalyserproblem;
using MoodAnalyserproblem;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Test Case 1.1-Repeat
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, "sad");
        }
        /// <summary>
        /// Test Case 1.2-Repeat
        /// </summary>
        [Test]
        public void GivenAnyMoodMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in Happy Mood");
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, "happy");
        }
        /// <summary>
        /// Test Case 2.1 
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(null);
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test Case 3.1 
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldReturnException()
        {
            string expected = "Mood is null";
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        /// <summary>
        /// Test Case 3.2 
        /// </summary>
        [Test]
        public void GivenEmptyMood_ShouldReturnException()
        {
            string expected = "Mood is empty";
            try
            {
                MoodAnalyser mood = new MoodAnalyser("");
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        /// <summary>
        /// Test Case 4.1
        /// </summary>
        [Test]
        public void GivenMoodAnalyserReflection_ShouldReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserproblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }


        ///// <summary>
        /// Test case 4.2
        /// </summary>
        [Test]
        public void GivenClassNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserproblem.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// Test case 4.3
        /// </summary>
        [Test]
        public void GivenConstructorNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserproblem.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// Test case 5.1
        /// </summary>
        [Test]
        public void GivenMoodAnalyserParameterizedConstructor_ShouldReturnObject()
        {
            object expected = new MoodAnalyser("Parameter constructor");
            object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "Parameter constructor");
            expected.Equals(actual);
        }
        /// <summary>
        /// Test case 5.2
        /// </summary>
        [Test]
        public void GivenClassNameImproperParameterizedConstructor_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyser.MoodAnalyser", "MoodAnalyser", "Parameneter");
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// Test case 5.3
        /// </summary>
        [Test]
        public void GivenImproperParameterizedConstructorName_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "Parameneter");
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}