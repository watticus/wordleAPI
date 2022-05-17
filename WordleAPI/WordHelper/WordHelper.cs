namespace WordleAPI.WordHelper
{
    public class WordHelper
    {
        string[] wordList = File.ReadAllLines(@"C:\Code\GitLab\wordle-react\src\wordList.txt");

        public String GetWordleReturn(bool isTest)
        {
            var wordle = isTest ? "wordl" : GetRandomWord();
            return wordle;
        }
        public String GetRandomWord()
        {
            var random = new Random();
            var word = random.Next(1, wordList.Length);
            return GetWord(word);
        }

        public String GetWord(int index)
        {
            return wordList[index];
        }
    }
}