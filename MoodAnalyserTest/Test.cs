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
        /// Test Case 1.1
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string actual = mood.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(actual, "Sad");
        }
        /// <summary>
        /// Test Case 1.2
        /// </summary>
        [Test]
        public void GivenAnyMoodMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string actual = mood.AnalyseMood("I am in Any Mood");
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}