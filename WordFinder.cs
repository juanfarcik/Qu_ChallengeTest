using System.Text;
namespace ChallengeTest
{
    public class WordFinder
    {
        private readonly List<string> matrix;
        public WordFinder(IEnumerable<string> matrix)
        {
            this.matrix = new List<string>(matrix);
        }
        public IList<string> Find(IEnumerable<string> wordstream)
        {
            var characterMatrix = wordstream
                  .Select(wordsRow => wordsRow.ToCharArray())
                  .ToArray();

            var result = new List<string>();

            for (var i = 0; i < characterMatrix.Length; i++)
            {
                var sarchVerticalMatrix = new StringBuilder();
                var searchHorizontalMatrix = new StringBuilder();

                for (var j = 0; j < characterMatrix[i].Length; j++)
                {
                    sarchVerticalMatrix.Append(characterMatrix[i][j]);
                    searchHorizontalMatrix.Append(characterMatrix[j][i]);
                }

                var matchValueVerticalMatrix = matrix.Where(p => sarchVerticalMatrix.ToString().Contains(p)).FirstOrDefault();
                var matchValueHorizontalMatrix = matrix.Where(p => searchHorizontalMatrix.ToString().Contains(p)).FirstOrDefault();

                if (!string.IsNullOrEmpty(matchValueVerticalMatrix))
                    result.Add(matchValueVerticalMatrix);

                if (!string.IsNullOrEmpty(matchValueHorizontalMatrix))
                    result.Add(matchValueHorizontalMatrix);
            }

            return result;
        }
    }
}