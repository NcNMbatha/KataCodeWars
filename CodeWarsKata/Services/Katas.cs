
namespace CodeWarsKata
{
    public class Katas
    {
        public int FindShort(string sentence)
        {
            string[] wordsArray = sentence.Split(' ');
            string smallestWord = wordsArray[0];

            foreach (var word in wordsArray)
            {
                if (smallestWord.Length > word.Length)
                {
                    smallestWord = word;
                }
            }

            return smallestWord.Length;
        }
        public int FindShortTwo(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
        public int FindShortArrowMethod(string s) => s.Split(' ').Min(t => t.Length);
        public int FindShortLinq(string str)
        {
            return str.Split(' ').Select(elem => elem.Length).Min();
        }

        //

        public int[] TwoSum(int[] numbers, int target)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                for (int numberIndex = 1; numberIndex < numbers.Length; numberIndex++)
                {
                    if (numbers[index] + numbers[numberIndex] == target)
                    {
                        return new int[] { index, numberIndex };
                    }
                }
            }
            return new int[0];
        }
    }
}
