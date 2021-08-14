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
            Assert.AreEqual(actual, "SAD");
        }
        /// <summary>
        /// Test Case 1.2-Repeat
        /// </summary>
        [Test]
        public void GivenAnyMoodMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in Happy Mood");
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, "SAD");
        }
        /// <summary>
        /// Test Case 2.1 
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(actual, "happy");
        }
    }
}