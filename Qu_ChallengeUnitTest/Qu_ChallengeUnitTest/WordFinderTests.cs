using Xunit;
using ChallengeTest;

namespace Qu_ChallengeUnitTest
{
    public class WordFinder_Should
    {
        [Fact]
        public void WordInputString_should_be_equal_to ()
        {
            var matrixInput = new string[] { "chill", "wind", "snow", "cold" };
            var wordstreamInput = new string[] { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };
            var result = new WordFinder(matrixInput).Find(wordstreamInput);

            Assert.Equal("chill,wind,cold", string.Join(",", result));
        }
    }
}