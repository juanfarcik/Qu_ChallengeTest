using ChallengeTest;

var matrixInput = new string[] { "chill", "wind", "snow", "cold" };
var wordstreamInput = new string[] { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };
var result = new WordFinder(matrixInput).Find(wordstreamInput);
Console.WriteLine(string.Join(",", result));